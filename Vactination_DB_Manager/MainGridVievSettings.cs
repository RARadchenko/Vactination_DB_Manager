﻿using System;
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
        private string chosen_lang = "ua";

        public string[] en_lang_mask = { };
        public string[] ua_lang_mask = { };

        public static bool[] VisibleColums = { 
            //"temp_immunization_id","legal_entity_id","division_identifier_value","status","not_given"
            true, true, true, true, true, 
            //"vaccine_code","immunization_date","patient_age_group","patient_gender","manufacturer",
            true, true, true, true, true,
            //"lot_number","expiration_date","dose_quantity_unit","dose_quantity_value","vaccination_protocol_dose_sequence",
            true, true, true, true, true,
            //"vaccination_protocol_series","vaccination_protocol_series_doses","vaccination_protocol_target_diseases","inserted_at","updated_at"
            true, true, true, true, true
        };
        public static int q_of_patients_on_page { get; set; } = 40;
        public static Color alternativeCellColorBackground { get; set; } = Color.WhiteSmoke;
        public static Color CellColorBackground { get; set; } = Color.White;
        public static Font GridViewFont { get; set; } = new Font("Microsoft Sans Serif", 8F);

        /// <summary>
        /// завантаження мовних масок для стовбців
        /// </summary>
        private void readLangsMasks()
        {
            ResourceManager resourceManager = new ResourceManager("Vactination_DB_Manager.GridViewLangMasks", typeof(MainGridVievSettings).Assembly);

            // Зчитування масок з файлу ресурсів
            en_lang_mask = resourceManager.GetString("EN_lang_grid_mask").Replace(Environment.NewLine, "").Split(',');
            ua_lang_mask = resourceManager.GetString("UA_lang_grid_mask").Replace(Environment.NewLine, "").Split(',');
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

        /// <summary>
        /// початкові налаштування
        /// </summary>
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

            MainGridViev.ColumnCount = mask.Length;
            for (int i = 0; i < mask.Length; i++)
            {
                MainGridViev.Columns[i].HeaderText = mask[i];
            }
        }

        /// <summary>
        /// оновлення таблиці
        /// </summary>
        public void refresh()
        {
            MainGridViev.Rows.Clear();
        }

        /// <summary>
        /// додавання нового рядку
        /// </summary>
        /// <param name="newLine"></param>
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

        /// <summary>
        /// зміна кольору
        /// </summary>
        public void changeCellsColor()
        {
            MainGridViev.AlternatingRowsDefaultCellStyle.BackColor = alternativeCellColorBackground;
            MainGridViev.DefaultCellStyle.BackColor = CellColorBackground;
        }
        /// <summary>
        /// зміна шрифтів
        /// </summary>
        public void changeFontStyle()
        {
            MainGridViev.DefaultCellStyle.Font = GridViewFont;
        }

        /// <summary>
        /// відображення стовбців
        /// </summary>
        public void changeColums()
        {
            for(int i = 0; i < MainGridViev.Columns.Count; i++)
            {
                MainGridViev.Columns[i].Visible = VisibleColums[i];
            }
        }
    }
}
