using Vactination_DB_Manager;


namespace UnitTests
{
    [TestClass]
    public class PatinentContainer
    {
        private PatientsContainer patientsContainer = new PatientsContainer();


        [TestMethod]
        public void AddingNewPatientOneString()
        {
            string patientData = ("\"0048f5d233159a822b69537056cf01cc\",\"4f5ccfa3-7d08-43a9-be6e-38394138fd42\",\"659f6f3b-db61-4f0b-b677-ffd62aa6cab4\",\"Запис коректний\",False,\"SarsCov2_mRNA\",\"2024-01-04\",\"56-60 р.\",\"Чоловіча\",\"BIONTECH MANUFACTURING GMBH\",\"GK0925\",\"2024-08-31\",\"ML\",0.3,\"1\",\"Бустерна доза\",\"1\",\"Коронавірусна хвороба (COVID-19)\",\"2024-01-04\",\"2024-01-04\"");
            Patient patient = new Patient(patientData);
            patientsContainer.addPatient(patient);
            Assert.AreEqual(patient.getMass(false).ToString(), patientsContainer.getOnePatient(0, false).ToString());
        }

        [TestMethod]
        public void AddingNewPatientByAgrs()
        {
            Patient patient = new Patient("002698fa7ba151aeb8f37c64679737d0", "e3df7fff-a3a1-44f1-bc76-7a601ce3380a", "db1a4c1f-0503-4286-bd08-ad1eefcd9b1b", true, false, "SarsCov2_mRNA", new DateTime(2024, 01, 11), "41-45 р.", "Жіноча", "BIONTECH MANUFACTURING GMBH", "GA2988", new DateTime(2024, 02, 29), "ML", "0.3", 2, "Вакцинація", 2, "Коронавірусна хвороба (COVID-19)", new DateTime(2024, 01, 11), new DateTime(2024, 01, 11));
            patientsContainer.addPatient(patient);
            Assert.AreEqual(patient.getMass(false).ToString(), patientsContainer.getOnePatient(0, false).ToString());
        }

        [TestMethod]
        public void ClearPatients()
        {
            Patient patient = new Patient("002698fa7ba151aeb8f37c64679737d0", "e3df7fff-a3a1-44f1-bc76-7a601ce3380a", "db1a4c1f-0503-4286-bd08-ad1eefcd9b1b", true, false, "SarsCov2_mRNA", new DateTime(2024, 01, 11), "41-45 р.", "Жіноча", "BIONTECH MANUFACTURING GMBH", "GA2988", new DateTime(2024, 02, 29), "ML", "0.3", 2, "Вакцинація", 2, "Коронавірусна хвороба (COVID-19)", new DateTime(2024, 01, 11), new DateTime(2024, 01, 11));
            patientsContainer.addPatient(patient);
            patientsContainer.clearPatients();
            Assert.AreEqual("Error file haven`t than line", patientsContainer.getOnePatient(0, false)[0]);
        }

        [TestMethod]
        public void RemovePatients()
        {
            Patient patient = new Patient("002698fa7ba151aeb8f37c64679737d0", "e3df7fff-a3a1-44f1-bc76-7a601ce3380a", "db1a4c1f-0503-4286-bd08-ad1eefcd9b1b", true, false, "SarsCov2_mRNA", new DateTime(2024, 01, 11), "41-45 р.", "Жіноча", "BIONTECH MANUFACTURING GMBH", "GA2988", new DateTime(2024, 02, 29), "ML", "0.3", 2, "Вакцинація", 2, "Коронавірусна хвороба (COVID-19)", new DateTime(2024, 01, 11), new DateTime(2024, 01, 11));
            patientsContainer.addPatient(patient);
            patientsContainer.removePatient(patient);
            Assert.AreEqual("Error file haven`t than line", patientsContainer.getOnePatient(0, false)[0]);
        }

