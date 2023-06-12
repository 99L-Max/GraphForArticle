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
        //Цвета линий по умолчанию
        private static readonly Color[] colorLine = {
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
        //Загрузка формы
        private void FormChart_Load(object sender, EventArgs e)
        {
            comboBoxSize.SelectedIndex = 0;
            comboBoxSize.SelectedIndexChanged += ComboBoxSize_SelectedIndexChanged;
            NumericUpDownDecimalPlaces_ValueChanged(null, null);
        }
        //Настройки линии
        private void ButtonLineSettings_Click(object sender, EventArgs e)
        {
            if (chart.Series.Count > 0)
                (new FormSettingsLine(chart.Series)).ShowDialog();
        }
        //Открыть
        private void ButtonOpen_Click(object sender, EventArgs e)
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
            chart.Series.Clear();
            try
            {
                double
                    xMin = double.MaxValue,
                    xMax = double.MinValue,
                    yMin = double.MaxValue,
                    yMax = double.MinValue;
                //Чтение
                string data = File.ReadAllText(OFDialog.FileName);
                //Подгонка под формат
                data = data.Trim('\n');
                data = data.Replace('\t', ' ');
                data = data.Replace('.', ',');
                data = Regex.Replace(data, @"([ ]){2,}", @"$1");
                //Разбиение на линии
                string[] lines = data.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
                if (lines.Length < 2)
                    throw new Exception("Недостаточно данных. Необходимо минимум по две точки для каждого графика.");
                //Число графиков
                int countSeries = lines[0].Count(c => c == ' ');
                if (countSeries == 0)
                    throw new Exception("Недостаточно данных. Необходимо минимум два столбца: x и y.");
                //Создание линий
                for (int i = 0; i < countSeries; i++)
                {
                    Series series = new Series
                    {
                        BorderWidth = 3,//По умолчанию
                        ChartType = SeriesChartType.Spline,//По умолчанию
                        Color = colorLine[i % colorLine.Length]
                    };
                    chart.Series.Add(series);
                }
                //Построение
                double[] points;
                for (int i = 0; i < lines.Length; i++)
                {
                    points = lines[i].Split(' ').Select(x => Convert.ToDouble(x)).ToArray();
                    //Границы x
                    if (xMin > points[0])
                        xMin = points[0];
                    if (xMax < points[0])
                        xMax = points[0];
                    for (int j = 1; j < points.Length; j++)
                    {
                        chart.Series[j - 1].Points.AddXY(points[0], points[j]);
                        //Границы y
                        if (yMin > points[j])
                            yMin = points[j];
                        if (yMax < points[j])
                            yMax = points[j];
                    }
                }
                //Границы графика
                numericUpDownXMin.Value = (decimal)xMin;
                numericUpDownXMax.Value = (decimal)xMax;
                numericUpDownYMin.Value = (decimal)Math.Floor(yMin);
                numericUpDownYMax.Value = (decimal)Math.Ceiling(yMax);
                numericUpDownXInterval.Value = (numericUpDownXMax.Value - numericUpDownXMin.Value) / 5m;
                numericUpDownYInterval.Value = (numericUpDownYMax.Value - numericUpDownYMin.Value) / 5m;
                SetFontAxis(null, null);
                buttonSave.Enabled = buttonLineSettings.Enabled = true;
            }
            catch (Exception exc)
            {
                chart.Series.Clear();
                buttonSave.Enabled = buttonLineSettings.Enabled = false;
                MessageBox.Show(
                    exc.Message + Environment.NewLine +
                    $"Значения должны быть записаны в столбик через пробел.{Environment.NewLine}" +
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
        //Сохранить график
        private void ButtonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog SVDialog = new SaveFileDialog
            {
                Filter = "Изображения|*.png"
            };
            DialogResult dr = SVDialog.ShowDialog();
            if (dr != DialogResult.OK)
                return;
            chart.SaveImage(SVDialog.FileName, System.Drawing.Imaging.ImageFormat.Png);
        }
        //Разрешение
        private void ComboBoxSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            int[] size = comboBoxSize.SelectedItem.ToString().Split(':').Select(x => Convert.ToInt32(x)).ToArray();
            chart.Height = chart.Width * size[1] / size[0];
        }
        //Число знаков после запятой
        private void NumericUpDownDecimalPlaces_ValueChanged(object sender, EventArgs e)
        {
            numericUpDownXMin.DecimalPlaces =
            numericUpDownXMax.DecimalPlaces =
            numericUpDownYMin.DecimalPlaces =
            numericUpDownYMax.DecimalPlaces =
            numericUpDownYInterval.DecimalPlaces =
            numericUpDownXInterval.DecimalPlaces = (int)numericUpDownDecimalPlaces.Value;
            numericUpDownXMin.Increment =
            numericUpDownXMax.Increment =
            numericUpDownYMin.Increment =
            numericUpDownYMax.Increment =
            numericUpDownYInterval.Increment =
            numericUpDownXInterval.Increment =
            numericUpDownXInterval.Minimum =
            numericUpDownYInterval.Minimum = (decimal)Math.Pow(10, -(int)numericUpDownDecimalPlaces.Value);
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
        //Смена цвета при блокировке
        private void Button_EnabledChanged(object sender, EventArgs e)
        {
            Button button = (sender as Button);
            button.BackColor = button.Enabled ? Color.White : Color.Gray;
        }
    }
}
