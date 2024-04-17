namespace Vactination_DB_Manager
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.CurrentDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.PagesInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.CurrentFileLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusTimeTimer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.виглядToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.LangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.українськаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainGridViev = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ExampleButton1 = new System.Windows.Forms.ToolStripButton();
            this.ExportToPDF = new System.Windows.Forms.ToolStripButton();
            this.ExportToTXT = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.PrevPage = new System.Windows.Forms.ToolStripButton();
            this.NextPage = new System.Windows.Forms.ToolStripButton();
            this.pageNumberInput = new System.Windows.Forms.ToolStripTextBox();
            this.goToPage = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.SortingMenu = new System.Windows.Forms.ToolStripSplitButton();
            this.tempImmunizationId = new System.Windows.Forms.ToolStripMenuItem();
            this.iDЮридичноїОсобиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iDЗакладуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.статусToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.неНаданоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.кодВакциниToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.датаІмунізаціїToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.віковаГрупаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.статьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.виробникToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.номерПартіїToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.придатнаДоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.одиниціВиміруДозиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.значенняДозиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.послідовністьДозВакцинаційногоПротоколуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.серіяВакцинаційногоПротоколуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.дозиСеріїВакцинаційногоПротоколуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.цільовіЗахворюванняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вставленоВToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оновленоВToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddNew = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainGridViev)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CurrentDate,
            this.toolStripProgressBar1,
            this.PagesInfo,
            this.CurrentFileLabel});
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.Name = "statusStrip1";
            // 
            // CurrentDate
            // 
            this.CurrentDate.Name = "CurrentDate";
            resources.ApplyResources(this.CurrentDate, "CurrentDate");
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            resources.ApplyResources(this.toolStripProgressBar1, "toolStripProgressBar1");
            // 
            // PagesInfo
            // 
            this.PagesInfo.Name = "PagesInfo";
            resources.ApplyResources(this.PagesInfo, "PagesInfo");
            // 
            // CurrentFileLabel
            // 
            this.CurrentFileLabel.Name = "CurrentFileLabel";
            resources.ApplyResources(this.CurrentFileLabel, "CurrentFileLabel");
            this.CurrentFileLabel.Spring = true;
            // 
            // StatusTimeTimer
            // 
            this.StatusTimeTimer.Tick += new System.EventHandler(this.StatusTimeTimer_Tick);
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(0);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileStripMenuItem1,
            this.виглядToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // FileStripMenuItem1
            // 
            this.FileStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenu,
            this.openToolStripMenu,
            this.saveToolStripMenu,
            this.saveAsToolStripMenu});
            this.FileStripMenuItem1.Name = "FileStripMenuItem1";
            resources.ApplyResources(this.FileStripMenuItem1, "FileStripMenuItem1");
            // 
            // newToolStripMenu
            // 
            this.newToolStripMenu.Name = "newToolStripMenu";
            resources.ApplyResources(this.newToolStripMenu, "newToolStripMenu");
            this.newToolStripMenu.Click += new System.EventHandler(this.newToolStripMenu_Click);
            // 
            // openToolStripMenu
            // 
            this.openToolStripMenu.Name = "openToolStripMenu";
            resources.ApplyResources(this.openToolStripMenu, "openToolStripMenu");
            this.openToolStripMenu.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenu
            // 
            this.saveToolStripMenu.Name = "saveToolStripMenu";
            resources.ApplyResources(this.saveToolStripMenu, "saveToolStripMenu");
            this.saveToolStripMenu.Click += new System.EventHandler(this.saveToolStripMenu_Click);
            // 
            // saveAsToolStripMenu
            // 
            this.saveAsToolStripMenu.Name = "saveAsToolStripMenu";
            resources.ApplyResources(this.saveAsToolStripMenu, "saveAsToolStripMenu");
            this.saveAsToolStripMenu.Click += new System.EventHandler(this.saveAs_Click);
            // 
            // виглядToolStripMenuItem
            // 
            this.виглядToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gridSettings,
            this.LangToolStripMenuItem});
            this.виглядToolStripMenuItem.Name = "виглядToolStripMenuItem";
            resources.ApplyResources(this.виглядToolStripMenuItem, "виглядToolStripMenuItem");
            // 
            // gridSettings
            // 
            this.gridSettings.Name = "gridSettings";
            resources.ApplyResources(this.gridSettings, "gridSettings");
            this.gridSettings.Click += new System.EventHandler(this.gridSettings_Click);
            // 
            // LangToolStripMenuItem
            // 
            this.LangToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englishToolStripMenuItem,
            this.українськаToolStripMenuItem});
            this.LangToolStripMenuItem.Name = "LangToolStripMenuItem";
            resources.ApplyResources(this.LangToolStripMenuItem, "LangToolStripMenuItem");
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            resources.ApplyResources(this.englishToolStripMenuItem, "englishToolStripMenuItem");
            // 
            // українськаToolStripMenuItem
            // 
            this.українськаToolStripMenuItem.Name = "українськаToolStripMenuItem";
            resources.ApplyResources(this.українськаToolStripMenuItem, "українськаToolStripMenuItem");
            // 
            // MainGridViev
            // 
            this.MainGridViev.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MainGridViev.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.MainGridViev.BackgroundColor = System.Drawing.SystemColors.Control;
            this.MainGridViev.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MainGridViev.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.MainGridViev.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.MainGridViev, "MainGridViev");
            this.MainGridViev.Name = "MainGridViev";
            this.MainGridViev.ReadOnly = true;
            this.MainGridViev.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MainGridViev_CellClick);
            // 
            // toolStrip1
            // 
            resources.ApplyResources(this.toolStrip1, "toolStrip1");
            this.toolStrip1.GripMargin = new System.Windows.Forms.Padding(0);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExampleButton1,
            this.ExportToPDF,
            this.ExportToTXT,
            this.toolStripSeparator1,
            this.PrevPage,
            this.NextPage,
            this.pageNumberInput,
            this.goToPage,
            this.toolStripSeparator2,
            this.SortingMenu,
            this.AddNew});
            this.toolStrip1.Name = "toolStrip1";
            // 
            // ExampleButton1
            // 
            this.ExampleButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.ExampleButton1, "ExampleButton1");
            this.ExampleButton1.Name = "ExampleButton1";
            this.ExampleButton1.Click += new System.EventHandler(this.saveToolStripMenu_Click);
            // 
            // ExportToPDF
            // 
            this.ExportToPDF.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ExportToPDF.Image = global::Vactination_DB_Manager.Properties.Resources.PDF1;
            resources.ApplyResources(this.ExportToPDF, "ExportToPDF");
            this.ExportToPDF.Name = "ExportToPDF";
            // 
            // ExportToTXT
            // 
            this.ExportToTXT.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ExportToTXT.Image = global::Vactination_DB_Manager.Properties.Resources.TXT;
            resources.ApplyResources(this.ExportToTXT, "ExportToTXT");
            this.ExportToTXT.Name = "ExportToTXT";
            this.ExportToTXT.Click += new System.EventHandler(this.ExportToTXT_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // PrevPage
            // 
            this.PrevPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PrevPage.Image = global::Vactination_DB_Manager.Properties.Resources.hand_left_arrow;
            resources.ApplyResources(this.PrevPage, "PrevPage");
            this.PrevPage.Name = "PrevPage";
            this.PrevPage.Click += new System.EventHandler(this.PrevPage_Click);
            // 
            // NextPage
            // 
            this.NextPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NextPage.Image = global::Vactination_DB_Manager.Properties.Resources.hand_right_arrow;
            resources.ApplyResources(this.NextPage, "NextPage");
            this.NextPage.Name = "NextPage";
            this.NextPage.Click += new System.EventHandler(this.NextPage_Click);
            // 
            // pageNumberInput
            // 
            this.pageNumberInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.pageNumberInput, "pageNumberInput");
            this.pageNumberInput.Name = "pageNumberInput";
            this.pageNumberInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pageNumberInput_KeyPress);
            // 
            // goToPage
            // 
            this.goToPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.goToPage.Image = global::Vactination_DB_Manager.Properties.Resources.lookPage;
            resources.ApplyResources(this.goToPage, "goToPage");
            this.goToPage.Name = "goToPage";
            this.goToPage.Click += new System.EventHandler(this.goToPage_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            // 
            // SortingMenu
            // 
            this.SortingMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SortingMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tempImmunizationId,
            this.iDЮридичноїОсобиToolStripMenuItem,
            this.iDЗакладуToolStripMenuItem,
            this.статусToolStripMenuItem,
            this.неНаданоToolStripMenuItem,
            this.кодВакциниToolStripMenuItem,
            this.датаІмунізаціїToolStripMenuItem,
            this.віковаГрупаToolStripMenuItem,
            this.статьToolStripMenuItem,
            this.виробникToolStripMenuItem,
            this.номерПартіїToolStripMenuItem,
            this.придатнаДоToolStripMenuItem,
            this.одиниціВиміруДозиToolStripMenuItem,
            this.значенняДозиToolStripMenuItem,
            this.послідовністьДозВакцинаційногоПротоколуToolStripMenuItem,
            this.серіяВакцинаційногоПротоколуToolStripMenuItem,
            this.дозиСеріїВакцинаційногоПротоколуToolStripMenuItem,
            this.цільовіЗахворюванняToolStripMenuItem,
            this.вставленоВToolStripMenuItem,
            this.оновленоВToolStripMenuItem});
            this.SortingMenu.Image = global::Vactination_DB_Manager.Properties.Resources.sortv2;
            resources.ApplyResources(this.SortingMenu, "SortingMenu");
            this.SortingMenu.Name = "SortingMenu";
            this.SortingMenu.ButtonClick += new System.EventHandler(this.SortingMenu_Click);
            // 
            // tempImmunizationId
            // 
            this.tempImmunizationId.Name = "tempImmunizationId";
            resources.ApplyResources(this.tempImmunizationId, "tempImmunizationId");
            this.tempImmunizationId.Click += new System.EventHandler(this.sortSelect_Click);
            // 
            // iDЮридичноїОсобиToolStripMenuItem
            // 
            this.iDЮридичноїОсобиToolStripMenuItem.Name = "iDЮридичноїОсобиToolStripMenuItem";
            resources.ApplyResources(this.iDЮридичноїОсобиToolStripMenuItem, "iDЮридичноїОсобиToolStripMenuItem");
            this.iDЮридичноїОсобиToolStripMenuItem.Click += new System.EventHandler(this.sortSelect_Click);
            // 
            // iDЗакладуToolStripMenuItem
            // 
            this.iDЗакладуToolStripMenuItem.Name = "iDЗакладуToolStripMenuItem";
            resources.ApplyResources(this.iDЗакладуToolStripMenuItem, "iDЗакладуToolStripMenuItem");
            this.iDЗакладуToolStripMenuItem.Click += new System.EventHandler(this.sortSelect_Click);
            // 
            // статусToolStripMenuItem
            // 
            this.статусToolStripMenuItem.Name = "статусToolStripMenuItem";
            resources.ApplyResources(this.статусToolStripMenuItem, "статусToolStripMenuItem");
            this.статусToolStripMenuItem.Click += new System.EventHandler(this.sortSelect_Click);
            // 
            // неНаданоToolStripMenuItem
            // 
            this.неНаданоToolStripMenuItem.Name = "неНаданоToolStripMenuItem";
            resources.ApplyResources(this.неНаданоToolStripMenuItem, "неНаданоToolStripMenuItem");
            this.неНаданоToolStripMenuItem.Click += new System.EventHandler(this.sortSelect_Click);
            // 
            // кодВакциниToolStripMenuItem
            // 
            this.кодВакциниToolStripMenuItem.Name = "кодВакциниToolStripMenuItem";
            resources.ApplyResources(this.кодВакциниToolStripMenuItem, "кодВакциниToolStripMenuItem");
            this.кодВакциниToolStripMenuItem.Click += new System.EventHandler(this.sortSelect_Click);
            // 
            // датаІмунізаціїToolStripMenuItem
            // 
            this.датаІмунізаціїToolStripMenuItem.Name = "датаІмунізаціїToolStripMenuItem";
            resources.ApplyResources(this.датаІмунізаціїToolStripMenuItem, "датаІмунізаціїToolStripMenuItem");
            this.датаІмунізаціїToolStripMenuItem.Click += new System.EventHandler(this.sortSelect_Click);
            // 
            // віковаГрупаToolStripMenuItem
            // 
            this.віковаГрупаToolStripMenuItem.Name = "віковаГрупаToolStripMenuItem";
            resources.ApplyResources(this.віковаГрупаToolStripMenuItem, "віковаГрупаToolStripMenuItem");
            this.віковаГрупаToolStripMenuItem.Click += new System.EventHandler(this.sortSelect_Click);
            // 
            // статьToolStripMenuItem
            // 
            this.статьToolStripMenuItem.Name = "статьToolStripMenuItem";
            resources.ApplyResources(this.статьToolStripMenuItem, "статьToolStripMenuItem");
            this.статьToolStripMenuItem.Click += new System.EventHandler(this.sortSelect_Click);
            // 
            // виробникToolStripMenuItem
            // 
            this.виробникToolStripMenuItem.Name = "виробникToolStripMenuItem";
            resources.ApplyResources(this.виробникToolStripMenuItem, "виробникToolStripMenuItem");
            this.виробникToolStripMenuItem.Click += new System.EventHandler(this.sortSelect_Click);
            // 
            // номерПартіїToolStripMenuItem
            // 
            this.номерПартіїToolStripMenuItem.Name = "номерПартіїToolStripMenuItem";
            resources.ApplyResources(this.номерПартіїToolStripMenuItem, "номерПартіїToolStripMenuItem");
            this.номерПартіїToolStripMenuItem.Click += new System.EventHandler(this.sortSelect_Click);
            // 
            // придатнаДоToolStripMenuItem
            // 
            this.придатнаДоToolStripMenuItem.Name = "придатнаДоToolStripMenuItem";
            resources.ApplyResources(this.придатнаДоToolStripMenuItem, "придатнаДоToolStripMenuItem");
            this.придатнаДоToolStripMenuItem.Click += new System.EventHandler(this.sortSelect_Click);
            // 
            // одиниціВиміруДозиToolStripMenuItem
            // 
            this.одиниціВиміруДозиToolStripMenuItem.Name = "одиниціВиміруДозиToolStripMenuItem";
            resources.ApplyResources(this.одиниціВиміруДозиToolStripMenuItem, "одиниціВиміруДозиToolStripMenuItem");
            this.одиниціВиміруДозиToolStripMenuItem.Click += new System.EventHandler(this.sortSelect_Click);
            // 
            // значенняДозиToolStripMenuItem
            // 
            this.значенняДозиToolStripMenuItem.Name = "значенняДозиToolStripMenuItem";
            resources.ApplyResources(this.значенняДозиToolStripMenuItem, "значенняДозиToolStripMenuItem");
            this.значенняДозиToolStripMenuItem.Click += new System.EventHandler(this.sortSelect_Click);
            // 
            // послідовністьДозВакцинаційногоПротоколуToolStripMenuItem
            // 
            this.послідовністьДозВакцинаційногоПротоколуToolStripMenuItem.Name = "послідовністьДозВакцинаційногоПротоколуToolStripMenuItem";
            resources.ApplyResources(this.послідовністьДозВакцинаційногоПротоколуToolStripMenuItem, "послідовністьДозВакцинаційногоПротоколуToolStripMenuItem");
            this.послідовністьДозВакцинаційногоПротоколуToolStripMenuItem.Click += new System.EventHandler(this.sortSelect_Click);
            // 
            // серіяВакцинаційногоПротоколуToolStripMenuItem
            // 
            this.серіяВакцинаційногоПротоколуToolStripMenuItem.Name = "серіяВакцинаційногоПротоколуToolStripMenuItem";
            resources.ApplyResources(this.серіяВакцинаційногоПротоколуToolStripMenuItem, "серіяВакцинаційногоПротоколуToolStripMenuItem");
            this.серіяВакцинаційногоПротоколуToolStripMenuItem.Click += new System.EventHandler(this.sortSelect_Click);
            // 
            // дозиСеріїВакцинаційногоПротоколуToolStripMenuItem
            // 
            this.дозиСеріїВакцинаційногоПротоколуToolStripMenuItem.Name = "дозиСеріїВакцинаційногоПротоколуToolStripMenuItem";
            resources.ApplyResources(this.дозиСеріїВакцинаційногоПротоколуToolStripMenuItem, "дозиСеріїВакцинаційногоПротоколуToolStripMenuItem");
            this.дозиСеріїВакцинаційногоПротоколуToolStripMenuItem.Click += new System.EventHandler(this.sortSelect_Click);
            // 
            // цільовіЗахворюванняToolStripMenuItem
            // 
            this.цільовіЗахворюванняToolStripMenuItem.Name = "цільовіЗахворюванняToolStripMenuItem";
            resources.ApplyResources(this.цільовіЗахворюванняToolStripMenuItem, "цільовіЗахворюванняToolStripMenuItem");
            this.цільовіЗахворюванняToolStripMenuItem.Click += new System.EventHandler(this.sortSelect_Click);
            // 
            // вставленоВToolStripMenuItem
            // 
            this.вставленоВToolStripMenuItem.Name = "вставленоВToolStripMenuItem";
            resources.ApplyResources(this.вставленоВToolStripMenuItem, "вставленоВToolStripMenuItem");
            this.вставленоВToolStripMenuItem.Click += new System.EventHandler(this.sortSelect_Click);
            // 
            // оновленоВToolStripMenuItem
            // 
            this.оновленоВToolStripMenuItem.Name = "оновленоВToolStripMenuItem";
            resources.ApplyResources(this.оновленоВToolStripMenuItem, "оновленоВToolStripMenuItem");
            this.оновленоВToolStripMenuItem.Click += new System.EventHandler(this.sortSelect_Click);
            // 
            // AddNew
            // 
            this.AddNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AddNew.Image = global::Vactination_DB_Manager.Properties.Resources.add_person;
            resources.ApplyResources(this.AddNew, "AddNew");
            this.AddNew.Name = "AddNew";
            this.AddNew.Click += new System.EventHandler(this.AddNew_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.MainGridViev);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainGridViev)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Timer StatusTimeTimer;
        private System.Windows.Forms.ToolStripStatusLabel CurrentDate;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenu;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton ExampleButton1;
        private System.Windows.Forms.ToolStripButton PrevPage;
        private System.Windows.Forms.ToolStripButton NextPage;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        public System.Windows.Forms.DataGridView MainGridViev;
        private System.Windows.Forms.ToolStripMenuItem виглядToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gridSettings;
        private System.Windows.Forms.ToolStripMenuItem LangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem українськаToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel PagesInfo;
        private System.Windows.Forms.ToolStripButton goToPage;
        private System.Windows.Forms.ToolStripTextBox pageNumberInput;
        private System.Windows.Forms.ToolStripButton ExportToPDF;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSplitButton SortingMenu;
        private System.Windows.Forms.ToolStripMenuItem tempImmunizationId;
        private System.Windows.Forms.ToolStripMenuItem iDЮридичноїОсобиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iDЗакладуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem статусToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem неНаданоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem датаІмунізаціїToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem віковаГрупаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem статьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem виробникToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem номерПартіїToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem придатнаДоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem одиниціВиміруДозиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem значенняДозиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem послідовністьДозВакцинаційногоПротоколуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem серіяВакцинаційногоПротоколуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem цільовіЗахворюванняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вставленоВToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оновленоВToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem кодВакциниToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem дозиСеріїВакцинаційногоПротоколуToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton AddNew;
        private System.Windows.Forms.ToolStripButton ExportToTXT;
        private System.Windows.Forms.ToolStripStatusLabel CurrentFileLabel;
    }
}

