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
        private static readonly Color[] colors = {
            Color.Red, Color.Green, Color.Blue,
            Color.Orange, Color.Purple, Color.Black,
            Color.Maroon, Color.DarkGreen, Color.Cyan,
            Color.Gold, Color.Indigo, Color.DimGray
        };

        public FormMain()
        {
            InitializeComponent();
            buttonSave.Enabled = buttonLineSettings.Enabled = false;
        }

        private void FormChart_Load(object sender, EventArgs e)
        {
            comboBoxSize.SelectedIndex = 0;
            comboBoxSize.SelectedIndexChanged += ComboBoxSize_SelectedIndexChanged;
            NumericUpDownDecimalPlaces_ValueChanged(null, null);
        }

        private void OnButtonLineSettingsClick(object sender, EventArgs e)
        {
            if (chart.Series.Count > 0)
                (new FormSettingsLine(chart.Series)).ShowDialog();
        }

        private void OnButtonOpenClick(object sender, EventArgs e)
        {
            OpenFileDialog OFDialog = new OpenFileDialog
            {
                Filter = "Текстовые файлы|*.txt|Все файлы|*.*"
            };

            DialogResult dr = OFDialog.ShowDialog();

            if (dr != DialogResult.OK) return;

            chart.Series.Clear();

            try
            {
                double xMin = double.MaxValue;
                double xMax = double.MinValue;
                double yMin = double.MaxValue;
                double yMax = double.MinValue;

                string data = File.ReadAllText(OFDialog.FileName);

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
                        Color = colors[i % colors.Length]
                    };
                    chart.Series.Add(series);
                }

                double[] points;

                for (int i = 0; i < lines.Length; i++)
                {
                    points = lines[i].Split(' ').Select(x => Convert.ToDouble(x)).ToArray();

                    if (xMin > points[0]) xMin = points[0];
                    if (xMax < points[0]) xMax = points[0];

                    for (int j = 1; j < points.Length; j++)
                    {
                        chart.Series[j - 1].Points.AddXY(points[0], points[j]);

                        if (yMin > points[j]) yMin = points[j];
                        if (yMax < points[j]) yMax = points[j];
                    }
                }

                numericUpDownXMin.Value = (decimal)xMin;
                numericUpDownXMax.Value = (decimal)xMax;
                numericUpDownYMin.Value = (decimal)Math.Floor(yMin);
                numericUpDownYMax.Value = (decimal)Math.Ceiling(yMax);

                //По умолчанию на 5 отрезков делим
                numericUpDownXInterval.Value = (numericUpDownXMax.Value - numericUpDownXMin.Value) / 5m;
                numericUpDownYInterval.Value = (numericUpDownYMax.Value - numericUpDownYMin.Value) / 5m;

                SetFontAxis(null, null);

                buttonSave.Enabled = buttonLineSettings.Enabled = true;
            }
            catch (Exception exc)
            {
                chart.Series.Clear();
                buttonSave.Enabled = buttonLineSettings.Enabled = false;
                MessageBox.Show(exc.Message + Environment.NewLine + Properties.Resources.ErrorMessage, "Ошибка чтения файла", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OnButtonSaveClick(object sender, EventArgs e)
        {
            SaveFileDialog SVDialog = new SaveFileDialog
            {
                Filter = "Изображения|*.png"
            };

            DialogResult dr = SVDialog.ShowDialog();

            if (dr != DialogResult.OK) return;

            chart.SaveImage(SVDialog.FileName, System.Drawing.Imaging.ImageFormat.Png);
        }

        private void ComboBoxSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            int[] size = comboBoxSize.SelectedItem.ToString().Split(':').Select(x => Convert.ToInt32(x)).ToArray();
            chart.Height = chart.Width * size[1] / size[0];
        }

        private void NumericUpDownDecimalPlaces_ValueChanged(object sender, EventArgs e)
        {
            int decimalPlaces = (int)numericUpDownDecimalPlaces.Value;
            decimal increment = (decimal)Math.Pow(10, -(int)numericUpDownDecimalPlaces.Value);

            var numerics = groupBoxOX.Controls.OfType<NumericUpDown>().Concat(groupBoxOY.Controls.OfType<NumericUpDown>()).ToList();

            foreach (var ctrl in numerics)
            {
                ctrl.DecimalPlaces = decimalPlaces;
                ctrl.Increment = increment;
            }
        }

        //Min(x)
        private void NumericUpDownXMin_ValueChanged(object sender, EventArgs e)
        {
            numericUpDownXMax.Minimum = numericUpDownXMin.Value;
            chart.ChartAreas[0].AxisX.Minimum = (double)numericUpDownXMin.Value;
        }

        //Max(x)
        private void NumericUpDownXMax_ValueChanged(object sender, EventArgs e)
        {
            numericUpDownXMin.Maximum = numericUpDownXMax.Value;
            chart.ChartAreas[0].AxisX.Maximum = (double)numericUpDownXMax.Value;
        }

        //Min(y)
        private void NumericUpDownYMin_ValueChanged(object sender, EventArgs e)
        {
            numericUpDownYMax.Minimum = numericUpDownYMin.Value;
            chart.ChartAreas[0].AxisY.Minimum = (double)numericUpDownYMin.Value;
        }

        //Max(y)
        private void NumericUpDownYMax_ValueChanged(object sender, EventArgs e)
        {
            numericUpDownYMin.Maximum = numericUpDownYMax.Value;
            chart.ChartAreas[0].AxisY.Maximum = (double)numericUpDownYMax.Value;
        }

        //Шаг x
        private void NumericUpDownXInterval_ValueChanged(object sender, EventArgs e)
        {
            chart.ChartAreas[0].AxisX.Interval = (double)numericUpDownXInterval.Value;
        }

        //Шаг y
        private void NumericUpDownYInterval_ValueChanged(object sender, EventArgs e)
        {
            chart.ChartAreas[0].AxisY.Interval = (double)numericUpDownYInterval.Value;
        }

        private void SetFontAxis(object sender, EventArgs e)
        {
            Font fontLabel = new Font("System", (int)numericUpDownFontSize.Value);
            Font fontTitle = new Font("System", (int)numericUpDownFontSize.Value, checkBoxItalics.Checked ? FontStyle.Italic : FontStyle.Regular);

            chart.ChartAreas[0].AxisX.Title = textBoxNameX.Text;
            chart.ChartAreas[0].AxisY.Title = textBoxNameY.Text;

            chart.ChartAreas[0].AxisX.LabelStyle.Font = fontLabel;
            chart.ChartAreas[0].AxisY.LabelStyle.Font = fontLabel;

            chart.ChartAreas[0].AxisX.TitleFont = fontTitle;
            chart.ChartAreas[0].AxisY.TitleFont = fontTitle;
        }

        private void Button_EnabledChanged(object sender, EventArgs e)
        {
            Button button = (sender as Button);
            button.BackColor = button.Enabled ? Color.White : Color.Gray;
        }
    }
}
