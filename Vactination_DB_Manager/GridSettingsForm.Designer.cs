namespace Vactination_DB_Manager
{
    partial class GridSettingsForm
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
            this.qOfPatientsOnPage = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SaveSettings = new System.Windows.Forms.Button();
            this.UnPairColor = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PairColor = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.FontSize = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.FontFamily = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.qOfPatientsOnPage)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // qOfPatientsOnPage
            // 
            this.qOfPatientsOnPage.Location = new System.Drawing.Point(170, 13);
            this.qOfPatientsOnPage.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.qOfPatientsOnPage.Name = "qOfPatientsOnPage";
            this.qOfPatientsOnPage.Size = new System.Drawing.Size(52, 20);
            this.qOfPatientsOnPage.TabIndex = 0;
            this.qOfPatientsOnPage.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Кількість записів на сторінці";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 19);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(71, 17);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "NotGiven";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 117);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(450, 119);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Відображення стовбчиків";
            // 
            // SaveSettings
            // 
            this.SaveSettings.Location = new System.Drawing.Point(372, 245);
            this.SaveSettings.Name = "SaveSettings";
            this.SaveSettings.Size = new System.Drawing.Size(90, 23);
            this.SaveSettings.TabIndex = 4;
            this.SaveSettings.Text = "Застосувати";
            this.SaveSettings.UseVisualStyleBackColor = true;
            this.SaveSettings.Click += new System.EventHandler(this.SaveSettings_Click);
            // 
            // UnPairColor
            // 
            this.UnPairColor.Location = new System.Drawing.Point(170, 39);
            this.UnPairColor.Name = "UnPairColor";
            this.UnPairColor.Size = new System.Drawing.Size(52, 23);
            this.UnPairColor.TabIndex = 6;
            this.UnPairColor.UseVisualStyleBackColor = true;
            this.UnPairColor.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Колір непарних рядків";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Колір парних рядків";
            // 
            // PairColor
            // 
            this.PairColor.Location = new System.Drawing.Point(170, 71);
            this.PairColor.Name = "PairColor";
            this.PairColor.Size = new System.Drawing.Size(52, 23);
            this.PairColor.TabIndex = 9;
            this.PairColor.UseVisualStyleBackColor = true;
            this.PairColor.Click += new System.EventHandler(this.PairColor_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(244, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Розмір шрифту";
            // 
            // FontSize
            // 
            this.FontSize.FormattingEnabled = true;
            this.FontSize.Items.AddRange(new object[] {
            "4",
            "6",
            "8",
            "10",
            "12",
            "14",
            "16",
            "18",
            "20",
            "24"});
            this.FontSize.Location = new System.Drawing.Point(334, 15);
            this.FontSize.Name = "FontSize";
            this.FontSize.Size = new System.Drawing.Size(128, 21);
            this.FontSize.TabIndex = 11;
            this.FontSize.Text = "8";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(244, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Стиль шрифту";
            // 
            // FontFamily
            // 
            this.FontFamily.FormattingEnabled = true;
            this.FontFamily.Items.AddRange(new object[] {
            "Arial",
            "Times New Roman",
            "Microsoft Sans Serif"});
            this.FontFamily.Location = new System.Drawing.Point(334, 43);
            this.FontFamily.Name = "FontFamily";
            this.FontFamily.Size = new System.Drawing.Size(128, 21);
            this.FontFamily.TabIndex = 13;
            this.FontFamily.Text = "Arial";
            // 
            // GridSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 280);
            this.Controls.Add(this.FontFamily);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.FontSize);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PairColor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UnPairColor);
            this.Controls.Add(this.SaveSettings);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.qOfPatientsOnPage);
            this.Controls.Add(this.groupBox1);
            this.Name = "GridSettingsForm";
            this.Text = "GridSettingsForm";
            this.Load += new System.EventHandler(this.GridSettingsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qOfPatientsOnPage)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown qOfPatientsOnPage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button SaveSettings;
        private System.Windows.Forms.Button UnPairColor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button PairColor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox FontSize;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox FontFamily;
    }
}