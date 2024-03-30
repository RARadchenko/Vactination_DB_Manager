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
        private PatientsContainer patientsContainer;

        private int currentPage = 1;
        private int maxPage = 1;
        private bool reverseSort = false;
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

            patientsContainer = new PatientsContainer();

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
                string[] readedLines = dBFile.readDBFileLikeArrayOfLines();
                patientsContainer.clearPatients();
                for(int i = 1; i < readedLines.Length; i++)
                {
                    Patient patient = new Patient(readedLines[i]);
                    patientsContainer.addPatient(patient);
                }
                maxPage = patientsContainer.PatientsList.Count / MainGridVievSettings.q_of_patients_on_page;
                PagesInfo.Text = $"{currentPage} page of {maxPage}";
                showPage();
                //showLines(1, MainGridVievSettings.q_of_patients_on_page+1);
            }
        }

        private void showPage()
        {
            mGV.refresh();
            maxPage = patientsContainer.PatientsList.Count / MainGridVievSettings.q_of_patients_on_page;
            PagesInfo.Text = $"{currentPage} page of {maxPage}";
            int start = currentPage * MainGridVievSettings.q_of_patients_on_page - (MainGridVievSettings.q_of_patients_on_page - 1);
            int finish = currentPage * MainGridVievSettings.q_of_patients_on_page + 1;
            //string[] mama = patientsContainer.getOnePatient(439);
            for (int i = start; i < finish; i++)
            {
                mGV.addNewLine(patientsContainer.getOnePatient(i));
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
            mainGrid.changeFontStyle();
            mainGrid.changeColums();

        }

        private void MainGridViev_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < MainGridViev.Rows.Count - 1)
            {
                DataGridViewRow row = MainGridViev.Rows[e.RowIndex];
                StringBuilder message = new StringBuilder();

                foreach (DataGridViewCell cell in row.Cells)
                {
                    message.Append(cell.Value.ToString());
                    message.Append(Environment.NewLine);
                }
                MessageBox.Show(message.ToString(), "Значення рядка");
            }
        }


        private void SortingMenu_Click(object sender, EventArgs e)
        {
            if (!reverseSort)
            {
                SortingMenu.Image = Vactination_DB_Manager.Properties.Resources.sortv22;
            }
            else
            {
                SortingMenu.Image = Vactination_DB_Manager.Properties.Resources.sortv2;
            }
            reverseSort = !reverseSort;
            patientsContainer.reversePatients();
            showPage();
        }

        private void sortSelect_Click(object sender, EventArgs e)
        {
            int selected = Array.IndexOf(mGV.ua_lang_mask, sender.ToString());
            patientsContainer.SortByArg(selected, reverseSort);
            showPage();
            //MessageBox.Show(selected.ToString() + string.Join("|", mGV.ua_lang_mask) + sender.ToString(), "Значення рядка");
        }
    }
}
