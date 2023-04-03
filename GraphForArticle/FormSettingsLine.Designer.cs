
namespace GraphForArticle
{
    partial class FormSettingsLine
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkBoxApplyToAll = new System.Windows.Forms.CheckBox();
            this.numericUpDownNumberLine = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxTypeLine = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBoxCurrentColor = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownBorderWidth = new System.Windows.Forms.NumericUpDown();
            this.groupBoxColors = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumberLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCurrentColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBorderWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBoxApplyToAll
            // 
            this.checkBoxApplyToAll.AutoSize = true;
            this.checkBoxApplyToAll.Location = new System.Drawing.Point(12, 108);
            this.checkBoxApplyToAll.Name = "checkBoxApplyToAll";
            this.checkBoxApplyToAll.Size = new System.Drawing.Size(176, 24);
            this.checkBoxApplyToAll.TabIndex = 2;
            this.checkBoxApplyToAll.Text = "Применить ко всем";
            this.checkBoxApplyToAll.UseVisualStyleBackColor = true;
            this.checkBoxApplyToAll.CheckedChanged += new System.EventHandler(this.checkBoxApplyToAll_CheckedChanged);
            // 
            // numericUpDownNumberLine
            // 
            this.numericUpDownNumberLine.Location = new System.Drawing.Point(151, 7);
            this.numericUpDownNumberLine.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownNumberLine.Name = "numericUpDownNumberLine";
            this.numericUpDownNumberLine.Size = new System.Drawing.Size(118, 26);
            this.numericUpDownNumberLine.TabIndex = 3;
            this.numericUpDownNumberLine.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownNumberLine.ValueChanged += new System.EventHandler(this.numericUpDownNumberLine_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Номер графика:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Тип линии:";
            // 
            // comboBoxTypeLine
            // 
            this.comboBoxTypeLine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTypeLine.FormattingEnabled = true;
            this.comboBoxTypeLine.Items.AddRange(new object[] {
            "Сплошная",
            "Пунктир"});
            this.comboBoxTypeLine.Location = new System.Drawing.Point(151, 40);
            this.comboBoxTypeLine.Name = "comboBoxTypeLine";
            this.comboBoxTypeLine.Size = new System.Drawing.Size(118, 28);
            this.comboBoxTypeLine.TabIndex = 6;
            this.comboBoxTypeLine.SelectedIndexChanged += new System.EventHandler(this.comboBoxTypeLine_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Текущий цвет:";
            // 
            // pictureBoxCurrentColor
            // 
            this.pictureBoxCurrentColor.Location = new System.Drawing.Point(151, 137);
            this.pictureBoxCurrentColor.Name = "pictureBoxCurrentColor";
            this.pictureBoxCurrentColor.Size = new System.Drawing.Size(118, 33);
            this.pictureBoxCurrentColor.TabIndex = 8;
            this.pictureBoxCurrentColor.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Толщина:";
            // 
            // numericUpDownBorderWidth
            // 
            this.numericUpDownBorderWidth.Location = new System.Drawing.Point(151, 76);
            this.numericUpDownBorderWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownBorderWidth.Name = "numericUpDownBorderWidth";
            this.numericUpDownBorderWidth.Size = new System.Drawing.Size(118, 26);
            this.numericUpDownBorderWidth.TabIndex = 11;
            this.numericUpDownBorderWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownBorderWidth.ValueChanged += new System.EventHandler(this.numericUpDownBorderWidth_ValueChanged);
            // 
            // groupBoxColors
            // 
            this.groupBoxColors.Location = new System.Drawing.Point(12, 176);
            this.groupBoxColors.Name = "groupBoxColors";
            this.groupBoxColors.Size = new System.Drawing.Size(257, 107);
            this.groupBoxColors.TabIndex = 12;
            this.groupBoxColors.TabStop = false;
            this.groupBoxColors.Text = "Изменить цвет";
            // 
            // FormSettingsLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 294);
            this.Controls.Add(this.groupBoxColors);
            this.Controls.Add(this.numericUpDownBorderWidth);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBoxCurrentColor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxTypeLine);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownNumberLine);
            this.Controls.Add(this.checkBoxApplyToAll);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormSettingsLine";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Настройки линии";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumberLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCurrentColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBorderWidth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox checkBoxApplyToAll;
        private System.Windows.Forms.NumericUpDown numericUpDownNumberLine;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxTypeLine;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBoxCurrentColor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownBorderWidth;
        private System.Windows.Forms.GroupBox groupBoxColors;
    }
}