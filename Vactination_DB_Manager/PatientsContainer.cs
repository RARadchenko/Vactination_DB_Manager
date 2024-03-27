using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vactination_DB_Manager
{
    internal class PatientsContainer
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
    }
}
