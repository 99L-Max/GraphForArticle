using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GraphForArticle
{
    partial class FormMain : Form
    {
        private Font _fontLabel;
        private Font _fontTitle;

        private static readonly Color[] s_colors;

        static FormMain()
        {
            s_colors = new Color[] {
                Color.Red, Color.Green, Color.Blue,
                Color.Orange, Color.Purple, Color.Black,
                Color.Maroon, Color.DarkGreen, Color.Cyan,
                Color.Gold, Color.Indigo, Color.DimGray
            };
        }

        public FormMain()
        {
            InitializeComponent();

            _fontLabel = _chart.ChartAreas[0].AxisX.LabelStyle.Font;
            _fontTitle = _chart.ChartAreas[0].AxisX.TitleFont;

            _btnSave.Enabled = _btnLineSettings.Enabled = false;
        }

        private void OnFormLoad(object sender, EventArgs e)
        {
            _cmbSize.SelectedIndex = 0;
            _cmbSize.SelectedIndexChanged += OnSizeChanged;

            OnDecimalPlacesChanged(null, null);
        }

        private void OnButtonLineSettingsClick(object sender, EventArgs e)
        {
            if (_chart.Series.Count > 0)
                (new FormSettingsLine(_chart.Series)).ShowDialog();
        }

        private void OnButtonOpenClick(object sender, EventArgs e)
        {
            using (OpenFileDialog ofDialog = new OpenFileDialog())
            {
                ofDialog.Filter = "Текстовые файлы|*.txt|Все файлы|*.*";

                if (ofDialog.ShowDialog() != DialogResult.OK)
                    return;

                _chart.Series.Clear();

                try
                {
                    double xMin = double.MaxValue;
                    double xMax = double.MinValue;
                    double yMin = double.MaxValue;
                    double yMax = double.MinValue;

                    string data = File.ReadAllText(ofDialog.FileName);

                    //Подгонка под формат
                    data = data.Trim('\n');
                    data = data.Replace('\t', ' ');
                    data = data.Replace('.', ',');
                    data = Regex.Replace(data, @"([ ]){2,}", @"$1");

                    string[] lines = data.Split(new[] { Environment.NewLine }, StringSplitOptions.None);

                    if (lines.Length < 2)
                        throw new Exception("Недостаточно данных. Необходимо минимум по две точки для каждого графика.");

                    int countSeries = lines[0].Count(c => c == ' ');

                    if (countSeries == 0)
                        throw new Exception("Недостаточно данных. Необходимо минимум два столбца: x и y.");

                    for (int i = 0; i < countSeries; i++)
                    {
                        Series series = new Series
                        {
                            BorderWidth = 3,//По умолчанию
                            ChartType = SeriesChartType.Spline,//По умолчанию
                            Color = s_colors[i % s_colors.Length]
                        };

                        _chart.Series.Add(series);
                    }

                    double[] points;

                    for (int i = 0; i < lines.Length; i++)
                    {
                        points = lines[i].Split(' ').Select(x => Convert.ToDouble(x)).ToArray();

                        if (xMin > points[0]) xMin = points[0];
                        if (xMax < points[0]) xMax = points[0];

                        for (int j = 1; j < points.Length; j++)
                        {
                            _chart.Series[j - 1].Points.AddXY(points[0], points[j]);

                            if (yMin > points[j]) yMin = points[j];
                            if (yMax < points[j]) yMax = points[j];
                        }
                    }

                    _numXMin.Value = (decimal)xMin;
                    _numXMax.Value = (decimal)xMax;
                    _numYMin.Value = (decimal)Math.Floor(yMin);
                    _numYMax.Value = (decimal)Math.Ceiling(yMax);

                    //По умолчанию на 5 отрезков делим
                    _numXInterval.Value = (_numXMax.Value - _numXMin.Value) / 5m;
                    _numYInterval.Value = (_numYMax.Value - _numYMin.Value) / 5m;

                    _btnSave.Enabled = _btnLineSettings.Enabled = true;
                }
                catch (Exception exc)
                {
                    _chart.Series.Clear();
                    _btnSave.Enabled = _btnLineSettings.Enabled = false;

                    MessageBox.Show(exc.Message + Environment.NewLine + Properties.Resources.ErrorMessage, "Ошибка чтения файла", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void OnButtonSaveClick(object sender, EventArgs e)
        {
            using (SaveFileDialog svDialog = new SaveFileDialog())
            {
                svDialog.Filter = "Изображения|*.png";

                if (svDialog.ShowDialog() != DialogResult.OK)
                    return;

                _chart.SaveImage(svDialog.FileName, System.Drawing.Imaging.ImageFormat.Png);
            }
        }

        private void OnSizeChanged(object sender, EventArgs e)
        {
            int[] size = _cmbSize.SelectedItem.ToString().Split(':').Select(x => Convert.ToInt32(x)).ToArray();
            _chart.Height = _chart.Width * size[1] / size[0];
        }

        private void OnDecimalPlacesChanged(object sender, EventArgs e)
        {
            var decimalPlaces = (int)_numDecimalPlaces.Value;
            var increment = (decimal)Math.Pow(10, -(int)_numDecimalPlaces.Value);
            var numericUpDowns = new NumericUpDown[] { _numXMin, _numYMin, _numXMax, _numYMax, _numXInterval, _numYInterval };

            foreach (var ctrl in numericUpDowns)
            {
                ctrl.DecimalPlaces = decimalPlaces;
                ctrl.Increment = increment;
            }
        }

        private void OnXMinChanged(object sender, EventArgs e)
        {
            _numXMax.Minimum = _numXMin.Value;
            _chart.ChartAreas[0].AxisX.Minimum = (double)_numXMin.Value;
        }

        private void OnXMaxChanged(object sender, EventArgs e)
        {
            _numXMin.Maximum = _numXMax.Value;
            _chart.ChartAreas[0].AxisX.Maximum = (double)_numXMax.Value;
        }

        private void OnYMinChanged(object sender, EventArgs e)
        {
            _numYMax.Minimum = _numYMin.Value;
            _chart.ChartAreas[0].AxisY.Minimum = (double)_numYMin.Value;
        }

        private void OnYMaxChanged(object sender, EventArgs e)
        {
            _numYMin.Maximum = _numYMax.Value;
            _chart.ChartAreas[0].AxisY.Maximum = (double)_numYMax.Value;
        }

        private void OnXIntervalChanged(object sender, EventArgs e) =>
            _chart.ChartAreas[0].AxisX.Interval = (double)_numXInterval.Value;

        private void OnYIntervalChanged(object sender, EventArgs e) =>
            _chart.ChartAreas[0].AxisY.Interval = (double)_numYInterval.Value;

        private void OnAxisYTextChanged(object sender, EventArgs e) =>
            _chart.ChartAreas[0].AxisY.Title = _txtNameY.Text;

        private void OnAxisXTextChanged(object sender, EventArgs e) =>
            _chart.ChartAreas[0].AxisX.Title = _txtNameX.Text;

        private void SetFontAxis(object sender, EventArgs e)
        {
            Font fontLabel = new Font("", (int)_numFontSize.Value);
            Font fontTitle = new Font("", (int)_numFontSize.Value, _chbItalics.Checked ? FontStyle.Italic : FontStyle.Regular);

            _chart.ChartAreas[0].AxisX.LabelStyle.Font = fontLabel;
            _chart.ChartAreas[0].AxisY.LabelStyle.Font = fontLabel;

            _chart.ChartAreas[0].AxisX.TitleFont = fontTitle;
            _chart.ChartAreas[0].AxisY.TitleFont = fontTitle;

            _fontLabel.Dispose();
            _fontTitle.Dispose();

            _fontLabel = fontLabel;
            _fontTitle = fontTitle;
        }

        private void OnButtonEnabledChanged(object sender, EventArgs e)
        {
            if (sender is Button btn)
                btn.BackColor = btn.Enabled ? Color.White : Color.Gray;
        }
    }
}
