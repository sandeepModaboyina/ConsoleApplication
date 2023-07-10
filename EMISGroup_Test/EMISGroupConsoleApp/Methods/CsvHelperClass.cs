using CsvHelper;
using CsvHelper.Configuration;
using EMISGroupConsoleApp.Model;
using System.Globalization;

namespace EMISGroupConsoleApp.Methods
{
    public class CsvHelperClass
    {
        public List<PatientDataModel> TextFileParser(string filePath)
        {
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                IgnoreBlankLines = true,
                DetectDelimiter = true
            };
            var reader = new StreamReader(filePath);
            var csv = new CsvReader(reader, config);
            var initData = csv.GetRecords<PatientDataModel>().ToList();
            return initData;
        }
    }
}