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
using static System.Net.WebRequestMethods;


namespace Vactination_DB_Manager
{
    public partial class Form1 : Form
    {
        private MainGridVievSettings mGV;
        private DBFileManager dBFile;

        private int currentPage = 1;
        private int maxPage = 1;
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

            mGV = mainGrid;
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
                dBFile = new DBFileManager(openFileDialog.FileName);
                dBFile.readDBFileLikeArrayOfLines();
                maxPage = dBFile.LinesCount / MainGridVievSettings.q_of_patients_on_page;
                PagesInfo.Text = $"{currentPage} page of {maxPage}";
                showPage();
                //showLines(1, MainGridVievSettings.q_of_patients_on_page+1);
            }
        }

        private void showPage()
        {
            mGV.refresh();
            maxPage = dBFile.LinesCount / MainGridVievSettings.q_of_patients_on_page;
            PagesInfo.Text = $"{currentPage} page of {maxPage}";
            int start = currentPage * MainGridVievSettings.q_of_patients_on_page - (MainGridVievSettings.q_of_patients_on_page - 1);
            int finish = currentPage * MainGridVievSettings.q_of_patients_on_page + 1;

            for (int i = start; i < finish; i++)
            {
                mGV.addNewLine(dBFile.splitLine(dBFile.getOneLine(i)));
                toolStripProgressBar1.Value = (int)((double)((i - start) / (double)(finish - start)) * 100.0);
            }
            //showLines(currentPage * MainGridVievSettings.q_of_patients_on_page - (MainGridVievSettings.q_of_patients_on_page - 1), currentPage * MainGridVievSettings.q_of_patients_on_page + 1);
        }
        private void NextPage_Click(object sender, EventArgs e)
        {
            if (currentPage+1 <= maxPage) { currentPage += 1; showPage();}
            else {
                MessageBox.Show($"Page can`t be greather than {maxPage}", "Error");
            }
        }

        private void PrevPage_Click(object sender, EventArgs e)
        {
            if (currentPage-1 > 0) { currentPage -= 1; showPage(); }
            else
            {
                MessageBox.Show($"Page can`t be less than 0", "Error");
            }
        }

        private void pageNumberInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void goToPage_Click(object sender, EventArgs e)
        {
            if (int.Parse(pageNumberInput.Text) > 0 && int.Parse(pageNumberInput.Text) <= maxPage) { currentPage = int.Parse(pageNumberInput.Text); showPage(); }
            else
            {
                MessageBox.Show($"Page must be in range [1:{maxPage}]", "Error");
            }
        }

        private void gridSettings_Click(object sender, EventArgs e)
        {
            GridSettingsForm gridSettingsForm = new GridSettingsForm();
            gridSettingsForm.ShowDialog();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            MainGridVievSettings mainGrid = new MainGridVievSettings(MainGridViev);
            mainGrid.changeCellsColor();
        }
    }
}
