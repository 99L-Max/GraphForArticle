using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GraphForArticle
{
    public partial class FormMain : Form
    {
        //Настройки линии
        private FormSettingsLine formSettingsLine;
        public FormMain()
        {
            InitializeComponent();
            comboBoxSize.SelectedIndex = 0;
            for (int i = 0; i < FormSettingsLine.colors.Length; i++)
            {
                Series series = new Series
                {
                    BorderWidth = 2,//Толщина по умолчанию
                    ChartType = SeriesChartType.Spline,
                    Color = FormSettingsLine.colors[i],
                };
                chart.Series.Add(series);
            }
        }
        //Открыть
        private void buttonOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFDialog = new OpenFileDialog
            {
                Filter = "Текстовые файлы|*.txt|Все файлы|*.*"
            };
            DialogResult dr = OFDialog.ShowDialog();
            //Была ли нажата кнопка ОК
            if (dr != DialogResult.OK)
                return;
            //Очистка старого графика
            foreach (var el in chart.Series)
                el.Points.Clear();
            try
            {
                using (StreamReader reader = new StreamReader(OFDialog.FileName))
                {
                    double[] points;
                    double
                        xMin = double.MaxValue,
                        xMax = double.MinValue,
                        yMin = double.MaxValue,
                        yMax = double.MinValue;
                    while (!reader.EndOfStream)
                    {
                        points = reader.ReadLine().Split(' ').Select(x => Convert.ToDouble(x)).ToArray();
                        if (points[0] < xMin)
                            xMin = points[0];
                        if (points[0] > xMax)
                            xMax = points[0];
                        for (int j = 1; j < points.Length; j++)
                        {
                            chart.Series[j - 1].Points.AddXY(points[0], points[j]);
                            if (points[j] < yMin)
                                yMin = points[j];
                            if (points[j] > yMax)
                                yMax = points[j];
                        }
                    }
                    //Границы графика
                    numericUpDownXMin.Value = (decimal)xMin;
                    numericUpDownXMax.Value = (decimal)xMax;
                    numericUpDownYMin.Value = (decimal)Math.Floor(yMin);
                    numericUpDownYMax.Value = (decimal)Math.Ceiling(yMax);
                    numericUpDownDX.Value = (numericUpDownXMax.Value - numericUpDownXMin.Value) / 5m;
                    numericUpDownDY.Value = (numericUpDownYMax.Value - numericUpDownYMin.Value) / 5m;
                    SetFontAxis(null, null);
                }
            }
            catch (Exception exc)
            {
                foreach (var el in chart.Series)
                    el.Points.Clear();
                MessageBox.Show(
                    exc.Message +
                    $"{Environment.NewLine}Значения должны быть записаны в столбик через пробел.{Environment.NewLine}" +
                    $"Первый столбец должен содержать значения оси Ox,{Environment.NewLine}" +
                    $"все остальные столбцы - значения оси Oy.{Environment.NewLine}" +
                    $"Пример:{Environment.NewLine}" +
                    $"0 0 1 -2{Environment.NewLine}" +
                    $"1 1 3 -1{Environment.NewLine}" +
                    $"2 4 5 6{Environment.NewLine}" +
                    $"3 9 7 25{Environment.NewLine}" +
                    $"4 16 9 62{Environment.NewLine}" +
                    $"5 25 11 123{Environment.NewLine}"
                    , "Ошибка чтения файла", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Сохранить
        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog SVDialog = new SaveFileDialog
            {
                Filter = "Изображения|*.png|Все файлы|*.*"
            };
            DialogResult dr = SVDialog.ShowDialog();
            if (dr != DialogResult.OK)
                return;
            chart.SaveImage(SVDialog.FileName, System.Drawing.Imaging.ImageFormat.Png);
        }
        //Разрешение
        private void comboBoxSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            int[] size = comboBoxSize.SelectedItem.ToString().Split(':').Select(x => Convert.ToInt32(x)).ToArray();
            chart.Width = chart.Height * size[0] / size[1];
        }
        //Настройки линии
        private void button1_Click(object sender, EventArgs e)
        {
            formSettingsLine = new FormSettingsLine(chart.Series);
            formSettingsLine.ShowDialog();
        }
        //Обновление счётчиков
        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDownXMax.Value < numericUpDownXMin.Value)
            {
                decimal temp = numericUpDownXMax.Value;
                numericUpDownXMax.Value = numericUpDownXMin.Value;
                numericUpDownXMin.Value = temp;
            }
            if (numericUpDownYMax.Value < numericUpDownYMin.Value)
            {
                decimal temp = numericUpDownYMax.Value;
                numericUpDownYMax.Value = numericUpDownYMin.Value;
                numericUpDownYMin.Value = temp;
            }
            chart.ChartAreas[0].AxisX.Minimum = (double)numericUpDownXMin.Value;
            chart.ChartAreas[0].AxisX.Maximum = (double)numericUpDownXMax.Value;
            chart.ChartAreas[0].AxisY.Minimum = (double)numericUpDownYMin.Value;
            chart.ChartAreas[0].AxisY.Maximum = (double)numericUpDownYMax.Value;
            chart.ChartAreas[0].AxisY.Interval = (double)numericUpDownDY.Value;
            chart.ChartAreas[0].AxisX.Interval = (double)numericUpDownDX.Value;
        }
        //Шрифты оси
        private void SetFontAxis(object sender, EventArgs e)
        {
            chart.ChartAreas[0].AxisX.Title = textBoxNameX.Text;
            chart.ChartAreas[0].AxisY.Title = textBoxNameY.Text;
            chart.ChartAreas[0].AxisX.LabelStyle.Font =
                chart.ChartAreas[0].AxisY.LabelStyle.Font = 
                new Font("System", (int)numericUpDownFontSize.Value);
            chart.ChartAreas[0].AxisX.TitleFont =
                chart.ChartAreas[0].AxisY.TitleFont =
                new Font("System", (int)numericUpDownFontSize.Value, checkBoxItalics.Checked ? FontStyle.Italic : FontStyle.Regular);
        }
    }
}
