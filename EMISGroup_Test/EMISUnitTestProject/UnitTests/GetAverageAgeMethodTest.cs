using EMISGroupConsoleApp.Methods;
using EMISGroupConsoleApp.Model;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMISUnitTestProject.UnitTests
{
    [TestClass]
    public class GetAverageAgeMethodTest
    {
        [TestMethod]
        public void Valid_GetAverageAge() { 
        List<PatientDataModel> TestData = new List<PatientDataModel>
            {
                new PatientDataModel { PatientId = 1, Name = "John Doe", Age = 10, Gender = "Male", Diagnosis = "Fever", Treatment = "Treatment1" },
                new PatientDataModel { PatientId = 2, Name = "Jane Smith", Age = 10, Gender = "Female", Diagnosis = "Headache", Treatment = "Treatment1" },
                new PatientDataModel { PatientId = 3, Name = "Mike Johnson", Age = 10, Gender = "Male", Diagnosis = "Flu", Treatment = "Treatment1" },
                new PatientDataModel { PatientId = 4, Name = "Sarah Thompson", Age = 10, Gender = "Female", Diagnosis = "Headache", Treatment = "Treatment1" },
            };
            PatientManager patient = new PatientManager(TestData);
            var average = patient.GetPatientsAverageAge();
            //Assert
            average.Should().Be(10);
        }
        [TestMethod]
        public void ZeroValue_GetAverageAge()
        {
            List<PatientDataModel> TestData = new List<PatientDataModel>
            {
                new PatientDataModel { PatientId = 1, Name = "John Doe", Age = 0, Gender = "Male", Diagnosis = "Fever", Treatment = "Treatment1" },
                new PatientDataModel { PatientId = 2, Name = "Jane Smith", Age = 0, Gender = "Female", Diagnosis = "Headache", Treatment = "Treatment1" },
                new PatientDataModel { PatientId = 3, Name = "Mike Johnson", Age = 0, Gender = "Male", Diagnosis = "Flu", Treatment = "Treatment1" },
                new PatientDataModel { PatientId = 4, Name = "Sarah Thompson", Age = 0, Gender = "Female", Diagnosis = "Headache", Treatment = "Treatment1" },
            };
            PatientManager patient = new PatientManager(TestData);
            var average = patient.GetPatientsAverageAge();
            //Assert
            average.Should().Be(0);
        }
    }
}
