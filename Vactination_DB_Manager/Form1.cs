using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Vactination_DB_Manager
{
    public partial class Form1 : Form
    {
        private DataGridView mGV;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // запуск таймеру
            StatusTimeTimer.Enabled = true;
            StatusTimeTimer.Interval = 100;
            StatusTimeTimer.Start();

            //налаштування mainGridViev
            MainGridVievSettings mainGrid = new MainGridVievSettings(MainGridViev);
            mainGrid.startSettings();

            mGV = MainGridViev;
        }
        /// <summary>
        /// обробник таймеру поточної дати та часу
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StatusTimeTimer_Tick(object sender, EventArgs e)
        {
            StatusTimeTimer.Interval = 1000;
            DateTime dt = DateTime.Now;
            // перетворення DateTime.Now на дату/час
            CurrentDate.Text = dt.ToString();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CVS files (*.csv)|*.csv";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                DBFileManager dBFile = new DBFileManager(openFileDialog.FileName);
                dBFile.readDBFileLikeArrayOfLines();
                MainGridVievSettings mainGrid = new MainGridVievSettings(MainGridViev);
                for (int i = 1; i < 100; i++)
                {
                    mainGrid.addNewLine(dBFile.splitLine(dBFile.getOneLine(i)));
                    toolStripProgressBar1.Value = i;
                }
                //toolStripProgressBar1.Value = 0;
            }
        }
    }
}
