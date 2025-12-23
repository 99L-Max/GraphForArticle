using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GraphForArticle
{
    partial class FormSettingsLine : Form
    {
        private readonly SeriesCollection _series;

        private int _seriesSelectedIndex = 0;
        private bool _isUserChangeValue = true;

        public FormSettingsLine(SeriesCollection series)
        {
            InitializeComponent();
            _series = series;
        }

        private void OnFormLoad(object sender, EventArgs e)
        {
            _numNumberLine.Maximum = _series.Count;
            _cmbBorderDashStyle.Items.AddRange(EnumFactory.GetEnumStrings<ChartDashStyle>());

            OnLineChanged(_numNumberLine, EventArgs.Empty);
        }

        private void SetColorLineOnForm()
        {
            _lblCurrentColor.BackColor = _series[_seriesSelectedIndex].Color;

            _isUserChangeValue = false;

            _numRed.Value = _lblCurrentColor.BackColor.R;
            _numGreen.Value = _lblCurrentColor.BackColor.G;
            _numBlue.Value = _lblCurrentColor.BackColor.B;

            _isUserChangeValue = true;
        }

        private void OnLineChanged(object sender, EventArgs e)
        {
            _seriesSelectedIndex = (int)_numNumberLine.Value - 1;
            _numBorderWidth.Value = _series[_seriesSelectedIndex].BorderWidth;
            _cmbBorderDashStyle.SelectedIndex = (int)_series[_seriesSelectedIndex].BorderDashStyle;

            SetColorLineOnForm();
        }

        private void OnBorderDashStyleChanged(object sender, EventArgs e)
        { 
            _series[_seriesSelectedIndex].BorderDashStyle = (ChartDashStyle)_cmbBorderDashStyle.SelectedIndex;
        }

        private void OnBorderWidthChanged(object sender, EventArgs e)
        { 
            _series[_seriesSelectedIndex].BorderWidth = (int)_numBorderWidth.Value;
        }

        private void OnColorClick(object sender, EventArgs e)
        {
            if (sender is Label label)
            {
                _series[_seriesSelectedIndex].Color = label.BackColor;
                SetColorLineOnForm();
            }
        }

        private void OnRGBChanged(object sender, EventArgs e)
        {
            if (_isUserChangeValue)
            {
                _lblCurrentColor.BackColor = Color.FromArgb((int)_numRed.Value, (int)_numGreen.Value, (int)_numBlue.Value);
                _series[_seriesSelectedIndex].Color = _lblCurrentColor.BackColor;
            }
        }
    }
}
