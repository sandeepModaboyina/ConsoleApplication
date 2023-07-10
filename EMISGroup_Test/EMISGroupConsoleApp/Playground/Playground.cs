using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMISGroupConsoleApp.old_code
{
    public class Playground
    {


        //linq data filteing examples  
        // var averageAge = initData.Average(x => x.Age);
        //       var MalePatients = initData.Where(x => x.Gender.Contains("Male")).ToArray();

        //string filePath = @"C:\Users\sande\Desktop\EMISGroup_Test\Data.txt";
        //try
        //{
        //    using (StreamReader sr = new StreamReader(filePath))
        //    {
        //        string line;
        //        while ((line = sr.ReadLine()) != null)
        //        {
        //            Console.WriteLine(line);
        //        }

        //    }
        //}
        //catch(Exception e)
        //{
        //    Console.WriteLine(e.Message);
        //}
        //Console.ReadKey();

        //using try catch 
        /*
         *   try
        {
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                IgnoreBlankLines = true,
                DetectDelimiter = true
            };
            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, config))
            {
                var initData = csv.GetRecords<PatientDataModel>().ToList();
                Console.WriteLine("All patients in the system");
                foreach (PatientDataModel f in initData)
                {
                    Console.WriteLine($" {f.PatientId.ToString()}\t {f.Name} \t {f.Age}\t{f.Gender}\t{f.Diagnosis}\t{f.Treatment}");

                }

                PatientManager patientManager = new EMISGroupConsoleApp.Methods.PatientManager(initData);


                var averageAge = patientManager.CalculateAverageAge();

                var MalePatients = patientManager.GetMalePatientsList();
                var getpatientsdiagnosis = patientManager.GetPatientsWithDiagnosis("Dizziness");
                var agelist = patientManager.GetPatientsByAgeRange(25, 30);
                Console.WriteLine("All male Pateients List");
                foreach (PatientDataModel f in MalePatients)
                {
                    Console.WriteLine($" {f.PatientId.ToString()}\t{f.Name} \t {f.Age}\t{f.Gender}\t{f.Diagnosis}\t{f.Treatment}");
                }
                Console.WriteLine($"AverageAge of AllPateients..");
                Console.WriteLine(averageAge);
                Console.WriteLine($"getpatientsdiagnosis ..");
                foreach (PatientDataModel f in getpatientsdiagnosis)
                {
                    Console.WriteLine($" {f.PatientId.ToString()}\t{f.Name} \t {f.Age}\t{f.Gender}\t{f.Diagnosis}\t{f.Treatment}");
                }
                Console.WriteLine($"Age  ..");
                foreach (PatientDataModel f in agelist)
                {
                    Console.WriteLine($" {f.PatientId.ToString()}\t{f.Name} \t {f.Age}\t{f.Gender}\t{f.Diagnosis}\t{f.Treatment}");
                }

              

            }

        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
         */
    }
}
