
namespace GraphForArticle
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this._btnSave = new System.Windows.Forms.Button();
            this._lbl8 = new System.Windows.Forms.Label();
            this._numFontSize = new System.Windows.Forms.NumericUpDown();
            this._chbItalics = new System.Windows.Forms.CheckBox();
            this._lbl10 = new System.Windows.Forms.Label();
            this._txtNameY = new System.Windows.Forms.TextBox();
            this._lbl9 = new System.Windows.Forms.Label();
            this._txtNameX = new System.Windows.Forms.TextBox();
            this._btnLineSettings = new System.Windows.Forms.Button();
            this._grbAxis = new System.Windows.Forms.GroupBox();
            this._grbOY = new System.Windows.Forms.GroupBox();
            this._lbl11 = new System.Windows.Forms.Label();
            this._lbl12 = new System.Windows.Forms.Label();
            this._lbl13 = new System.Windows.Forms.Label();
            this._numYMin = new System.Windows.Forms.NumericUpDown();
            this._numYMax = new System.Windows.Forms.NumericUpDown();
            this._numYInterval = new System.Windows.Forms.NumericUpDown();
            this._grbOX = new System.Windows.Forms.GroupBox();
            this._lbl3 = new System.Windows.Forms.Label();
            this._lbl2 = new System.Windows.Forms.Label();
            this._numXInterval = new System.Windows.Forms.NumericUpDown();
            this._lbl1 = new System.Windows.Forms.Label();
            this._numXMin = new System.Windows.Forms.NumericUpDown();
            this._numXMax = new System.Windows.Forms.NumericUpDown();
            this._numDecimalPlaces = new System.Windows.Forms.NumericUpDown();
            this._lbl5 = new System.Windows.Forms.Label();
            this._grbNum = new System.Windows.Forms.GroupBox();
            this._btnOpen = new System.Windows.Forms.Button();
            this._chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this._numFontSize)).BeginInit();
            this._grbAxis.SuspendLayout();
            this._grbOY.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._numYMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._numYMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._numYInterval)).BeginInit();
            this._grbOX.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._numXInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._numXMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._numXMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._numDecimalPlaces)).BeginInit();
            this._grbNum.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._chart)).BeginInit();
            this.SuspendLayout();
            // 
            // _btnSave
            // 
            this._btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnSave.BackColor = System.Drawing.Color.White;
            this._btnSave.ForeColor = System.Drawing.Color.Black;
            this._btnSave.Location = new System.Drawing.Point(787, 815);
            this._btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._btnSave.Name = "_btnSave";
            this._btnSave.Size = new System.Drawing.Size(192, 44);
            this._btnSave.TabIndex = 2;
            this._btnSave.Text = "Сохранить";
            this._btnSave.UseVisualStyleBackColor = false;
            this._btnSave.EnabledChanged += new System.EventHandler(this.OnButtonEnabledChanged);
            this._btnSave.Click += new System.EventHandler(this.OnButtonSaveClick);
            // 
            // _lbl8
            // 
            this._lbl8.AutoSize = true;
            this._lbl8.Location = new System.Drawing.Point(21, 38);
            this._lbl8.Name = "_lbl8";
            this._lbl8.Size = new System.Drawing.Size(64, 20);
            this._lbl8.TabIndex = 15;
            this._lbl8.Text = "Шрифт";
            // 
            // _numFontSize
            // 
            this._numFontSize.Location = new System.Drawing.Point(86, 36);
            this._numFontSize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._numFontSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this._numFontSize.Name = "_numFontSize";
            this._numFontSize.Size = new System.Drawing.Size(78, 26);
            this._numFontSize.TabIndex = 17;
            this._numFontSize.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this._numFontSize.ValueChanged += new System.EventHandler(this.SetFontAxis);
            // 
            // _chbItalics
            // 
            this._chbItalics.AutoSize = true;
            this._chbItalics.Location = new System.Drawing.Point(83, 138);
            this._chbItalics.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._chbItalics.Name = "_chbItalics";
            this._chbItalics.Size = new System.Drawing.Size(80, 24);
            this._chbItalics.TabIndex = 22;
            this._chbItalics.Text = "Курсив";
            this._chbItalics.UseVisualStyleBackColor = true;
            this._chbItalics.CheckedChanged += new System.EventHandler(this.SetFontAxis);
            // 
            // _lbl10
            // 
            this._lbl10.AutoSize = true;
            this._lbl10.Location = new System.Drawing.Point(51, 108);
            this._lbl10.Name = "_lbl10";
            this._lbl10.Size = new System.Drawing.Size(28, 20);
            this._lbl10.TabIndex = 21;
            this._lbl10.Text = "Oy";
            // 
            // _txtNameY
            // 
            this._txtNameY.Location = new System.Drawing.Point(86, 104);
            this._txtNameY.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._txtNameY.Name = "_txtNameY";
            this._txtNameY.Size = new System.Drawing.Size(78, 26);
            this._txtNameY.TabIndex = 20;
            this._txtNameY.TextChanged += new System.EventHandler(this.OnAxisYTextChanged);
            // 
            // _lbl9
            // 
            this._lbl9.AutoSize = true;
            this._lbl9.Location = new System.Drawing.Point(51, 72);
            this._lbl9.Name = "_lbl9";
            this._lbl9.Size = new System.Drawing.Size(28, 20);
            this._lbl9.TabIndex = 19;
            this._lbl9.Text = "Ox";
            // 
            // _txtNameX
            // 
            this._txtNameX.Location = new System.Drawing.Point(86, 70);
            this._txtNameX.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._txtNameX.Name = "_txtNameX";
            this._txtNameX.Size = new System.Drawing.Size(78, 26);
            this._txtNameX.TabIndex = 18;
            this._txtNameX.TextChanged += new System.EventHandler(this.OnAxisXTextChanged);
            // 
            // _btnLineSettings
            // 
            this._btnLineSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnLineSettings.BackColor = System.Drawing.Color.White;
            this._btnLineSettings.ForeColor = System.Drawing.Color.Black;
            this._btnLineSettings.Location = new System.Drawing.Point(787, 719);
            this._btnLineSettings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._btnLineSettings.Name = "_btnLineSettings";
            this._btnLineSettings.Size = new System.Drawing.Size(192, 44);
            this._btnLineSettings.TabIndex = 19;
            this._btnLineSettings.Text = "Настройки линий";
            this._btnLineSettings.UseVisualStyleBackColor = false;
            this._btnLineSettings.EnabledChanged += new System.EventHandler(this.OnButtonEnabledChanged);
            this._btnLineSettings.Click += new System.EventHandler(this.OnButtonLineSettingsClick);
            // 
            // _grbAxis
            // 
            this._grbAxis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._grbAxis.Controls.Add(this._chbItalics);
            this._grbAxis.Controls.Add(this._numFontSize);
            this._grbAxis.Controls.Add(this._lbl10);
            this._grbAxis.Controls.Add(this._lbl8);
            this._grbAxis.Controls.Add(this._txtNameY);
            this._grbAxis.Controls.Add(this._txtNameX);
            this._grbAxis.Controls.Add(this._lbl9);
            this._grbAxis.ForeColor = System.Drawing.Color.White;
            this._grbAxis.Location = new System.Drawing.Point(787, 329);
            this._grbAxis.Name = "_grbAxis";
            this._grbAxis.Size = new System.Drawing.Size(192, 173);
            this._grbAxis.TabIndex = 23;
            this._grbAxis.TabStop = false;
            this._grbAxis.Text = "Подписи";
            // 
            // _grbOY
            // 
            this._grbOY.Controls.Add(this._lbl11);
            this._grbOY.Controls.Add(this._lbl12);
            this._grbOY.Controls.Add(this._lbl13);
            this._grbOY.Controls.Add(this._numYMin);
            this._grbOY.Controls.Add(this._numYMax);
            this._grbOY.Controls.Add(this._numYInterval);
            this._grbOY.ForeColor = System.Drawing.Color.White;
            this._grbOY.Location = new System.Drawing.Point(10, 180);
            this._grbOY.Name = "_grbOY";
            this._grbOY.Size = new System.Drawing.Size(170, 122);
            this._grbOY.TabIndex = 22;
            this._grbOY.TabStop = false;
            this._grbOY.Text = "Ось Oy";
            // 
            // _lbl11
            // 
            this._lbl11.AutoSize = true;
            this._lbl11.Location = new System.Drawing.Point(12, 56);
            this._lbl11.Name = "_lbl11";
            this._lbl11.Size = new System.Drawing.Size(42, 20);
            this._lbl11.TabIndex = 12;
            this._lbl11.Text = "Max:";
            // 
            // _lbl12
            // 
            this._lbl12.AutoSize = true;
            this._lbl12.Location = new System.Drawing.Point(12, 86);
            this._lbl12.Name = "_lbl12";
            this._lbl12.Size = new System.Drawing.Size(42, 20);
            this._lbl12.TabIndex = 5;
            this._lbl12.Text = "Шаг:";
            // 
            // _lbl13
            // 
            this._lbl13.AutoSize = true;
            this._lbl13.Location = new System.Drawing.Point(16, 26);
            this._lbl13.Name = "_lbl13";
            this._lbl13.Size = new System.Drawing.Size(38, 20);
            this._lbl13.TabIndex = 3;
            this._lbl13.Text = "Min:";
            // 
            // _numYMin
            // 
            this._numYMin.Location = new System.Drawing.Point(60, 24);
            this._numYMin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._numYMin.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this._numYMin.Minimum = new decimal(new int[] {
            -1,
            -1,
            -1,
            -2147483648});
            this._numYMin.Name = "_numYMin";
            this._numYMin.Size = new System.Drawing.Size(92, 26);
            this._numYMin.TabIndex = 12;
            this._numYMin.ValueChanged += new System.EventHandler(this.OnYMinChanged);
            // 
            // _numYMax
            // 
            this._numYMax.Location = new System.Drawing.Point(60, 54);
            this._numYMax.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._numYMax.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this._numYMax.Minimum = new decimal(new int[] {
            -1,
            -1,
            -1,
            -2147483648});
            this._numYMax.Name = "_numYMax";
            this._numYMax.Size = new System.Drawing.Size(92, 26);
            this._numYMax.TabIndex = 13;
            this._numYMax.ValueChanged += new System.EventHandler(this.OnYMaxChanged);
            // 
            // _numYInterval
            // 
            this._numYInterval.Location = new System.Drawing.Point(60, 86);
            this._numYInterval.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._numYInterval.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this._numYInterval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this._numYInterval.Name = "_numYInterval";
            this._numYInterval.Size = new System.Drawing.Size(92, 26);
            this._numYInterval.TabIndex = 14;
            this._numYInterval.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this._numYInterval.ValueChanged += new System.EventHandler(this.OnYIntervalChanged);
            // 
            // _grbOX
            // 
            this._grbOX.Controls.Add(this._lbl3);
            this._grbOX.Controls.Add(this._lbl2);
            this._grbOX.Controls.Add(this._numXInterval);
            this._grbOX.Controls.Add(this._lbl1);
            this._grbOX.Controls.Add(this._numXMin);
            this._grbOX.Controls.Add(this._numXMax);
            this._grbOX.ForeColor = System.Drawing.Color.White;
            this._grbOX.Location = new System.Drawing.Point(10, 52);
            this._grbOX.Name = "_grbOX";
            this._grbOX.Size = new System.Drawing.Size(170, 122);
            this._grbOX.TabIndex = 21;
            this._grbOX.TabStop = false;
            this._grbOX.Text = "Ось Ox";
            // 
            // _lbl3
            // 
            this._lbl3.AutoSize = true;
            this._lbl3.Location = new System.Drawing.Point(14, 86);
            this._lbl3.Name = "_lbl3";
            this._lbl3.Size = new System.Drawing.Size(42, 20);
            this._lbl3.TabIndex = 5;
            this._lbl3.Text = "Шаг:";
            // 
            // _lbl2
            // 
            this._lbl2.AutoSize = true;
            this._lbl2.Location = new System.Drawing.Point(14, 56);
            this._lbl2.Name = "_lbl2";
            this._lbl2.Size = new System.Drawing.Size(42, 20);
            this._lbl2.TabIndex = 12;
            this._lbl2.Text = "Max:";
            // 
            // _numXInterval
            // 
            this._numXInterval.Location = new System.Drawing.Point(62, 84);
            this._numXInterval.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._numXInterval.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this._numXInterval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this._numXInterval.Name = "_numXInterval";
            this._numXInterval.Size = new System.Drawing.Size(92, 26);
            this._numXInterval.TabIndex = 11;
            this._numXInterval.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this._numXInterval.ValueChanged += new System.EventHandler(this.OnXIntervalChanged);
            // 
            // _lbl1
            // 
            this._lbl1.AutoSize = true;
            this._lbl1.Location = new System.Drawing.Point(18, 26);
            this._lbl1.Name = "_lbl1";
            this._lbl1.Size = new System.Drawing.Size(38, 20);
            this._lbl1.TabIndex = 3;
            this._lbl1.Text = "Min:";
            // 
            // _numXMin
            // 
            this._numXMin.Location = new System.Drawing.Point(62, 24);
            this._numXMin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._numXMin.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this._numXMin.Minimum = new decimal(new int[] {
            -1,
            -1,
            -1,
            -2147483648});
            this._numXMin.Name = "_numXMin";
            this._numXMin.Size = new System.Drawing.Size(92, 26);
            this._numXMin.TabIndex = 9;
            this._numXMin.ValueChanged += new System.EventHandler(this.OnXMinChanged);
            // 
            // _numXMax
            // 
            this._numXMax.Location = new System.Drawing.Point(62, 54);
            this._numXMax.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._numXMax.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this._numXMax.Minimum = new decimal(new int[] {
            -1,
            -1,
            -1,
            -2147483648});
            this._numXMax.Name = "_numXMax";
            this._numXMax.Size = new System.Drawing.Size(92, 26);
            this._numXMax.TabIndex = 10;
            this._numXMax.ValueChanged += new System.EventHandler(this.OnXMaxChanged);
            // 
            // _numDecimalPlaces
            // 
            this._numDecimalPlaces.Location = new System.Drawing.Point(125, 20);
            this._numDecimalPlaces.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this._numDecimalPlaces.Name = "_numDecimalPlaces";
            this._numDecimalPlaces.Size = new System.Drawing.Size(55, 26);
            this._numDecimalPlaces.TabIndex = 13;
            this._numDecimalPlaces.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this._numDecimalPlaces.ValueChanged += new System.EventHandler(this.OnDecimalPlacesChanged);
            // 
            // _lbl5
            // 
            this._lbl5.AutoSize = true;
            this._lbl5.Location = new System.Drawing.Point(6, 22);
            this._lbl5.Name = "_lbl5";
            this._lbl5.Size = new System.Drawing.Size(113, 20);
            this._lbl5.TabIndex = 14;
            this._lbl5.Text = "Число знаков";
            // 
            // _grbNum
            // 
            this._grbNum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._grbNum.Controls.Add(this._lbl5);
            this._grbNum.Controls.Add(this._numDecimalPlaces);
            this._grbNum.Controls.Add(this._grbOX);
            this._grbNum.Controls.Add(this._grbOY);
            this._grbNum.ForeColor = System.Drawing.Color.White;
            this._grbNum.Location = new System.Drawing.Point(787, 12);
            this._grbNum.Name = "_grbNum";
            this._grbNum.Size = new System.Drawing.Size(192, 311);
            this._grbNum.TabIndex = 24;
            this._grbNum.TabStop = false;
            this._grbNum.Text = "Настройки осей";
            // 
            // _btnOpen
            // 
            this._btnOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnOpen.BackColor = System.Drawing.Color.White;
            this._btnOpen.ForeColor = System.Drawing.Color.Black;
            this._btnOpen.Location = new System.Drawing.Point(787, 767);
            this._btnOpen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._btnOpen.Name = "_btnOpen";
            this._btnOpen.Size = new System.Drawing.Size(192, 44);
            this._btnOpen.TabIndex = 25;
            this._btnOpen.Text = "Открыть";
            this._btnOpen.UseVisualStyleBackColor = false;
            this._btnOpen.EnabledChanged += new System.EventHandler(this.OnButtonEnabledChanged);
            this._btnOpen.Click += new System.EventHandler(this.OnButtonOpenClick);
            // 
            // _chart
            // 
            this._chart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.AxisX.Crossing = 0D;
            chartArea1.AxisX.Interval = 2.5D;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.Maximum = 7.5D;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisX.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            chartArea1.AxisX.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea1.AxisY.Interval = 0.2D;
            chartArea1.AxisY.MajorGrid.Enabled = false;
            chartArea1.AxisY.Maximum = 1D;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.AxisY.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            chartArea1.AxisY.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea1.Name = "ChartArea1";
            this._chart.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this._chart.Legends.Add(legend1);
            this._chart.Location = new System.Drawing.Point(14, 14);
            this._chart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._chart.Name = "_chart";
            this._chart.Size = new System.Drawing.Size(767, 701);
            this._chart.TabIndex = 0;
            this._chart.Text = "chart";
            this._chart.SizeChanged += new System.EventHandler(this.OnChartSizeChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(990, 870);
            this.Controls.Add(this._btnOpen);
            this.Controls.Add(this._grbNum);
            this.Controls.Add(this._btnLineSettings);
            this.Controls.Add(this._btnSave);
            this.Controls.Add(this._grbAxis);
            this.Controls.Add(this._chart);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Графики";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.OnFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this._numFontSize)).EndInit();
            this._grbAxis.ResumeLayout(false);
            this._grbAxis.PerformLayout();
            this._grbOY.ResumeLayout(false);
            this._grbOY.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._numYMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._numYMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._numYInterval)).EndInit();
            this._grbOX.ResumeLayout(false);
            this._grbOX.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._numXInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._numXMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._numXMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._numDecimalPlaces)).EndInit();
            this._grbNum.ResumeLayout(false);
            this._grbNum.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._chart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button _btnLineSettings;
        private System.Windows.Forms.Button _btnOpen;
        private System.Windows.Forms.Button _btnSave;
        private System.Windows.Forms.CheckBox _chbItalics;
        private System.Windows.Forms.GroupBox _grbAxis;
        private System.Windows.Forms.GroupBox _grbNum;
        private System.Windows.Forms.GroupBox _grbOX;
        private System.Windows.Forms.GroupBox _grbOY;
        private System.Windows.Forms.Label _lbl1;
        private System.Windows.Forms.Label _lbl2;
        private System.Windows.Forms.Label _lbl3;
        private System.Windows.Forms.Label _lbl5;
        private System.Windows.Forms.Label _lbl8;
        private System.Windows.Forms.Label _lbl9;
        private System.Windows.Forms.Label _lbl10;
        private System.Windows.Forms.Label _lbl11;
        private System.Windows.Forms.Label _lbl12;
        private System.Windows.Forms.Label _lbl13;
        private System.Windows.Forms.NumericUpDown _numDecimalPlaces;
        private System.Windows.Forms.NumericUpDown _numFontSize;
        private System.Windows.Forms.NumericUpDown _numXMin;
        private System.Windows.Forms.NumericUpDown _numYMin;
        private System.Windows.Forms.NumericUpDown _numXMax;
        private System.Windows.Forms.NumericUpDown _numYMax;
        private System.Windows.Forms.NumericUpDown _numXInterval;
        private System.Windows.Forms.NumericUpDown _numYInterval;
        private System.Windows.Forms.TextBox _txtNameX;
        private System.Windows.Forms.TextBox _txtNameY;
        private System.Windows.Forms.DataVisualization.Charting.Chart _chart;
    }
}
