using Csv;

namespace simpleCSV
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var options = new CsvOptions // Defaults
            {
                HeaderMode = HeaderMode.HeaderAbsent, // Assumes first row is a header row
                NewLine = Environment.NewLine // The new line string to use when multiline field values are read (Requires "AllowNewLineInEnclosedFieldValues" to be set to "true" for this to have any effect.)
            };
            // Console.WriteLine("Hello, World!");
            var csv = File.ReadAllText("..\\..\\..\\employee.csv");
            var lines = CsvReader.ReadFromText(csv, options);
            foreach (var line in lines)
            {
                var firstColumn = line[0];
                var secondColumn = line[1];
                var thirdColumn = line[2];
                var fourthColumn = line[3];

                Console.WriteLine(firstColumn + " " + secondColumn + " " + thirdColumn + " " + fourthColumn);
            }

            
        }
    }
}