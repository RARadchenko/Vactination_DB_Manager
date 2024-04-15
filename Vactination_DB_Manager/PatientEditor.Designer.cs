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
            this.SaveChanges = new System.Windows.Forms.Button();
            this.NotGiven = new System.Windows.Forms.ComboBox();
            this.Status = new System.Windows.Forms.ComboBox();
            this.Gender = new System.Windows.Forms.ComboBox();
            this.GenderText = new System.Windows.Forms.Label();
            this.NotGivenText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.doseQuantityValue = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.insertedAtLabel = new System.Windows.Forms.Label();
            this.doseQuantityUnit = new System.Windows.Forms.ComboBox();
            this.expirationDateText = new System.Windows.Forms.Label();
            this.expirationDate = new System.Windows.Forms.DateTimePicker();
            this.LotNumber = new System.Windows.Forms.TextBox();
            this.LotNumberText = new System.Windows.Forms.Label();
            this.manufacturer = new System.Windows.Forms.TextBox();
            this.manufacturerText = new System.Windows.Forms.Label();
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.targetDiseases = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.seriesDoses = new System.Windows.Forms.NumericUpDown();
            this.Series = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.DoseSequence = new System.Windows.Forms.NumericUpDown();
            this.Delete = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doseQuantityValue)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seriesDoses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DoseSequence)).BeginInit();
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
            this.updateAtLabel.Location = new System.Drawing.Point(551, 229);
            this.updateAtLabel.Name = "updateAtLabel";
            this.updateAtLabel.Size = new System.Drawing.Size(193, 16);
            this.updateAtLabel.TabIndex = 1;
            this.updateAtLabel.Text = "Запис оновлено в: 31.03.2024";
            // 
            // SaveChanges
            // 
            this.SaveChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveChanges.Location = new System.Drawing.Point(698, 287);
            this.SaveChanges.Name = "SaveChanges";
            this.SaveChanges.Size = new System.Drawing.Size(75, 23);
            this.SaveChanges.TabIndex = 2;
            this.SaveChanges.Text = "Зберегти";
            this.SaveChanges.UseVisualStyleBackColor = true;
            this.SaveChanges.Click += new System.EventHandler(this.SaveChanges_Click);
            // 
            // NotGiven
            // 
            this.NotGiven.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NotGiven.FormattingEnabled = true;
            this.NotGiven.Items.AddRange(new object[] {
            "+",
            "-"});
            this.NotGiven.Location = new System.Drawing.Point(284, 102);
            this.NotGiven.Name = "NotGiven";
            this.NotGiven.Size = new System.Drawing.Size(62, 24);
            this.NotGiven.TabIndex = 3;
            this.NotGiven.Text = "-";
            // 
            // Status
            // 
            this.Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Status.FormattingEnabled = true;
            this.Status.Items.AddRange(new object[] {
            "+",
            "-"});
            this.Status.Location = new System.Drawing.Point(98, 102);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(92, 24);
            this.Status.TabIndex = 4;
            this.Status.Text = "-";
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
            this.groupBox1.Controls.Add(this.doseQuantityValue);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.updateAtLabel);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.insertedAtLabel);
            this.groupBox1.Controls.Add(this.doseQuantityUnit);
            this.groupBox1.Controls.Add(this.expirationDateText);
            this.groupBox1.Controls.Add(this.expirationDate);
            this.groupBox1.Controls.Add(this.LotNumber);
            this.groupBox1.Controls.Add(this.LotNumberText);
            this.groupBox1.Controls.Add(this.manufacturer);
            this.groupBox1.Controls.Add(this.manufacturerText);
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
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(774, 258);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Нові дані";
            // 
            // doseQuantityValue
            // 
            this.doseQuantityValue.DecimalPlaces = 3;
            this.doseQuantityValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.doseQuantityValue.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.doseQuantityValue.Location = new System.Drawing.Point(673, 74);
            this.doseQuantityValue.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.doseQuantityValue.Name = "doseQuantityValue";
            this.doseQuantityValue.Size = new System.Drawing.Size(56, 22);
            this.doseQuantityValue.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(625, 77);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 16);
            this.label10.TabIndex = 27;
            this.label10.Text = "доза:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(372, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 16);
            this.label8.TabIndex = 25;
            this.label8.Text = "одиниці виміру:";
            // 
            // insertedAtLabel
            // 
            this.insertedAtLabel.AutoSize = true;
            this.insertedAtLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.insertedAtLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.insertedAtLabel.Location = new System.Drawing.Point(362, 229);
            this.insertedAtLabel.Name = "insertedAtLabel";
            this.insertedAtLabel.Size = new System.Drawing.Size(187, 16);
            this.insertedAtLabel.TabIndex = 11;
            this.insertedAtLabel.Text = "Запис внесено в:  31.03.2024";
            // 
            // doseQuantityUnit
            // 
            this.doseQuantityUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.doseQuantityUnit.FormattingEnabled = true;
            this.doseQuantityUnit.Items.AddRange(new object[] {
            "\"ML\"",
            "\"MG\"",
            "Null"});
            this.doseQuantityUnit.Location = new System.Drawing.Point(481, 74);
            this.doseQuantityUnit.Name = "doseQuantityUnit";
            this.doseQuantityUnit.Size = new System.Drawing.Size(90, 24);
            this.doseQuantityUnit.TabIndex = 24;
            this.doseQuantityUnit.Text = "\"ML\"";
            // 
            // expirationDateText
            // 
            this.expirationDateText.AutoSize = true;
            this.expirationDateText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.expirationDateText.Location = new System.Drawing.Point(372, 105);
            this.expirationDateText.Name = "expirationDateText";
            this.expirationDateText.Size = new System.Drawing.Size(94, 16);
            this.expirationDateText.TabIndex = 23;
            this.expirationDateText.Text = "Придатна до:";
            // 
            // expirationDate
            // 
            this.expirationDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.expirationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.expirationDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.expirationDate.Location = new System.Drawing.Point(481, 102);
            this.expirationDate.Name = "expirationDate";
            this.expirationDate.Size = new System.Drawing.Size(90, 22);
            this.expirationDate.TabIndex = 22;
            // 
            // LotNumber
            // 
            this.LotNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LotNumber.Location = new System.Drawing.Point(481, 43);
            this.LotNumber.Name = "LotNumber";
            this.LotNumber.Size = new System.Drawing.Size(248, 22);
            this.LotNumber.TabIndex = 21;
            // 
            // LotNumberText
            // 
            this.LotNumberText.AutoSize = true;
            this.LotNumberText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LotNumberText.Location = new System.Drawing.Point(372, 49);
            this.LotNumberText.Name = "LotNumberText";
            this.LotNumberText.Size = new System.Drawing.Size(93, 16);
            this.LotNumberText.TabIndex = 20;
            this.LotNumberText.Text = "Номер партії:";
            // 
            // manufacturer
            // 
            this.manufacturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.manufacturer.Location = new System.Drawing.Point(481, 15);
            this.manufacturer.Name = "manufacturer";
            this.manufacturer.Size = new System.Drawing.Size(248, 22);
            this.manufacturer.TabIndex = 19;
            // 
            // manufacturerText
            // 
            this.manufacturerText.AutoSize = true;
            this.manufacturerText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.manufacturerText.Location = new System.Drawing.Point(372, 21);
            this.manufacturerText.Name = "manufacturerText";
            this.manufacturerText.Size = new System.Drawing.Size(74, 16);
            this.manufacturerText.TabIndex = 18;
            this.manufacturerText.Text = "Виробник:";
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.targetDiseases);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.seriesDoses);
            this.groupBox2.Controls.Add(this.Series);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.DoseSequence);
            this.groupBox2.Location = new System.Drawing.Point(365, 125);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(379, 101);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Протокол";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(2, 73);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(113, 16);
            this.label12.TabIndex = 30;
            this.label12.Text = "Цільові хвороби:";
            // 
            // targetDiseases
            // 
            this.targetDiseases.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.targetDiseases.Location = new System.Drawing.Point(116, 70);
            this.targetDiseases.Name = "targetDiseases";
            this.targetDiseases.Size = new System.Drawing.Size(248, 22);
            this.targetDiseases.TabIndex = 22;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(227, 16);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 16);
            this.label14.TabIndex = 32;
            this.label14.Text = "Дози серії:";
            // 
            // seriesDoses
            // 
            this.seriesDoses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.seriesDoses.Location = new System.Drawing.Point(308, 14);
            this.seriesDoses.Name = "seriesDoses";
            this.seriesDoses.Size = new System.Drawing.Size(56, 22);
            this.seriesDoses.TabIndex = 33;
            this.seriesDoses.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Series
            // 
            this.Series.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Series.Location = new System.Drawing.Point(116, 40);
            this.Series.Name = "Series";
            this.Series.Size = new System.Drawing.Size(248, 22);
            this.Series.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(2, 40);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 16);
            this.label13.TabIndex = 31;
            this.label13.Text = "Серія:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(2, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 16);
            this.label11.TabIndex = 29;
            this.label11.Text = "Послідовність:";
            // 
            // DoseSequence
            // 
            this.DoseSequence.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DoseSequence.Location = new System.Drawing.Point(116, 13);
            this.DoseSequence.Name = "DoseSequence";
            this.DoseSequence.Size = new System.Drawing.Size(56, 22);
            this.DoseSequence.TabIndex = 29;
            this.DoseSequence.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Delete
            // 
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Delete.Location = new System.Drawing.Point(22, 287);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(110, 23);
            this.Delete.TabIndex = 11;
            this.Delete.Text = "Видалити запис";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // PatientEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 336);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SaveChanges);
            this.Name = "PatientEditor";
            this.Text = "PatientEditor";
            this.Load += new System.EventHandler(this.PatientEditor_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doseQuantityValue)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seriesDoses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DoseSequence)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker immunizationDate;
        private System.Windows.Forms.Label updateAtLabel;
        private System.Windows.Forms.Button SaveChanges;
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
        private System.Windows.Forms.TextBox manufacturer;
        private System.Windows.Forms.Label manufacturerText;
        private System.Windows.Forms.TextBox LotNumber;
        private System.Windows.Forms.Label LotNumberText;
        private System.Windows.Forms.Label expirationDateText;
        private System.Windows.Forms.DateTimePicker expirationDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox doseQuantityUnit;
        private System.Windows.Forms.Label insertedAtLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown doseQuantityValue;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox targetDiseases;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown DoseSequence;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox Series;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown seriesDoses;
        private System.Windows.Forms.Button Delete;
    }
}