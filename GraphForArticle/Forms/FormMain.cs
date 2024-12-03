using GraphForArticle.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GraphForArticle
{
    partial class FormMain : Form
    {
        private readonly Size _aspectRatioChart = new Size(16, 9);

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

        public FormMain() =>
            InitializeComponent();

        private void OnFormLoad(object sender, EventArgs e)
        {
            _fontLabel = _chart.ChartAreas[0].AxisX.LabelStyle.Font;
            _fontTitle = _chart.ChartAreas[0].AxisX.TitleFont;

            _btnSave.Enabled = _btnLineSettings.Enabled = false;

            OnDecimalPlacesChanged(_numDecimalPlaces, EventArgs.Empty);
        }

        private void OnButtonLineSettingsClick(object sender, EventArgs e)
        {
            if (_chart.Series.Count > 0)
                (new FormSettingsLine(_chart.Series)).ShowDialog();
        }

        private void OnButtonOpenClick(object sender, EventArgs e)
        {
            try
            {
                var data = FileHandler.Open();

                if (data.GetLength(0) < 2)
                    throw new Exception("Недостаточно данных. Необходимо минимум по две точки для каждого графика.");

                if (data.GetLength(1) < 2)
                    throw new Exception("Недостаточно данных. Необходимо минимум два столбца: x и y.");

                _chart.Series.Clear();

                for (int i = 0; i < data.GetLength(1) - 1; i++)
                {
                    var series = new Series
                    {
                        BorderWidth = 3,//По умолчанию
                        ChartType = SeriesChartType.Spline,
                        Color = s_colors[i % s_colors.Length]
                    };

                    _chart.Series.Add(series);
                }

                var xMin = double.MaxValue;
                var xMax = double.MinValue;
                var yMin = double.MaxValue;
                var yMax = double.MinValue;

                for (int i = 0; i < data.GetLength(0); i++)
                {
                    if (xMin > data[i, 0]) xMin = data[i, 0];
                    if (xMax < data[i, 0]) xMax = data[i, 0];

                    for (int j = 1; j < data.GetLength(1); j++)
                    {
                        _chart.Series[j - 1].Points.AddXY(data[i, 0], data[i, j]);

                        if (yMin > data[i, j]) yMin = data[i, j];
                        if (yMax < data[i, j]) yMax = data[i, j];
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
                MessageBox.Show($"{exc.Message}\n\n{Resources.ErrorMessage}", "Ошибка чтения файла", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OnButtonSaveClick(object sender, EventArgs e) =>
            FileHandler.Save(_chart);

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

        private void OnButtonEnabledChanged(object sender, EventArgs e)
        {
            if (sender is Button btn)
                btn.BackColor = btn.Enabled ? Color.White : Color.Gray;
        }

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

        private void OnChartSizeChanged(object sender, EventArgs e) =>
            _chart.Height = _chart.Width * _aspectRatioChart.Height / _aspectRatioChart.Width;
    }
}
