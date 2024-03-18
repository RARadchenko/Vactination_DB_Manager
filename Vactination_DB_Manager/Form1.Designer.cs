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
            this.StatusTimeTimer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.виглядToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.таблицяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.українськаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainGridViev = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ExampleButton1 = new System.Windows.Forms.ToolStripButton();
            this.PrevPage = new System.Windows.Forms.ToolStripButton();
            this.NextPage = new System.Windows.Forms.ToolStripButton();
            this.goToPage = new System.Windows.Forms.ToolStripButton();
            this.pageNumberInput = new System.Windows.Forms.ToolStripTextBox();
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
            this.PagesInfo});
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
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem});
            this.FileStripMenuItem1.Name = "FileStripMenuItem1";
            resources.ApplyResources(this.FileStripMenuItem1, "FileStripMenuItem1");
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            resources.ApplyResources(this.newToolStripMenuItem, "newToolStripMenuItem");
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            resources.ApplyResources(this.openToolStripMenuItem, "openToolStripMenuItem");
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            resources.ApplyResources(this.saveToolStripMenuItem, "saveToolStripMenuItem");
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            resources.ApplyResources(this.saveAsToolStripMenuItem, "saveAsToolStripMenuItem");
            // 
            // виглядToolStripMenuItem
            // 
            this.виглядToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.таблицяToolStripMenuItem,
            this.LangToolStripMenuItem});
            this.виглядToolStripMenuItem.Name = "виглядToolStripMenuItem";
            resources.ApplyResources(this.виглядToolStripMenuItem, "виглядToolStripMenuItem");
            // 
            // таблицяToolStripMenuItem
            // 
            this.таблицяToolStripMenuItem.Name = "таблицяToolStripMenuItem";
            resources.ApplyResources(this.таблицяToolStripMenuItem, "таблицяToolStripMenuItem");
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
            this.MainGridViev.BackgroundColor = System.Drawing.SystemColors.Control;
            this.MainGridViev.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MainGridViev.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.MainGridViev, "MainGridViev");
            this.MainGridViev.Name = "MainGridViev";
            this.MainGridViev.ReadOnly = true;
            // 
            // toolStrip1
            // 
            resources.ApplyResources(this.toolStrip1, "toolStrip1");
            this.toolStrip1.GripMargin = new System.Windows.Forms.Padding(0);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExampleButton1,
            this.PrevPage,
            this.NextPage,
            this.pageNumberInput,
            this.goToPage});
            this.toolStrip1.Name = "toolStrip1";
            // 
            // ExampleButton1
            // 
            this.ExampleButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.ExampleButton1, "ExampleButton1");
            this.ExampleButton1.Name = "ExampleButton1";
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
            // goToPage
            // 
            this.goToPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.goToPage.Image = global::Vactination_DB_Manager.Properties.Resources.lookPage;
            resources.ApplyResources(this.goToPage, "goToPage");
            this.goToPage.Name = "goToPage";
            this.goToPage.Click += new System.EventHandler(this.goToPage_Click);
            // 
            // pageNumberInput
            // 
            this.pageNumberInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.pageNumberInput, "pageNumberInput");
            this.pageNumberInput.Name = "pageNumberInput";
            this.pageNumberInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pageNumberInput_KeyPress);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.MainGridViev);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton ExampleButton1;
        private System.Windows.Forms.ToolStripButton PrevPage;
        private System.Windows.Forms.ToolStripButton NextPage;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        public System.Windows.Forms.DataGridView MainGridViev;
        private System.Windows.Forms.ToolStripMenuItem виглядToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem таблицяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem українськаToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel PagesInfo;
        private System.Windows.Forms.ToolStripButton goToPage;
        private System.Windows.Forms.ToolStripTextBox pageNumberInput;
    }
}

