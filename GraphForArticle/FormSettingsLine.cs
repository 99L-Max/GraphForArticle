using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GraphForArticle
{
    public partial class FormSettingsLine : Form
    {
        //Цвета
        public static readonly Color[] colors = {
            Color.Red, Color.Orange, Color.Yellow, Color.Green, Color.Cyan,
            Color.Blue, Color.Purple, Color.Pink, Color.Brown, Color.Black
        };
        private SeriesCollection series;
        private PictureBox[] pictureBoxColors = new PictureBox[colors.Length];//Выбор цвета
        public FormSettingsLine(SeriesCollection series)
        {
            InitializeComponent();
            this.series = series;
            numericUpDownNumberLine.Maximum = this.series.Count;
            numericUpDownNumberLine_ValueChanged(null, null);
            //Настройки панели для изменения цветов
            int delta = 15;
            int countCollumns = colors.Length / 2;
            int picWidth = (groupBoxColors.Width - delta * (countCollumns + 1)) / countCollumns;
            int picHeight = (groupBoxColors.Height - 3 * delta) / 2;
            int posLine, posCollumn;
            for (int i = 0; i < pictureBoxColors.Length; i++)
            {
                posCollumn = i % countCollumns;
                posLine = i / countCollumns;
                pictureBoxColors[i] = new PictureBox
                {
                    Size = new Size(picWidth, picHeight),
                    Location = new Point(picWidth * posCollumn + delta * (posCollumn + 1), picHeight * posLine + delta * (posLine + 1) + 7),
                    BackColor = this.series[i].Color,
                    Name = i.ToString()
                };
                groupBoxColors.Controls.Add(pictureBoxColors[i]);
                pictureBoxColors[i].Click += new System.EventHandler(pictureBoxColor_Click);
            }
        }
        //Смена графика
        private void numericUpDownNumberLine_ValueChanged(object sender, System.EventArgs e)
        {
            int index = (int)numericUpDownNumberLine.Value - 1;
            comboBoxTypeLine.SelectedIndex = series[index].BorderDashStyle == ChartDashStyle.Solid ? 0 : 1;
            numericUpDownBorderWidth.Value = series[index].BorderWidth;
            pictureBoxCurrentColor.BackColor = series[index].Color;
        }
        //Выбран цвет
        private void pictureBoxColor_Click(object sender, System.EventArgs e)
        {
            pictureBoxCurrentColor.BackColor = (sender as PictureBox).BackColor;
            int index = (int)numericUpDownNumberLine.Value - 1;
            if (pictureBoxCurrentColor.BackColor != series[index].Color)
            {
                for (int i = 0; i < series.Count; i++)
                {
                    if (series[i].Color == pictureBoxCurrentColor.BackColor)
                    {
                        series[i].Color = series[index].Color;
                        series[index].Color = pictureBoxCurrentColor.BackColor;
                        break;
                    }
                }
            }
        }
        //Тип линии
        private void comboBoxTypeLine_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            //Применить тип линии и толщину ко всем
            if (checkBoxApplyToAll.Checked)
            {
                ChartDashStyle style = comboBoxTypeLine.SelectedIndex == 0 ? ChartDashStyle.Solid : ChartDashStyle.Dash;
                for (int i = 0; i < series.Count; i++)
                    series[i].BorderDashStyle = style;
            }
            else
                series[(int)numericUpDownNumberLine.Value - 1].BorderDashStyle = comboBoxTypeLine.SelectedIndex == 0 ? ChartDashStyle.Solid : ChartDashStyle.Dash;
        }
        //Толщина линии
        private void numericUpDownBorderWidth_ValueChanged(object sender, System.EventArgs e)
        {
            //Применить тип линии и толщину ко всем
            if (checkBoxApplyToAll.Checked)
            {
                int width = (int)numericUpDownBorderWidth.Value;
                for (int i = 0; i < series.Count; i++)
                    series[i].BorderWidth = width;
            }
            else
                series[(int)numericUpDownNumberLine.Value - 1].BorderWidth = (int)numericUpDownBorderWidth.Value;
        }
        //Применить ко всем
        private void checkBoxApplyToAll_CheckedChanged(object sender, System.EventArgs e)
        {
            numericUpDownNumberLine.Enabled = !checkBoxApplyToAll.Checked;
        }
    }
}
