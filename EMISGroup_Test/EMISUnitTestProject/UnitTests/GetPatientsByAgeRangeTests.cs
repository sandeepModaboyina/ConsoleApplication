using EMISGroupConsoleApp.Methods;
using EMISGroupConsoleApp.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;

namespace EMISGroupConsoleApp.UnitTests
{
    [TestClass]
    public class GetPatientsByAgeRangeTests
    {
        [TestMethod]
        public void Valid_MinAndMaxValues_ReturnsNoData()
        {
            //Arrange 
            int minAge = 10;
            int maxAge = 20;
            List<PatientDataModel> TestData = new List<PatientDataModel>
            {
                new PatientDataModel { PatientId = 1, Name = "John Doe", Age = 25, Gender = "Male", Diagnosis = "Fever", Treatment = "Treatment1" },
                new PatientDataModel { PatientId = 2, Name = "Jane Smith", Age = 30, Gender = "Female", Diagnosis = "Headache", Treatment = "Treatment1" },
                new PatientDataModel { PatientId = 3, Name = "Mike Johnson", Age = 40, Gender = "Male", Diagnosis = "Flu", Treatment = "Treatment1" },
                new PatientDataModel { PatientId = 4, Name = "Sarah Thompson", Age = 35, Gender = "Female", Diagnosis = "Headache", Treatment = "Treatment1" },
            };
            PatientManager patient = new PatientManager(TestData);
            //Act
            var ValidData = patient.GetPatientsByAgeRange(minAge, maxAge);
            //Assert
            ValidData.Should().BeNullOrEmpty()
                .And.HaveCount(0);
        }

        [TestMethod]
        public void Valid_MinAndMaxValues_GetsData()
        {
            //Arrange 
            int minAge = 25;
            int maxAge = 40;
            List<PatientDataModel> TestData = new List<PatientDataModel>
            {
            new PatientDataModel { PatientId = 1, Name = "John Doe", Age = 25, Gender = "Male", Diagnosis = "Fever", Treatment = "Treatment1" },
            new PatientDataModel { PatientId = 2, Name = "Jane Smith", Age = 30, Gender = "Female", Diagnosis = "Headache",Treatment = "Treatment2" },
            new PatientDataModel { PatientId = 3, Name = "Mike Johnson", Age = 40, Gender = "Male", Diagnosis = "Flu",Treatment = "Treatment3" },
            };
            PatientManager patient = new PatientManager(TestData);
            //Act
            var ValidData = patient.GetPatientsByAgeRange(minAge, maxAge);
            //Assert
            ValidData.Should().NotBeNullOrEmpty()
                .And.HaveCount(3)
                .And.Equal(TestData);
        }
       // [TestMethod]
        //public void InValid_MinAndMaxValues_NoDataReturned()
        //{
        //    //Arrange 
        //    int minAge = 20;
        //    int maxAge = 40;
        //    List<PatientDataModel> TestData = new List<PatientDataModel>
        //    {
        //    new PatientDataModel { PatientId = 1, Name = "John Doe", Age = 25.50, Gender = "Male", Diagnosis = "Fever", Treatment = "Treatment1" },
        //    new PatientDataModel { PatientId = 2, Name = "Jane Smith", Age = 30.50, Gender = "Female", Diagnosis = "Headache",Treatment = "Treatment2" },
        //    new PatientDataModel { PatientId = 3, Name = "Mike Johnson", Age = 40.50, Gender = "Male", Diagnosis = "Flu",Treatment = "Treatment3" },
        //    };
        //    PatientManager patient = new PatientManager(TestData);
        //    //Act
        //    var ValidData = patient.GetPatientsByAgeRange(minAge, maxAge);
        //    //Assert
        //    ValidData.Should().BeNullOrEmpty()
        //        .And.HaveCount(0);

        //}
    }
}
