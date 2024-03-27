using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Vactination_DB_Manager
{
    internal class Patient
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
        public string Dose_quantity_unit { get; set; } = "";
        public string Dose_quantity_value { get; set; } = "";
        public int Vaccination_protocol_dose_sequence { get; set; } = 0;
        public string Vaccination_protocol_series { get; set; } = "";
        public int Vaccination_protocol_series_doses { get; set; } = 0;
        public string Vaccination_protocol_target_diseases { get; set; } = "";
        public DateTime Inserted_at { get; set; }
        public DateTime updated_at { get; set; }

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
            string pattern = @"([^"",]+)";
            MatchCollection match = Regex.Matches(OneLine, pattern);
            
            Temp_imunization_id = match[0].Groups[1].Value;
            Legal_entity_id = match[1].Groups[1].Value;
            Division_identifier_value = match[2].Groups[1].Value;
            Status = match[3].Groups[1].Value == "Запис коректний" ? true : false;
            Not_given = match[4].Groups[1].Value == "True" ? true : false;
            Vaccine_code = match[5].Groups[1].Value;
            Imunization_date = strTodate(match[6].Groups[1].Value);
            Patient_age_group = match[7].Groups[1].Value;
            Patient_gender = match[8].Groups[1].Value;
            Manufacturer = match[9].Groups[1].Value;
            Lot_number = match[10].Groups[1].Value;
            expiration_date = strTodate(match[11].Groups[1].Value);
            Dose_quantity_unit = match[12].Groups[1].Value;
            Dose_quantity_value = match[13].Groups[1].Value;
            Vaccination_protocol_dose_sequence = int.Parse(match[14].Groups[1].Value);
            Vaccination_protocol_series = match[15].Groups[1].Value;
            Vaccination_protocol_series_doses = int.Parse(match[16].Groups[1].Value);
            Vaccination_protocol_target_diseases = match[17].Groups[1].Value;
            Inserted_at = strTodate(match[18].Groups[1].Value);
            updated_at = strTodate(match[19].Groups[1].Value);
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
    }
}
