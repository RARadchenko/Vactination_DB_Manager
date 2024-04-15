using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vactination_DB_Manager
{
    public class PatientsContainer
    {
        public List<Patient> PatientsList { get; set; }

        public PatientsContainer(List<Patient> patientsList)
        {
            PatientsList = patientsList;
        }
        public PatientsContainer()
        {
            PatientsList = new List<Patient>();
        }
        public void addPatient(Patient patient)
        {
            PatientsList.Add(patient);
        }
        public void removePatient(Patient patient)
        {
            PatientsList.Remove(patient); 
        }
        public void editPatient(Patient patientOld, Patient patientNew, bool addNewMode)
        {
            Patient patientEdit = PatientsList.Find(p => p.Temp_imunization_id==patientOld.Temp_imunization_id);
            if (patientEdit != null && addNewMode != true)
            {
                patientEdit.Temp_imunization_id = patientNew.Temp_imunization_id;
                patientEdit.Legal_entity_id = patientNew.Legal_entity_id;
                patientEdit.Division_identifier_value = patientNew.Division_identifier_value;
                patientEdit.Status = patientNew.Status;
                patientEdit.Not_given = patientNew.Not_given;
                patientEdit.Vaccine_code = patientNew.Vaccine_code;
                patientEdit.Imunization_date = patientNew.Imunization_date;
                patientEdit.Patient_age_group = patientNew.Patient_age_group;
                patientEdit.Patient_gender = patientNew.Patient_gender;
                patientEdit.Manufacturer = patientNew.Manufacturer;
                patientEdit.Lot_number = patientNew.Lot_number;
                patientEdit.expiration_date = patientNew.expiration_date;
                patientEdit.Dose_quantity_unit = patientNew.Dose_quantity_unit;
                patientEdit.Dose_quantity_value = patientNew.Dose_quantity_value;
                patientEdit.Vaccination_protocol_dose_sequence = patientNew.Vaccination_protocol_dose_sequence;
                patientEdit.Vaccination_protocol_series = patientNew.Vaccination_protocol_series;
                patientEdit.Vaccination_protocol_series_doses = patientNew.Vaccination_protocol_series_doses;
                patientEdit.Vaccination_protocol_target_diseases = patientNew.Vaccination_protocol_target_diseases;
                patientEdit.Inserted_at = patientNew.Inserted_at;
                patientEdit.updated_at = patientNew.updated_at;
            }
            else if(addNewMode == true)
            {
                addPatient(patientNew);
            }
        }
        public void clearPatients()
        {
            PatientsList.Clear();
        }
        public void reversePatients()
        {
            PatientsList.Reverse();
        }
        public void SortByArg(int Field, bool reversed = false)
        {
            switch (Field)
            {
                case 0:
                    PatientsList = PatientsList.OrderBy(p => p.Temp_imunization_id).ToList();
                    break;
                case 1:
                    PatientsList = PatientsList.OrderBy(p => p.Legal_entity_id).ToList();
                    break;
                case 2:
                    PatientsList = PatientsList.OrderBy(p => p.Division_identifier_value).ToList();
                    break;
                case 3:
                    PatientsList = PatientsList.OrderBy(p => p.Status).ToList();
                    break;
                case 4:
                    PatientsList = PatientsList.OrderBy(p => p.Not_given).ToList();
                    break;
                case 5:
                    PatientsList = PatientsList.OrderBy(p => p.Vaccine_code).ToList();
                    break;
                case 6:
                    PatientsList = PatientsList.OrderBy(p => p.Imunization_date).ToList();
                    break;
                case 7:
                    PatientsList = PatientsList.OrderBy(p => p.Patient_age_group).ToList();
                    break;
                case 8:
                    PatientsList = PatientsList.OrderBy(p => p.Patient_gender).ToList();
                    break;
                case 9:
                    PatientsList = PatientsList.OrderBy(p => p.Manufacturer).ToList();
                    break;
                case 10:
                    PatientsList = PatientsList.OrderBy(p => p.Lot_number).ToList();
                    break;
                case 11:
                    PatientsList = PatientsList.OrderBy(p => p.expiration_date).ToList();
                    break;
                case 12:
                    PatientsList = PatientsList.OrderBy(p => p.Dose_quantity_unit).ToList();
                    break;
                case 13:
                    PatientsList = PatientsList.OrderBy(p => p.Dose_quantity_value).ToList();
                    break;
                case 14:
                    PatientsList = PatientsList.OrderBy(p => p.Vaccination_protocol_dose_sequence).ToList();
                    break;
                case 15:
                    PatientsList = PatientsList.OrderBy(p => p.Vaccination_protocol_series).ToList();
                    break;
                case 16:
                    PatientsList = PatientsList.OrderBy(p => p.Vaccination_protocol_series_doses).ToList();
                    break;
                case 17:
                    PatientsList = PatientsList.OrderBy(p => p.Vaccination_protocol_target_diseases).ToList();
                    break;
                case 18:
                    PatientsList = PatientsList.OrderBy(p => p.Inserted_at).ToList();
                    break;
                case 19:
                    PatientsList = PatientsList.OrderBy(p => p.updated_at).ToList();
                    break;
                default:
                    break;
            }
            if (reversed)
            {
                PatientsList.Reverse();
            }
        }
        public string[] getOnePatient(int index)
        {
            if (index < PatientsList.Count) return PatientsList[index].getMass();
            else return new string[] { "Error file haven`t than line" };
        }
    }
}
