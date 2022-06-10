using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;
using System.Globalization;


namespace CSVHelperEval
{
    /// <summary>
    /// Small application to test the CSVHelper library
    /// found at https://joshclose.github.io/CsvHelper/
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// In the beginning was the text file and it was good
        /// but the text file was disorganised: it could be better.
        /// so it was made better with the csv.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            

            // setup the csv config to deal with no headers
            var localConfig = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                Delimiter = ",",
                HasHeaderRecord = false,
                NewLine = Environment.NewLine,
            };





            //Console.WriteLine("Hello, World!");

            using (var reader = new StreamReader("..\\..\\..\\employee.csv"))
            using (var csv = new CsvReader(reader, localConfig))
            {

                //csv.Context.RegisterClassMap<EmployeeMap>();
                var staff = csv.GetRecords<Employee>();

                foreach (var person in staff)
                {
                    Console.WriteLine(
                        person.Id
                        + ','
                        + person.FirstName
                        + ','
                        + person.LastName
                        + ','
                        + person.HrsWorked
                        + ','
                        + person.WithThreshold);

                };

            }


        }
        public class Employee
        {
            [Index(0)]
            public string Id { get; set; }

            [Index(1)]
            public string FirstName { get; set; }

            [Index(2)]
            public string LastName { get; set; }

            [Index(3)]
            public string HrsWorked { get; set; }

            [Index(4)]
            public string WithThreshold { get; set; }
        }

        // this doesn't seem to be needed
        // unless I map when opening the CSV ?
        //public class EmployeeMap : ClassMap<Employee>
        //{
        //    public EmployeeMap()
        //    {
        //        Map(m => m.Id).Name("id");
        //        Map(m => m.FirstName).Name("FirstName");
        //        Map(m => m.LastName).Name("LastName");
        //        Map(m => m.HrsWorked).Name("HrsWorked");
        //        Map(m => m.WithThreshold).Name("WithThreshold");

        //    }
        //}
    }
}
