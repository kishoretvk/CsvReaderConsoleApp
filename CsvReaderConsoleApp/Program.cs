using CsvHelper;
using CsvReaderConsoleApp.peopleMOdel;
using System;
using System.IO;

namespace CsvReaderConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ReadCsv();
        }
        public  static void ReadCsv()
        {
            //change the path of the string here 
            StreamReader sr = new StreamReader(@"\csv\People.csv");
           
           // TextReader reader = new StreamReader("import.txt");
            var csvReader = new CsvReader(sr);
            csvReader.Configuration.HasHeaderRecord = true;
            csvReader.Configuration.RegisterClassMap<PeopleMap>();
            var records = csvReader.GetRecords<People>();
            foreach (var item in records)
            {
                Console.WriteLine("people: {0}", item);
            }
            Console.ReadKey();
        }
    }
}
