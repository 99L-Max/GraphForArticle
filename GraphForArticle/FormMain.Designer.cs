
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
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDownXMin = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownXMax = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDX = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownYMin = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownYMax = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDY = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDownFontSize = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxItalics = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxNameY = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxNameX = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxSize = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownXMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownXMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFontSize)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart
            // 
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
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(12, 11);
            this.chart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chart.Name = "chart";
            this.chart.Size = new System.Drawing.Size(900, 506);
            this.chart.TabIndex = 0;
            this.chart.Text = "chart";
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(918, 442);
            this.buttonOpen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(205, 35);
            this.buttonOpen.TabIndex = 1;
            this.buttonOpen.Text = "Открыть";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(918, 481);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(205, 35);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "x_min";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "x_max";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "dx";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "dy";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "y_max";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "y_min";
            // 
            // numericUpDownXMin
            // 
            this.numericUpDownXMin.DecimalPlaces = 3;
            this.numericUpDownXMin.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numericUpDownXMin.Location = new System.Drawing.Point(80, 17);
            this.numericUpDownXMin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownXMin.Name = "numericUpDownXMin";
            this.numericUpDownXMin.Size = new System.Drawing.Size(69, 23);
            this.numericUpDownXMin.TabIndex = 9;
            this.numericUpDownXMin.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // numericUpDownXMax
            // 
            this.numericUpDownXMax.DecimalPlaces = 3;
            this.numericUpDownXMax.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numericUpDownXMax.Location = new System.Drawing.Point(80, 46);
            this.numericUpDownXMax.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownXMax.Name = "numericUpDownXMax";
            this.numericUpDownXMax.Size = new System.Drawing.Size(69, 23);
            this.numericUpDownXMax.TabIndex = 10;
            this.numericUpDownXMax.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDownXMax.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // numericUpDownDX
            // 
            this.numericUpDownDX.DecimalPlaces = 3;
            this.numericUpDownDX.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numericUpDownDX.Location = new System.Drawing.Point(80, 75);
            this.numericUpDownDX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownDX.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numericUpDownDX.Name = "numericUpDownDX";
            this.numericUpDownDX.Size = new System.Drawing.Size(69, 23);
            this.numericUpDownDX.TabIndex = 11;
            this.numericUpDownDX.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numericUpDownDX.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // numericUpDownYMin
            // 
            this.numericUpDownYMin.DecimalPlaces = 3;
            this.numericUpDownYMin.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numericUpDownYMin.Location = new System.Drawing.Point(80, 104);
            this.numericUpDownYMin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownYMin.Name = "numericUpDownYMin";
            this.numericUpDownYMin.Size = new System.Drawing.Size(69, 23);
            this.numericUpDownYMin.TabIndex = 12;
            this.numericUpDownYMin.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // numericUpDownYMax
            // 
            this.numericUpDownYMax.DecimalPlaces = 3;
            this.numericUpDownYMax.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numericUpDownYMax.Location = new System.Drawing.Point(80, 133);
            this.numericUpDownYMax.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownYMax.Name = "numericUpDownYMax";
            this.numericUpDownYMax.Size = new System.Drawing.Size(69, 23);
            this.numericUpDownYMax.TabIndex = 13;
            this.numericUpDownYMax.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDownYMax.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // numericUpDownDY
            // 
            this.numericUpDownDY.DecimalPlaces = 3;
            this.numericUpDownDY.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numericUpDownDY.Location = new System.Drawing.Point(80, 163);
            this.numericUpDownDY.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownDY.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numericUpDownDY.Name = "numericUpDownDY";
            this.numericUpDownDY.Size = new System.Drawing.Size(69, 23);
            this.numericUpDownDY.TabIndex = 14;
            this.numericUpDownDY.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numericUpDownDY.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 193);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Шрифт";
            // 
            // numericUpDownFontSize
            // 
            this.numericUpDownFontSize.Location = new System.Drawing.Point(80, 191);
            this.numericUpDownFontSize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownFontSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownFontSize.Name = "numericUpDownFontSize";
            this.numericUpDownFontSize.Size = new System.Drawing.Size(69, 23);
            this.numericUpDownFontSize.TabIndex = 17;
            this.numericUpDownFontSize.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDownFontSize.ValueChanged += new System.EventHandler(this.SetFontAxis);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxItalics);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.textBoxNameY);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textBoxNameX);
            this.groupBox1.Controls.Add(this.numericUpDownXMin);
            this.groupBox1.Controls.Add(this.numericUpDownFontSize);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numericUpDownDY);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.numericUpDownYMax);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.numericUpDownYMin);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.numericUpDownDX);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.numericUpDownXMax);
            this.groupBox1.Location = new System.Drawing.Point(955, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(168, 305);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Оси";
            // 
            // checkBoxItalics
            // 
            this.checkBoxItalics.AutoSize = true;
            this.checkBoxItalics.Location = new System.Drawing.Point(6, 277);
            this.checkBoxItalics.Name = "checkBoxItalics";
            this.checkBoxItalics.Size = new System.Drawing.Size(146, 21);
            this.checkBoxItalics.TabIndex = 22;
            this.checkBoxItalics.Text = "Имя оси курсивом";
            this.checkBoxItalics.UseVisualStyleBackColor = true;
            this.checkBoxItalics.CheckedChanged += new System.EventHandler(this.SetFontAxis);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(49, 251);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 17);
            this.label10.TabIndex = 21;
            this.label10.Text = "Oy";
            // 
            // textBoxNameY
            // 
            this.textBoxNameY.Location = new System.Drawing.Point(80, 248);
            this.textBoxNameY.Name = "textBoxNameY";
            this.textBoxNameY.Size = new System.Drawing.Size(69, 23);
            this.textBoxNameY.TabIndex = 20;
            this.textBoxNameY.Text = "Y";
            this.textBoxNameY.Leave += new System.EventHandler(this.SetFontAxis);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(49, 222);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "Ox";
            // 
            // textBoxNameX
            // 
            this.textBoxNameX.Location = new System.Drawing.Point(80, 219);
            this.textBoxNameX.Name = "textBoxNameX";
            this.textBoxNameX.Size = new System.Drawing.Size(69, 23);
            this.textBoxNameX.TabIndex = 18;
            this.textBoxNameX.Text = "X";
            this.textBoxNameX.Leave += new System.EventHandler(this.SetFontAxis);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(918, 403);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(205, 35);
            this.button1.TabIndex = 19;
            this.button1.Text = "Настройки линий";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxSize
            // 
            this.comboBoxSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSize.FormattingEnabled = true;
            this.comboBoxSize.Items.AddRange(new object[] {
            "16:9",
            "16:10",
            "5:4",
            "4:3",
            "3:2"});
            this.comboBoxSize.Location = new System.Drawing.Point(1021, 354);
            this.comboBoxSize.Name = "comboBoxSize";
            this.comboBoxSize.Size = new System.Drawing.Size(102, 24);
            this.comboBoxSize.TabIndex = 20;
            this.comboBoxSize.SelectedIndexChanged += new System.EventHandler(this.comboBoxSize_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(958, 357);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "Размер";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 541);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBoxSize);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.chart);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Графики";
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownXMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownXMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFontSize)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDownXMin;
        private System.Windows.Forms.NumericUpDown numericUpDownXMax;
        private System.Windows.Forms.NumericUpDown numericUpDownDX;
        private System.Windows.Forms.NumericUpDown numericUpDownYMin;
        private System.Windows.Forms.NumericUpDown numericUpDownYMax;
        private System.Windows.Forms.NumericUpDown numericUpDownDY;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericUpDownFontSize;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxSize;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBoxItalics;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxNameY;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxNameX;
    }
}
