// See https://aka.ms/new-console-template for more information
using CsvHelper;
using CsvHelper.Configuration;
using EMISGroupConsoleApp.Methods;
using EMISGroupConsoleApp.Model;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the EMIS Patient test console App!");
        Console.WriteLine("Enter the file path...: ");
        string filePath = Console.ReadLine();
            
            if (File.Exists(filePath))
            {
                Console.WriteLine("Valid File, The test data is : ");
            while (true)
            {
                CsvHelperClass csvHelperClass = new CsvHelperClass();
                var initData = csvHelperClass.TextFileParser(filePath);
                PatientManager patientManager = new PatientManager(initData);
                Console.WriteLine("\nPlease select an operation:");
                Console.WriteLine("1. Retrieve All PatientData");
                Console.WriteLine("2. GetAverageAge");
                Console.WriteLine("3. GetMalePatients");
                Console.WriteLine("4. GetPatientsWithDiagnosis(string diagnosis)");
                Console.WriteLine("5. GetPatientsByAgeRange(int minAge, int maxAge)");
                Console.WriteLine("6. Exit");
                string choice = Console.ReadLine();
                if (choice == "6")
                {
                    Console.WriteLine("Thank you for using the EMIS Test App!");
                    break;
                }
                if (choice == "1")
                {
                    foreach (PatientDataModel f in initData)
                    {
                        Console.WriteLine($" {f.PatientId.ToString()}\t {f.Name} \t {f.Age}\t{f.Gender}\t{f.Diagnosis}\t{f.Treatment}");

                    }
                }
                else if (choice == "2")
                {
                    var averageAge = patientManager.GetPatientsAverageAge();
                    Console.WriteLine($"Average age of patients based on Test Data");
                    Console.WriteLine(averageAge);
                }
                else if (choice == "3")
                {
                    var malePatients = patientManager.GetMalePatientsList();
                    Console.WriteLine($"Male patients Data...");

                    foreach (PatientDataModel f in malePatients)
                    {
                        Console.WriteLine($" {f.PatientId.ToString()}\t {f.Name} \t {f.Age}\t{f.Gender}\t{f.Diagnosis}\t{f.Treatment}");

                    }

                }
                else if (choice == "4")
                {
                    Console.WriteLine("Enter a Valid Diagnosis from TestData. i.e. Dizziness , Anxiety ,Diabetes ,Arrhythmia ,CKD .. ");
                   var diagnosis =  Console.ReadLine();
                    if(diagnosis == "Dizziness" || diagnosis == "Anxiety" ||diagnosis == "Diabetes" || diagnosis == "Arrhythmia"|| diagnosis == "CKD" )
                    {
                        var diagnosisData = patientManager.GetPatientsWithDiagnosis(diagnosis);
                        Console.WriteLine($"patients Data based on Diagnosis");
                        foreach (PatientDataModel f in diagnosisData)
                        {
                            Console.WriteLine($" {f.PatientId.ToString()}\t {f.Name} \t {f.Age}\t{f.Gender}\t{f.Diagnosis}\t{f.Treatment}");

                        }
                    }
                    else
                    {
                        Console.WriteLine("Enter Valid Diagnosis Values i.e. Dizziness , Anxiety ,Diabetes ,Arrhythmia");
                    }
                  
                }
                else if (choice == "5")
                {
                    Console.WriteLine("Enter a Min value ");
                    int MinAgeValue = Convert.ToInt32( Console.ReadLine());
                    Console.WriteLine("Enter a Max value ");
                    int MaxAgeValue = Convert.ToInt32(Console.ReadLine());

                    if (MinAgeValue != null && MaxAgeValue != null && MinAgeValue <= MaxAgeValue) { 
         
                        var FilteredDataByAge = patientManager.GetPatientsByAgeRange(MinAgeValue, MaxAgeValue);
                        Console.WriteLine($"patients Data based on Age Range");
                        foreach (PatientDataModel f in FilteredDataByAge)
                        {
                            Console.WriteLine($" {f.PatientId.ToString()}\t {f.Name} \t {f.Age}\t{f.Gender}\t{f.Diagnosis}\t{f.Treatment}");

                        }
                    }
                    else
                    {
                        Console.WriteLine("Enter Valid Min and Max age");
                    }

                }
                else
                {
                    Console.WriteLine("Invalid input. Please try again.");
                }

            }
        }
          
        }
    }

