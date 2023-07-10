using CsvHelper.Configuration.Attributes;

namespace EMISGroupConsoleApp.Model
{
    [Delimiter(",")]
    
   public class PatientDataModel
    {
        public int PatientId { get; set; }
        public string Name { get; set;}
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Diagnosis { get; set; }
        public string Treatment { get; set; }

      
    }
  
}