        [TestMethod]
        public void EditPatients()
        {
            Patient patient = new Patient("002698fa7ba151aeb8f37c64679737d0", "e3df7fff-a3a1-44f1-bc76-7a601ce3380a", "db1a4c1f-0503-4286-bd08-ad1eefcd9b1b", true, false, "SarsCov2_mRNA", new DateTime(2024, 01, 11), "41-45 р.", "Жіноча", "BIONTECH MANUFACTURING GMBH", "GA2988", new DateTime(2024, 02, 29), "ML", "0.3", 2, "Вакцинація", 2, "Коронавірусна хвороба (COVID-19)", new DateTime(2024, 01, 11), new DateTime(2024, 01, 11));
            patientsContainer.addPatient(patient);
            Patient patientedited = new Patient("TEST ID", "TEST ID", "TEST ID", true, false, "SarsCov2_mRNA", new DateTime(2022, 02, 10), "96+ р.", "Чоловіча", "PFIZER", "GA29", new DateTime(2022, 03, 11), "ML", "0.5", 3, "Бустер", 5, "Коронавірусна хвороба (COVID-19)", new DateTime(2022, 02, 12), new DateTime(2022, 02, 12));
            patientsContainer.editPatient(patient, patientedited, false);
            Assert.AreEqual(patientedited.getMass(false).ToString(), patientsContainer.getOnePatient(0, false).ToString());
        }

        [TestMethod]
        public void EditPatientsAdding()
        {
            Patient patient = new Patient("002698fa7ba151aeb8f37c64679737d0", "e3df7fff-a3a1-44f1-bc76-7a601ce3380a", "db1a4c1f-0503-4286-bd08-ad1eefcd9b1b", true, false, "SarsCov2_mRNA", new DateTime(2024, 01, 11), "41-45 р.", "Жіноча", "BIONTECH MANUFACTURING GMBH", "GA2988", new DateTime(2024, 02, 29), "ML", "0.3", 2, "Вакцинація", 2, "Коронавірусна хвороба (COVID-19)", new DateTime(2024, 01, 11), new DateTime(2024, 01, 11));
            patientsContainer.addPatient(patient);
            Patient patientedited = new Patient("TEST ID", "TEST ID", "TEST ID", true, false, "SarsCov2_mRNA", new DateTime(2022, 02, 10), "96+ р.", "Чоловіча", "PFIZER", "GA29", new DateTime(2022, 03, 11), "ML", "0.5", 3, "Бустер", 5, "Коронавірусна хвороба (COVID-19)", new DateTime(2022, 02, 12), new DateTime(2022, 02, 12));
            patientsContainer.editPatient(patient, patientedited, true);
            Assert.AreEqual(2, patientsContainer.PatientsList.Count);
        }

        [TestMethod]
        public void Sorting()
        {
            patientsContainer.addPatient(new Patient("002698fa7ba151aeb8f37c64679737d0", "e3df7fff-a3a1-44f1-bc76-7a601ce3380a", "db1a4c1f-0503-4286-bd08-ad1eefcd9b1b", true, false, "SarsCov2_mRNA", new DateTime(2024, 01, 11), "41-45 р.", "Жіноча", "BIONTECH MANUFACTURING GMBH", "GA2988", new DateTime(2024, 02, 29), "ML", "0.3", 2, "Вакцинація", 2, "Коронавірусна хвороба (COVID-19)", new DateTime(2024, 01, 11), new DateTime(2024, 01, 11)));
            patientsContainer.addPatient(new Patient("\"003dbdc6f2df930dbe68df290cba2bad\", \"e3517484-7e39-4554-b800-d419307cc7a8\", \"27d0275d-7f82-43de-b2e2-0c189c9f5287\", \"Запис коректний\", False, \"SarsCov2_mRNA\", \"2024-02-06\", \"26-30 р.\", \"Чоловіча\", \"BIONTECH MANUFACTURING GMBH\", \"GA2988\", \"2024-02-29\", \"ML\", 0.3, \"2\", \"вакцинація\", \"2\", \"Коронавірусна хвороба (COVID-19)\", \"2024-02-16\", \"2024-02-16\""));

            patientsContainer.SortByArg(7, false);
            Assert.AreEqual(" \"26-30 р.\"", patientsContainer.getOnePatient(0, false)[7]);
        }

