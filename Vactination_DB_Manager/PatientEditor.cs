using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vactination_DB_Manager
{
    public partial class PatientEditor : Form
    {
        private DateTime dt;
        private Patient patient;
        private PatientsContainer patientsContainer;
        private bool addNewMode = false;

        private string insertedDate;
        public PatientEditor()
        {
            InitializeComponent();
        }

        public PatientEditor(Patient patient, PatientsContainer patientsContainer)
        {
            InitializeComponent();
            this.patient = patient;
            this.patientsContainer = patientsContainer;
        }

        public PatientEditor(Patient patient, PatientsContainer patientsContainer, bool addNewMode)
        {
            InitializeComponent();
            this.patient = patient;
            this.patientsContainer = patientsContainer;
            this.addNewMode = addNewMode;
            if (addNewMode) Delete.Visible = false;
        }

        /// <summary>
        /// завантаження запису та заповнення полів вікна
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PatientEditor_Load(object sender, EventArgs e)
        {
            dt = DateTime.Now;
            insertedDate = addNewMode == false ? patient.Inserted_at.ToShortDateString() : dt.ToShortDateString();
            IdTempImmunization.Text = patient.Temp_imunization_id;
            legalEntityId.Text = patient.Legal_entity_id;
            divisionIdefluerValue.Text = patient.Division_identifier_value;
            NotGiven.Text = patient.Not_given == true ? "+" : "-";
            Status.Text = patient.Status == true ? "+" : "-";
            ageGroup.Text = patient.Patient_age_group;
            Gender.Text = patient.Patient_gender;
            VactineCode.Text = patient.Vaccine_code;
            immunizationDate.Text = patient.Imunization_date > immunizationDate.MinDate ? patient.Imunization_date.ToShortDateString() : immunizationDate.MinDate.ToString();
            manufacturer.Text = patient.Manufacturer;
            LotNumber.Text = patient.Lot_number;
            expirationDate.Text = patient.expiration_date.ToShortDateString() == "01.01.0001" ? immunizationDate.Text : 
                patient.expiration_date > expirationDate.MinDate ? expirationDate.MinDate.ToString() : patient.expiration_date.ToShortDateString();
            doseQuantityUnit.Text = patient.Dose_quantity_unit;
            doseQuantityValue.Value = patient.Dose_quantity_value != "NULL" ? decimal.Parse(patient.Dose_quantity_value.Replace(".", ",")) : new decimal(0);
            DoseSequence.Value = patient.Vaccination_protocol_dose_sequence;
            Series.Text = patient.Vaccination_protocol_series;
            seriesDoses.Value = patient.Vaccination_protocol_series_doses;
            targetDiseases.Text = patient.Vaccination_protocol_target_diseases;
            insertedAtLabel.Text = $"Запис внесено в: {insertedDate}";
            updateAtLabel.Text = $"Запис оновлено в: {dt.ToShortDateString()}";
        }


        /// <summary>
        /// збереження відредаговиних даних
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveChanges_Click(object sender, EventArgs e)
        {
            Patient patientEdited = new Patient(IdTempImmunization.Text, legalEntityId.Text,
                divisionIdefluerValue.Text, Status.Text == "+" ? true : false, NotGiven.Text == "+" ? true : false,
                VactineCode.Text, DateTime.Parse(immunizationDate.Text), ageGroup.Text, Gender.Text, manufacturer.Text, LotNumber.Text,
                expirationDate.Value, doseQuantityUnit.Text, doseQuantityValue.Value.ToString(), Decimal.ToInt32(DoseSequence.Value), Series.Text, Decimal.ToInt32(seriesDoses.Value),
                targetDiseases.Text, DateTime.Parse(insertedDate), dt);
            patientsContainer.editPatient(patient, patientEdited, addNewMode);
            this.Close();
        }

        /// <summary>
        /// видалення
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Delete_Click(object sender, EventArgs e)
        {
            Patient patientEdited = new Patient(IdTempImmunization.Text, legalEntityId.Text,
                divisionIdefluerValue.Text, Status.SelectedText == "+" ? true : false, NotGiven.SelectedText == "+" ? true : false,
                VactineCode.Text, DateTime.Parse(immunizationDate.Text), ageGroup.Text, Gender.Text, manufacturer.Text, LotNumber.Text,
                expirationDate.Value, doseQuantityUnit.Text, doseQuantityValue.Value.ToString(), Decimal.ToInt32(DoseSequence.Value), Series.Text, Decimal.ToInt32(seriesDoses.Value),
                targetDiseases.Text, DateTime.Parse(insertedDate), dt);
            patientsContainer.removePatient(patientEdited);
            this.Close();
        }
    }
}
