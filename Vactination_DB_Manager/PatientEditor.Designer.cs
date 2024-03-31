namespace Vactination_DB_Manager
{
    partial class PatientEditor
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
            this.immunizationDate = new System.Windows.Forms.DateTimePicker();
            this.updateAtLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.NotGiven = new System.Windows.Forms.ComboBox();
            this.Status = new System.Windows.Forms.ComboBox();
            this.Gender = new System.Windows.Forms.ComboBox();
            this.GenderText = new System.Windows.Forms.Label();
            this.NotGivenText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ageGroup = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.VactineCode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.divisionIdefluerValue = new System.Windows.Forms.TextBox();
            this.legalEntityId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.IdTempImmunization = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // immunizationDate
            // 
            this.immunizationDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.immunizationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.immunizationDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.immunizationDate.Location = new System.Drawing.Point(119, 195);
            this.immunizationDate.Name = "immunizationDate";
            this.immunizationDate.Size = new System.Drawing.Size(86, 22);
            this.immunizationDate.TabIndex = 0;
            // 
            // updateAtLabel
            // 
            this.updateAtLabel.AutoSize = true;
            this.updateAtLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.updateAtLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.updateAtLabel.Location = new System.Drawing.Point(485, 295);
            this.updateAtLabel.Name = "updateAtLabel";
            this.updateAtLabel.Size = new System.Drawing.Size(193, 16);
            this.updateAtLabel.TabIndex = 1;
            this.updateAtLabel.Text = "Запис оновлено в: 31.03.2024";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(695, 288);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Зберегти";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // NotGiven
            // 
            this.NotGiven.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NotGiven.FormattingEnabled = true;
            this.NotGiven.Items.AddRange(new object[] {
            "+",
            "-",
            "Null"});
            this.NotGiven.Location = new System.Drawing.Point(284, 102);
            this.NotGiven.Name = "NotGiven";
            this.NotGiven.Size = new System.Drawing.Size(62, 24);
            this.NotGiven.TabIndex = 3;
            this.NotGiven.Text = "Null";
            // 
            // Status
            // 
            this.Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Status.FormattingEnabled = true;
            this.Status.Items.AddRange(new object[] {
            "+",
            "-",
            "Null"});
            this.Status.Location = new System.Drawing.Point(98, 102);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(92, 24);
            this.Status.TabIndex = 4;
            this.Status.Text = "Null";
            // 
            // Gender
            // 
            this.Gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Gender.FormattingEnabled = true;
            this.Gender.Items.AddRange(new object[] {
            "Жіноча",
            "Чоловіча",
            "Уточнюється",
            "Null"});
            this.Gender.Location = new System.Drawing.Point(250, 136);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(96, 24);
            this.Gender.TabIndex = 5;
            this.Gender.Text = "Null";
            // 
            // GenderText
            // 
            this.GenderText.AutoSize = true;
            this.GenderText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GenderText.Location = new System.Drawing.Point(196, 138);
            this.GenderText.Name = "GenderText";
            this.GenderText.Size = new System.Drawing.Size(48, 16);
            this.GenderText.TabIndex = 6;
            this.GenderText.Text = "Стать:";
            // 
            // NotGivenText
            // 
            this.NotGivenText.AutoSize = true;
            this.NotGivenText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NotGivenText.Location = new System.Drawing.Point(196, 105);
            this.NotGivenText.Name = "NotGivenText";
            this.NotGivenText.Size = new System.Drawing.Size(79, 16);
            this.NotGivenText.TabIndex = 7;
            this.NotGivenText.Text = "Не надано:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(7, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Статус:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(7, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Дата імунізації:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ageGroup);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.VactineCode);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.divisionIdefluerValue);
            this.groupBox1.Controls.Add(this.legalEntityId);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.IdTempImmunization);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.NotGivenText);
            this.groupBox1.Controls.Add(this.GenderText);
            this.groupBox1.Controls.Add(this.Gender);
            this.groupBox1.Controls.Add(this.Status);
            this.groupBox1.Controls.Add(this.NotGiven);
            this.groupBox1.Controls.Add(this.immunizationDate);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(774, 259);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Нові дані";
            // 
            // ageGroup
            // 
            this.ageGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ageGroup.FormattingEnabled = true;
            this.ageGroup.Items.AddRange(new object[] {
            "Уточнюється",
            "\"0-4\"",
            "\"5-10\"",
            "\"11-15\"",
            "\"16-20\"",
            "\"21-25\"",
            "\"26-30\"",
            "\"31-35\"",
            "\"36-40\"",
            "\"41-45\"",
            "\"46-50\"",
            "\"51-55\"",
            "\"56-60\"",
            "\"61-65\"",
            "\"66-70\"",
            "\"71-75\"",
            "\"76-80\"",
            "\"81-85\"",
            "\"86-90\"",
            "\"91-95\"",
            "\"96+\"",
            "Null"});
            this.ageGroup.Location = new System.Drawing.Point(98, 135);
            this.ageGroup.Name = "ageGroup";
            this.ageGroup.Size = new System.Drawing.Size(92, 24);
            this.ageGroup.TabIndex = 11;
            this.ageGroup.Text = "Null";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(7, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Вікова група:";
            // 
            // VactineCode
            // 
            this.VactineCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VactineCode.Location = new System.Drawing.Point(98, 165);
            this.VactineCode.Name = "VactineCode";
            this.VactineCode.Size = new System.Drawing.Size(248, 22);
            this.VactineCode.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(6, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Код вакцини:";
            // 
            // divisionIdefluerValue
            // 
            this.divisionIdefluerValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.divisionIdefluerValue.Location = new System.Drawing.Point(98, 74);
            this.divisionIdefluerValue.Name = "divisionIdefluerValue";
            this.divisionIdefluerValue.Size = new System.Drawing.Size(248, 22);
            this.divisionIdefluerValue.TabIndex = 15;
            // 
            // legalEntityId
            // 
            this.legalEntityId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.legalEntityId.Location = new System.Drawing.Point(98, 46);
            this.legalEntityId.Name = "legalEntityId";
            this.legalEntityId.Size = new System.Drawing.Size(248, 22);
            this.legalEntityId.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(7, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "ID Закладу:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(6, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "ID юр особи:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(6, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "ID імунізації:";
            // 
            // IdTempImmunization
            // 
            this.IdTempImmunization.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IdTempImmunization.Location = new System.Drawing.Point(98, 18);
            this.IdTempImmunization.Name = "IdTempImmunization";
            this.IdTempImmunization.Size = new System.Drawing.Size(248, 22);
            this.IdTempImmunization.TabIndex = 10;
            // 
            // PatientEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 336);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.updateAtLabel);
            this.Name = "PatientEditor";
            this.Text = "PatientEditor";
            this.Load += new System.EventHandler(this.PatientEditor_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker immunizationDate;
        private System.Windows.Forms.Label updateAtLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox NotGiven;
        private System.Windows.Forms.ComboBox Status;
        private System.Windows.Forms.ComboBox Gender;
        private System.Windows.Forms.Label GenderText;
        private System.Windows.Forms.Label NotGivenText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox IdTempImmunization;
        private System.Windows.Forms.TextBox divisionIdefluerValue;
        private System.Windows.Forms.TextBox legalEntityId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox VactineCode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox ageGroup;
        private System.Windows.Forms.Label label7;
    }
}