        [TestMethod]
        public void SortingReverse()
        {
            patientsContainer.addPatient(new Patient("002698fa7ba151aeb8f37c64679737d0", "e3df7fff-a3a1-44f1-bc76-7a601ce3380a", "db1a4c1f-0503-4286-bd08-ad1eefcd9b1b", true, false, "SarsCov2_mRNA", new DateTime(2024, 01, 11), "41-45 р.", "Жіноча", "BIONTECH MANUFACTURING GMBH", "GA2988", new DateTime(2024, 02, 29), "ML", "0.3", 2, "Вакцинація", 2, "Коронавірусна хвороба (COVID-19)", new DateTime(2024, 01, 11), new DateTime(2024, 01, 11)));
            patientsContainer.addPatient(new Patient("\"003dbdc6f2df930dbe68df290cba2bad\", \"e3517484-7e39-4554-b800-d419307cc7a8\", \"27d0275d-7f82-43de-b2e2-0c189c9f5287\", \"Запис коректний\", False, \"SarsCov2_mRNA\", \"2024-02-06\", \"26-30 р.\", \"Чоловіча\", \"BIONTECH MANUFACTURING GMBH\", \"GA2988\", \"2024-02-29\", \"ML\", 0.3, \"2\", \"вакцинація\", \"2\", \"Коронавірусна хвороба (COVID-19)\", \"2024-02-16\", \"2024-02-16\""));

            patientsContainer.SortByArg(19, true);
            Assert.AreEqual("\"2024-02-16\"", patientsContainer.getOnePatient(0, false)[19]);
        }

        [TestMethod]
        public void Searching()
        {
            patientsContainer.addPatient(new Patient("002698fa7ba151aeb8f37c64679737d0", "e3df7fff-a3a1-44f1-bc76-7a601ce3380a", "db1a4c1f-0503-4286-bd08-ad1eefcd9b1b", true, false, "SarsCov2_mRNA", new DateTime(2024, 01, 11), "41-45 р.", "Жіноча", "BIONTECH MANUFACTURING GMBH", "GA2988", new DateTime(2024, 02, 29), "ML", "0.3", 2, "Вакцинація", 2, "Коронавірусна хвороба (COVID-19)", new DateTime(2024, 01, 11), new DateTime(2024, 01, 11)));
            patientsContainer.addPatient(new Patient("\"003dbdc6f2df930dbe68df290cba2bad\", \"e3517484-7e39-4554-b800-d419307cc7a8\", \"27d0275d-7f82-43de-b2e2-0c189c9f5287\", \"Запис коректний\", False, \"SarsCov2_mRNA\", \"2024-02-06\", \"26-30 р.\", \"Чоловіча\", \"BIONTECH MANUFACTURING GMBH\", \"GA2988\", \"2024-02-29\", \"ML\", 0.3, \"2\", \"вакцинація\", \"2\", \"Коронавірусна хвороба (COVID-19)\", \"2024-02-16\", \"2024-02-16\""));

            patientsContainer.searchPatients("жін");
            Assert.AreEqual(1, patientsContainer.SearchedPatientsList.Count);
        }
    }
    [TestClass]
    public class PatinentClass
    {
        [TestMethod]
        public void Adding()
        {
            Patient patient = new Patient("\"003dbdc6f2df930dbe68df290cba2bad\", \"e3517484-7e39-4554-b800-d419307cc7a8\", \"27d0275d-7f82-43de-b2e2-0c189c9f5287\", \"Запис коректний\", False, \"SarsCov2_mRNA\", \"2024-02-06\", \"26-30 р.\", \"Чоловіча\", \"BIONTECH MANUFACTURING GMBH\", \"GA2988\", \"2024-02-29\", \"ML\", 0.3, \"2\", \"вакцинація\", \"2\", \"Коронавірусна хвороба (COVID-19)\", \"2024-02-16\", \"2024-02-16\"");
            Assert.AreEqual(false, patient.Status);
            Assert.AreEqual("\"003dbdc6f2df930dbe68df290cba2bad\"", patient.Temp_imunization_id);
        }
    }
}