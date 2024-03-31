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
        private Patient patient;
        public PatientEditor()
        {
            InitializeComponent();
        }

        public PatientEditor(Patient patient)
        {
            InitializeComponent();
            this.patient = patient;
        }

        private void PatientEditor_Load(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            IdTempImmunization.Text = patient.Temp_imunization_id;
            legalEntityId.Text = patient.Legal_entity_id;
            divisionIdefluerValue.Text = patient.Division_identifier_value;
            NotGiven.Text = patient.Not_given == true ? "+" : "-";
            Status.Text = patient.Status == true ? "+" : "-";
            ageGroup.Text = patient.Patient_age_group;
            Gender.Text = patient.Patient_gender;
            VactineCode.Text = patient.Vaccine_code;
            immunizationDate.Text = patient.Imunization_date.ToShortDateString();

            updateAtLabel.Text = $"Запис оновлено в: {dt.ToShortDateString()}";
        }
    }
}
