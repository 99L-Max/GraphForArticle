using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GraphForArticle
{
    partial class FormSettingsLine : Form
    {
        private SeriesCollection series;
        private int selectedIndex = 0;
        private NumericUpDown[] numericsRGB = new NumericUpDown[3];
        public FormSettingsLine(SeriesCollection series)
        {
            InitializeComponent();
            numericsRGB[0] = numericUpDownRed;
            numericsRGB[1] = numericUpDownGreen;
            numericsRGB[2] = numericUpDownBlue;
            this.series = series;
            numericUpDownNumberLine.Maximum = this.series.Count;
            numericUpDownNumberLine_ValueChanged(null, null);
        }
        //Вернуть цвет на форму
        private void SetColorLineOnForm()
        {
            labelCurrentColor.BackColor = series[selectedIndex].Color;
            //Отвязать обработку события, чтобы метод
            //numericUpDownRGB_ValueChanged не вызывался три раза
            //и чтобы цвет определился корректно
            foreach (var el in numericsRGB)
                el.ValueChanged -= numericUpDownRGB_ValueChanged;
            numericUpDownRed.Value = labelCurrentColor.BackColor.R;
            numericUpDownGreen.Value = labelCurrentColor.BackColor.G;
            numericUpDownBlue.Value = labelCurrentColor.BackColor.B;
            //Привязать обработчик обратно
            foreach (var el in numericsRGB)
                el.ValueChanged += numericUpDownRGB_ValueChanged;
        }
        //Выбор номера графика
        private void numericUpDownNumberLine_ValueChanged(object sender, EventArgs e)
        {
            selectedIndex = (int)numericUpDownNumberLine.Value - 1;
            numericUpDownBorderWidth.Value = series[selectedIndex].BorderWidth;
            comboBoxTypeLine.SelectedIndex = series[selectedIndex].BorderDashStyle == ChartDashStyle.Solid ? 0 : 1;
            SetColorLineOnForm();
        }
        //Тип линии
        private void comboBoxTypeLine_SelectedIndexChanged(object sender, EventArgs e)
        {
            series[selectedIndex].BorderDashStyle = comboBoxTypeLine.SelectedIndex == 0 ? ChartDashStyle.Solid : ChartDashStyle.Dash;
        }
        //Толщина линии
        private void numericUpDownBorderWidth_ValueChanged(object sender, EventArgs e)
        {
            series[selectedIndex].BorderWidth = (int)numericUpDownBorderWidth.Value;
        }
        //Выбор цвета линии
        private void labelColor_Click(object sender, EventArgs e)
        {
            series[selectedIndex].Color = (sender as Label).BackColor;
            SetColorLineOnForm();
        }
        //Персональный цвет
        private void numericUpDownRGB_ValueChanged(object sender, EventArgs e)
        {
            labelCurrentColor.BackColor = Color.FromArgb(
                    (int)numericUpDownRed.Value,
                    (int)numericUpDownGreen.Value,
                    (int)numericUpDownBlue.Value
                );
            series[selectedIndex].Color = labelCurrentColor.BackColor;
        }
    }
}
