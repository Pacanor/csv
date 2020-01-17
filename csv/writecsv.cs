using CsvHelper;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Csv
{
    public class writecsv
    {
        public static int ID { get; set; }
        public static string Name { get; set; }
        public static decimal Marks { get; set; }


        public static void WriteCsvFile<T>(IList<T> myList, string fileName)
        {
            var countryCapitalQuery = (from s in myList
                                       //where s.Capital.Equals("primary")
                                       //orderby s.Country ascending
                                       select s);
            /*
            foreach (CityModelImport city in countryCapitalQuery)
            {
                Debug.Write(city.Country + ": " + city.City_name + Environment.NewLine);
            }*/
            //var queryName = nameof(countryCapitalQuery);
            var writePath = "c://csvfiles//" + fileName + ".csv";
            using (var writer = new StreamWriter(writePath))
            using (var csv = new CsvWriter(writer))
            {
                csv.WriteRecords(countryCapitalQuery);
            }


        }
    }
}
