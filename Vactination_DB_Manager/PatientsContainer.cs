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
        public void removePatient(Patient patient)
        {
            PatientsList.Remove(patient); 
        }
        public void clearPatients()
        {
            PatientsList.Clear();
        }
        public string[] getOnePatient(int index)
        {
            if (index < PatientsList.Count) return PatientsList[index].getMass();
            else return new string[] { "Error file haven`t than line" };
        }
    }
}
