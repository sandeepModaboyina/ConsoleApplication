using EMISGroupConsoleApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMISGroupConsoleApp.Methods
{

    public class PatientManager
    {
        private List<PatientDataModel> patients;

        public PatientManager(List<PatientDataModel> patients)
        {
            this.patients = patients;
        }

        public decimal GetPatientsAverageAge()
        {
            decimal totalAge = 0;
            decimal patientCount = patients.Count;

            foreach (PatientDataModel patient in patients)
            {
                totalAge += patient.Age;
            }

            decimal averageAge = totalAge / patientCount;
            return averageAge;
        }
        public List<PatientDataModel> DisplayTestData()
        {
            var testData = patients.ToList();
            return testData.ToList();
        }
        public List<PatientDataModel> GetPatientsListBasedOnGender(string Gender)
        {
            var malePatients = patients.Where(x => x.Gender.Contains(Gender)).ToList();
            return malePatients;
        }
        public List<PatientDataModel> GetMalePatientsList()
        {
            var malePatients = patients.Where(x => x.Gender.Contains("Male")).ToList();
            return malePatients;
        }
        public List<PatientDataModel> GetPatientsWithDiagnosis(string Diagnosis)
        {
            var diagnosisPatients = patients.Where(x => x.Diagnosis.Contains(Diagnosis)).ToList();
            return diagnosisPatients;
        }
        public List<PatientDataModel> GetPatientsByAgeRange(int minAge, int maxAge)
        {
            var getPatientsByAgeRange = patients.Where(x => x.Age >= minAge && x.Age <= maxAge).ToList();
            return getPatientsByAgeRange;
        }
    }
}

