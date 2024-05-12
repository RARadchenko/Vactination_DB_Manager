using MigraDoc.DocumentObjectModel.Tables;
using MigraDoc.DocumentObjectModel;
using MigraDoc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;



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
        private bool searchMode  = false;

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

            CurrentFileLabel.Text = "Новий файл";
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

        /// <summary>
        /// відкриття файлу бази даних
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CVS files (*.csv)|*.csv";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                CurrentFileLabel.Text = openFileDialog.FileName;
                dBFile = new DBFileManager(openFileDialog.FileName);
                currentPage = 1;
                dBFile.readDBFileLikeArrayOfLines();
                patientsContainer.clearPatients();
                FillUpPatientContainer();
                Thread.Sleep(100);
                showPage();
                maxPage = dBFile.LinesCount / MainGridVievSettings.q_of_patients_on_page;
                maxPage += (patientsContainer.PatientsList.Count % MainGridVievSettings.q_of_patients_on_page == 0) ? 0 : 1;
                PagesInfo.Text = $"{currentPage} сторінка з {maxPage}";
            }
        }

        /// <summary>
        /// заповнення класу-контейнера зчитаними записами
        /// </summary>
        async void FillUpPatientContainer()
        {
            await Task.Run(() =>
            {
                for (int i = 1; i < dBFile.LinesCount; i++)
                {
                    Patient patient = new Patient(dBFile.getOneLine(i));
                    patientsContainer.addPatient(patient);
                }
            });
        }

        /// <summary>
        /// відображення сторінки
        /// </summary>
        private void showPage()
        {
            mGV.refresh();
            //розрахунок записів для відображення
            int start = currentPage * MainGridVievSettings.q_of_patients_on_page - (MainGridVievSettings.q_of_patients_on_page - 1);
            int finish = 0;
            //перерозрахунок сторінок
            if (!searchMode) {
                maxPage = patientsContainer.PatientsList.Count / MainGridVievSettings.q_of_patients_on_page;
                maxPage += (patientsContainer.PatientsList.Count % MainGridVievSettings.q_of_patients_on_page == 0) ? 0 : 1;
                finish = currentPage != maxPage ? currentPage * MainGridVievSettings.q_of_patients_on_page + 1 : patientsContainer.PatientsList.Count + 1;
            }
            else
            {
                maxPage = patientsContainer.SearchedPatientsList.Count / MainGridVievSettings.q_of_patients_on_page;
                maxPage += (patientsContainer.SearchedPatientsList.Count % MainGridVievSettings.q_of_patients_on_page == 0) ? 0 : 1;
                finish = currentPage != maxPage ? currentPage * MainGridVievSettings.q_of_patients_on_page + 1 : patientsContainer.SearchedPatientsList.Count + 1;
            }

            PagesInfo.Text = $"{currentPage} page of {maxPage}";
            toolStripProgressBar1.Minimum = start;
            toolStripProgressBar1.Maximum = finish;
            for (int i = start; i < finish; i++)
            {
                //відображення кожного запису
                mGV.addNewLine(patientsContainer.getOnePatient(i - 1, true, searchMode));
                toolStripProgressBar1.Value = i + 1;
            }
            
        }

        /// <summary>
        /// обробниик переходу на наступну сторінку
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextPage_Click(object sender, EventArgs e)
        {
            if (currentPage + 1 <= maxPage) { currentPage += 1; showPage(); }
            else
            {
                MessageBox.Show($"Сторінка не може бути більша ніж {maxPage}", "Помилка");
            }
        }

        /// <summary>
        /// обробник переходу на попередню сторінку
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PrevPage_Click(object sender, EventArgs e)
        {
            if (currentPage - 1 > 0) { currentPage -= 1; showPage(); }
            else
            {
                MessageBox.Show($"Сторінка не може бути менша ніж 0", "Помилка");
            }
        }

        /// <summary>
        /// ігнорування введення чогось окрім чисел
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pageNumberInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Enter)
            {
                goToPage_Click(sender, e);
            }
        }

        /// <summary>
        /// перехід на сторінку по номеру
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void goToPage_Click(object sender, EventArgs e)
        {
            if (int.Parse(pageNumberInput.Text) > 0 && int.Parse(pageNumberInput.Text) <= maxPage) { currentPage = int.Parse(pageNumberInput.Text); showPage(); }
            else
            {
                MessageBox.Show($"Сторінка повинна бути в діапазоні [1:{maxPage}]", "Помилка");
            }
        }

        /// <summary>
        /// обробник налаштувань таблиці
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridSettings_Click(object sender, EventArgs e)
        {
            GridSettingsForm gridSettingsForm = new GridSettingsForm();
            gridSettingsForm.FormClosed += ForRefresh_FormClosed;
            gridSettingsForm.ShowDialog();
            showPage();
        }

        /// <summary>
        /// при розгортанні вікна прибирання артефактів
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Activated(object sender, EventArgs e)
        {
            MainGridVievSettings mainGrid = new MainGridVievSettings(MainGridViev);
            mainGrid.changeCellsColor();
            mainGrid.changeFontStyle();
            mainGrid.changeColums();

        }

        /// <summary>
        /// обробник редагування/видалення запису
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainGridViev_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < MainGridViev.Rows.Count - 1)
            {
                //DataGridViewRow row = MainGridViev.Rows[e.RowIndex];
                int pageIndex = currentPage == 0 ? 1 : (currentPage - 1) * MainGridVievSettings.q_of_patients_on_page;
                PatientEditor patientEditor = new PatientEditor(patientsContainer.PatientsList[(e.RowIndex) + (pageIndex)], patientsContainer, false);
                patientEditor.FormClosed += ForRefresh_FormClosed;
                patientEditor.ShowDialog();
            }
        }

        private void ForRefresh_FormClosed(object sender, FormClosedEventArgs e)
        {
            showPage();
        }

        /// <summary>
        /// обробник сортування записів
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// обрання поля для сортування
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sortSelect_Click(object sender, EventArgs e)
        {
            int selected = Array.IndexOf(mGV.ua_lang_mask, sender.ToString());
            patientsContainer.SortByArg(selected, reverseSort);
            showPage();
        }

        /// <summary>
        /// обробник додавання нового запису
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddNew_Click(object sender, EventArgs e)
        {
            PatientEditor patientEditor = new PatientEditor(new Patient(), patientsContainer, true);
            patientEditor.FormClosed += ForRefresh_FormClosed;
            patientEditor.ShowDialog();
        }

        /// <summary>
        /// обробник експорту до TXT
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExportToTXT_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "TXT files (*.txt)|*.txt";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                TextExport ex = new TextExport( true, 40);
                toolStripProgressBar1.Minimum = 0;
                toolStripProgressBar1.Maximum = patientsContainer.PatientsList.Count;
                for (int i = 0; i < patientsContainer.PatientsList.Count; i++)
                {
                    ex.ExportByLine(saveFileDialog.FileName, patientsContainer.getOnePatient(i, false));
                    toolStripProgressBar1.Value = i + 1;
                }
            }
        }

        /// <summary>
        /// обробник зберегти як
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV files (*.csv)|*.csv";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                CurrentFileLabel.Text = saveFileDialog.FileName;
                TextExport ex = new TextExport(",", ",", true, 0);
                ex.AddNewLine(mGV.en_lang_mask);
                ex.Export(saveFileDialog.FileName);
                toolStripProgressBar1.Minimum = 0;
                toolStripProgressBar1.Maximum = patientsContainer.PatientsList.Count;
                for (int i = 0; i < patientsContainer.PatientsList.Count; i++)
                {
                    ex.ExportByLine(saveFileDialog.FileName, patientsContainer.getOnePatient(i, false));
                    toolStripProgressBar1.Value = i + 1;
                }
            }
        }

        /// <summary>
        /// обробник створення нового файлу бази даних
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV files (*.csv)|*.csv";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                CurrentFileLabel.Text = saveFileDialog.FileName;
                using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                {
                    writer.WriteLine();
                    writer.Close();
                }
                patientsContainer.clearPatients();
                mGV.refresh();
            }
        }

        /// <summary>
        /// збереження поточного файлу бази даних
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveFile_Click(object sender, EventArgs e)
        {
            if (CurrentFileLabel.Text == "Новий файл")
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "CSV files (*.csv)|*.csv";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    CurrentFileLabel.Text = saveFileDialog.FileName;
                }
            }
            //використання сайд-еффекту від іншого класу
            TextExport ex = new TextExport(",", ",", true, 0);
            ex.AddNewLine(mGV.en_lang_mask);
            ex.Export(CurrentFileLabel.Text);
            toolStripProgressBar1.Minimum = 0;
            toolStripProgressBar1.Maximum = patientsContainer.PatientsList.Count;
            for (int i = 0; i < patientsContainer.PatientsList.Count; i++)
            {
                ex.ExportByLine(CurrentFileLabel.Text, patientsContainer.getOnePatient(i, false));
                toolStripProgressBar1.Value = i + 1;
            }
        }

        /// <summary>
        /// експорт до PDF
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExportToPDF_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // розбиття записів на делька PDF задля більш швидшого рендерінгу
                int maxFile = patientsContainer.PatientsList.Count / 1345;
                maxFile += (patientsContainer.PatientsList.Count % 1345 == 0) ? 0 : 1;
                toolStripProgressBar1.Minimum = 0;
                toolStripProgressBar1.Maximum = maxFile;
                string filePath = saveFileDialog.FileName;
                string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(filePath);
                string fileExtension = Path.GetExtension(filePath);
                string directory = Path.GetDirectoryName(filePath);
                for (int currentFile = 0; currentFile < maxFile; currentFile++)
                {
                    int start = currentFile * 1345;
                    int finish = currentFile == maxFile -1 ? patientsContainer.PatientsList.Count - 1 : (currentFile + 1)* 1354;
                    SavePDFFile(Path.Combine(directory, $"{fileNameWithoutExtension}{currentFile}{fileExtension}"), start, finish);
                    toolStripProgressBar1.Value = currentFile + 1;

                }
            }
        }

        /// <summary>
        /// асинхронна функція експорту записів до таблиці PDF файлу
        /// </summary>
        /// <param name="шлях до файлу"></param>
        /// <param name="початковий запис"></param>
        /// <param name="кінцевий запис"></param>
        async private void SavePDFFile(string Path, int start, int finish)
        {
            await Task.Run(() =>
            {
                Document document = new Document();

            // Додаємо розділ до документу
            Section section = document.AddSection();
            section.PageSetup.LeftMargin = 15;
            section.PageSetup.TopMargin = 10;
            section.PageSetup.BottomMargin = 10;
            section.PageSetup.Orientation = MigraDoc.DocumentObjectModel.Orientation.Landscape;
            // Додаємо таблицю
            Table table = section.AddTable();

            table.Format.LeftIndent = -10;
            string[] oneLIne = new string[20];
            PdfDocumentRenderer pdfRenderer = new PdfDocumentRenderer(true);
            //    pdfRenderer.Document = document;


                for (int i = 0; i < mGV.ua_lang_mask.Length; i++)
            {
                if ((i > 2 && i < 9) || (i > 9 && i < 15) || i == 19 || i == 18 || i == 16) { table.AddColumn(Unit.FromPoint(30)); }
                else if (i == 9) { table.AddColumn(Unit.FromPoint(100)); }
                else { table.AddColumn(Unit.FromPoint(60)); }
            }
            Row row = table.AddRow();
            for (int i = 0; i < mGV.ua_lang_mask.Length; i++)
            {
                row.Cells[i].AddParagraph(mGV.ua_lang_mask[i]).Format.Font.Size = 3;
            }
            for (int i = start; i < finish; i++)
            {
                row = table.AddRow();
                for (int j = 0; j < mGV.ua_lang_mask.Length; j++)
                {
                    oneLIne = patientsContainer.getOnePatient(i, false);
                    row.Cells[j].AddParagraph(oneLIne[j]).Format.Font.Size = 3;
                }

                    if (i % 1345 == 0 && i != 0)
                    {
                    }
                }
                pdfRenderer.Document = document;
                pdfRenderer.RenderDocument();
                pdfRenderer.PdfDocument.Save(Path);
            });
        }


        
        /// <summary>
        /// обробник натискання ввід в текстовому полі пошуку
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void searchButton_Click(object sender, EventArgs e)
        {
            if (search.Text.Length == 0) 
            {
                searchMode = false;
                showPage();
                return;
            }
            searchMode = true;
            currentPage = 1;
            patientsContainer.searchPatients(search.Text);
            showPage();
        }

        /// <summary>
        /// обробник кнопки пошуку
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void search_KeyPress(object sender, KeyPressEventArgs e)
        {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    searchButton_Click(sender, e);
                }
        }
    }

}
