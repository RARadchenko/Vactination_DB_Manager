using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Vactination_DB_Manager
{
    public class MainGridVievSettings
    {
        private System.Windows.Forms.DataGridView MainGridViev;
        private string chosen_lang = "en";

        private string[] en_lang_mask = { };
        private string[] ua_lang_mask = { };

        public static int q_of_patients_on_page { get; set; } = 50;
        public static Color alternativeCellColorBackground { get; set; } = Color.WhiteSmoke;
        public static Color CellColorBackground { get; set; } = Color.White;

        private void readLangsMasks()
        {
            ResourceManager resourceManager = new ResourceManager("Vactination_DB_Manager.GridViewLangMasks", typeof(MainGridVievSettings).Assembly);

            // Зчитування масок з файлу ресурсів
            en_lang_mask = resourceManager.GetString("EN_lang_grid_mask").Split(',');
            ua_lang_mask = resourceManager.GetString("UA_lang_grid_mask").Split(',');
        }

        public MainGridVievSettings(System.Windows.Forms.DataGridView MainGridViev, string lang) 
        { 
            this.MainGridViev = MainGridViev;
            chosen_lang = lang;
            readLangsMasks();
        }

        public MainGridVievSettings(System.Windows.Forms.DataGridView MainGridViev)
        {
            this.MainGridViev = MainGridViev;
            readLangsMasks();
        }

        public void startSettings()
        {
            MainGridViev.Height = 900;
            // Перевірка вибраної мови і встановлення маски відповідно
            string[] mask;
            if (chosen_lang == "en")
            {
                mask = en_lang_mask;
            }
            else
            {
                mask = ua_lang_mask;
            }

            // Встановлення налаштувань для MainGridView з використанням обраної маски
            MainGridViev.RowCount = 1;

            MainGridViev.ColumnCount = mask.Length;
            //MainGridViev.Columns.Clear();
            for (int i = 0; i < mask.Length; i++)
            {
                MainGridViev.Columns[i].HeaderText = mask[i];
            }
        }

        public void refresh()
        {
            MainGridViev.Rows.Clear();
        }

        public void addNewLine (string[] newLine)
        {
            DataGridViewRow newRow = new DataGridViewRow();
            newRow.CreateCells(MainGridViev);
            for (int i = 0; i < newLine.Length; i++)
            {
                newRow.Cells[i].Value = newLine[i];
            }
            MainGridViev.Rows.Add(newRow);
        }

        public void changeCellsColor()
        {
            MainGridViev.AlternatingRowsDefaultCellStyle.BackColor = alternativeCellColorBackground;
            MainGridViev.DefaultCellStyle.BackColor = CellColorBackground;
        }
    }
}
