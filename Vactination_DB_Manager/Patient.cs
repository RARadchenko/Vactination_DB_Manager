using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Vactination_DB_Manager
{
    public class Patient
    {
        public string Temp_imunization_id { get; set; } = "";
        public string Legal_entity_id { get; set; } = "";
        public string Division_identifier_value { get; set; } = "";
        public bool Status { get; set; } = false;
        public bool Not_given { get; set; } = false;
        public string Vaccine_code { get; set; } = "";
        public DateTime Imunization_date { get; set; }
        public string Patient_age_group { get; set; } = "";
        public string Patient_gender { get; set; } = "";
        public string Manufacturer { get; set; } = "";
        public string Lot_number { get; set; } = "";
        public DateTime expiration_date { get; set; }
        public string Dose_quantity_unit { get; set; } = "0.0";
        public string Dose_quantity_value { get; set; } = "0.0";
        public int Vaccination_protocol_dose_sequence { get; set; } = 0;
        public string Vaccination_protocol_series { get; set; } = "";
        public int Vaccination_protocol_series_doses { get; set; } = 0;
        public string Vaccination_protocol_target_diseases { get; set; } = "";
        public DateTime Inserted_at { get; set; }
        public DateTime updated_at { get; set; }

        public Patient()
        { }
        public Patient(string temp_imunization_id, string legal_entity_id, string division_identifier_value, bool status, bool not_given, string vaccine_code, DateTime imunization_date, string patient_age_group, string patient_gender, string manufacturer, string lot_number, DateTime expiration_date, string dose_quantity_unit, string dose_quantity_value, int vaccination_protocol_dose_sequence, string vaccination_protocol_series, int vaccination_protocol_series_doses, string vaccination_protocol_target_diseases, DateTime inserted_at, DateTime updated_at)
        {
            Temp_imunization_id = temp_imunization_id;
            Legal_entity_id = legal_entity_id;
            Division_identifier_value = division_identifier_value;
            Status = status;
            Not_given = not_given;
            Vaccine_code = vaccine_code;
            Imunization_date = imunization_date;
            Patient_age_group = patient_age_group;
            Patient_gender = patient_gender;
            Manufacturer = manufacturer;
            Lot_number = lot_number;
            this.expiration_date = expiration_date;
            Dose_quantity_unit = dose_quantity_unit;
            Dose_quantity_value = dose_quantity_value;
            Vaccination_protocol_dose_sequence = vaccination_protocol_dose_sequence;
            Vaccination_protocol_series = vaccination_protocol_series;
            Vaccination_protocol_series_doses = vaccination_protocol_series_doses;
            Vaccination_protocol_target_diseases = vaccination_protocol_target_diseases;
            Inserted_at = inserted_at;
            this.updated_at = updated_at;
        }
        public Patient(string OneLine)
        {
            string pattern = @",(?=(?:[^\""]*\""[^\""]*\"")*(?![^\""]*\""))";
            string[] parts = Regex.Split(OneLine, pattern);
            int parsing;
            //string[] parts = OneLine.Replace("\"", "").Split(',');

            if (parts.Length < 20) return;

            Temp_imunization_id = parts[0];
            Legal_entity_id = parts[1];
            Division_identifier_value = parts[2];
            Status = parts[3] == "\"Запис коректний\"" ? true : false;
            Not_given = parts[4] == "True" ? true : false;
            Vaccine_code = parts[5];
            Imunization_date = strTodate(parts[6]);
            Patient_age_group = parts[7];
            Patient_gender = parts[8];
            Manufacturer = parts[9];
            Lot_number = parts[10];
            expiration_date = strTodate(parts[11]);
            Dose_quantity_unit = parts[12];
            Dose_quantity_value = parts[13];
            Vaccination_protocol_dose_sequence = int.Parse(parts[14].Replace("\"", ""));
            Vaccination_protocol_series = parts[15];
            
            int.TryParse(parts[16].Replace("\"", ""),out parsing);
            Vaccination_protocol_series_doses = parsing;
            Vaccination_protocol_target_diseases = parts[17];
            Inserted_at = strTodate(parts[18]);
            updated_at = strTodate(parts[19]);
        }

        private DateTime strTodate(string date)
        {
            DateTime dateout;
            string pattern = @"(\d{4})-(\d{2})-(\d{2})";
            Match match = Regex.Match(date, pattern);
            if (match.Success)
            {
                dateout = new DateTime(int.Parse(match.Groups[1].Value), int.Parse(match.Groups[2].Value), int.Parse(match.Groups[3].Value));
            }
            else
            {
                dateout = new DateTime();
            }
                return dateout;
        }

        public override string ToString()
        {
            return $"{Temp_imunization_id}{Legal_entity_id}{Division_identifier_value}{Status}{Not_given}" +
                $"{Vaccine_code}{Imunization_date}{Patient_age_group}{Patient_gender}{Manufacturer}{Lot_number}" +
                $"{expiration_date}{Dose_quantity_unit}{Dose_quantity_value}{Vaccination_protocol_dose_sequence}" +
                $"{Vaccination_protocol_series}{Vaccination_protocol_series_doses}{Vaccination_protocol_target_diseases}" +
                $"{Inserted_at}{updated_at}";
        }
        public string[] getMass(bool change)
        {
            if (change)
            {
                return new string[] { Temp_imunization_id, Legal_entity_id, Division_identifier_value,
                Status? "+" : "-", Not_given? "+" : "-", Vaccine_code, Imunization_date.ToShortDateString(),
                Patient_age_group, Patient_gender, Manufacturer,Lot_number,
                expiration_date.ToShortDateString(),Dose_quantity_unit,Dose_quantity_value,Vaccination_protocol_dose_sequence.ToString(),
                Vaccination_protocol_series, Vaccination_protocol_series_doses.ToString(), Vaccination_protocol_target_diseases,
            Inserted_at.ToShortDateString(), updated_at.ToShortDateString()};
            }
            return new string[] { Temp_imunization_id, Legal_entity_id, Division_identifier_value,
                Status? "\"Запис коректний\"" : "\"Запис внесено помилково\"", Not_given? "True" : "False", Vaccine_code, Imunization_date.ToShortDateString(),
                Patient_age_group, Patient_gender, Manufacturer,Lot_number,
                expiration_date.ToShortDateString(),Dose_quantity_unit,Dose_quantity_value,Vaccination_protocol_dose_sequence.ToString(),
                Vaccination_protocol_series, Vaccination_protocol_series_doses.ToString(), Vaccination_protocol_target_diseases,
            Inserted_at.ToShortDateString(), updated_at.ToShortDateString()};
        }
    }
}
