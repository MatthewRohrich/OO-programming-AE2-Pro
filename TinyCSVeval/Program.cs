using System.Text;
using TinyCsvParser;
using TinyCsvParser.Mapping;

namespace TinyCSVeval
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var csv = File.ReadAllText("..\\..\\..\\employee.csv");
            
            CsvParserOptions csvOptions = new CsvParserOptions(false, ',');
            CsvEmployeeMapping csvMapper = new CsvEmployeeMapping();
            CsvParser<Employee> csvParser = new CsvParser<Employee>(csvOptions, csvMapper);

            var staff = csvParser
                .ReadFromFile(@"..\\..\\..\\employee.csv", Encoding.ASCII)
                .ToList();

            //Console.WriteLine( staff[0].Result.FirstName);
            foreach (var person in staff)
            {
                Console.WriteLine(person.Result.Id 
                    + ',' + person.Result.FirstName
                    + ',' + person.Result.LastName
                    + ',' + person.Result.HrsWorked
                    + ',' + person.Result.WithThreshold
                    );
            }

        }

        public class Employee
        {
            public string Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string HrsWorked { get; set; }
            public string WithThreshold { get; set; }
        }

        public class CsvEmployeeMapping : CsvMapping<Employee>
        {
            public CsvEmployeeMapping()
                : base()
            {
                MapProperty(0, x => x.Id);
                MapProperty(1, x => x.FirstName);
                MapProperty(2, x => x.LastName);
                MapProperty(3, x => x.HrsWorked);
                MapProperty(4, x => x.WithThreshold);

            }
        }
    }
}