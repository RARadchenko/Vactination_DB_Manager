using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Vactination_DB_Manager
{
    public class MainGridVievSettings
    {
        private System.Windows.Forms.DataGridView MainGridViev;
        private string chosen_lang = "en";

        private string[] en_lang_mask = { 
            "temp_immunization_id",
            "legal_entity_id",
            "division_identifier_value",
            "status",
            "not_given",
            "vaccine_code",
            "immunization_date",
            "patient_age_group",
            "patient_gender",
            "manufacturer",
            "lot_number",
            "expiration_date",
            "dose_quantity_unit",
            "dose_quantity_value",
            "vaccination_protocol_dose_sequence",
            "vaccination_protocol_series",
            "vaccination_protocol_series_doses",
            "vaccination_protocol_target_diseases",
            "inserted_at",
            "updated_at"
        };
        private string[] other_lang_mask = { };

        public MainGridVievSettings(System.Windows.Forms.DataGridView MainGridViev, string lang) 
        { 
            this.MainGridViev = MainGridViev;
            chosen_lang = lang;
        }

        public MainGridVievSettings(System.Windows.Forms.DataGridView MainGridViev)
        {
            this.MainGridViev = MainGridViev;
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
                mask = other_lang_mask;
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

        public void addNewLine (string[] newLine)
        {

            // Проходим по каждому элементу массива и устанавливаем его в соответствующей колонке нового ряда
            DataGridViewRow newRow = new DataGridViewRow();
            newRow.CreateCells(MainGridViev);
            for (int i = 0; i < newLine.Length; i++)
            {
                newRow.Cells[i].Value = newLine[i];
            }

            // Добавляем новый ряд в DataGridView
            MainGridViev.Rows.Add(newRow);
        }
    }
}
