using System;
using System.Globalization;
using System.Collections.Generic;
using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;



namespace OO_programming
{
    public class ImportEmployees
    {

        public List<Employee> Employees { get; set; }

        // setup the csv config to deal with no headers
        private CsvConfiguration localConfig = new CsvConfiguration(CultureInfo.InvariantCulture)
        {
            Delimiter = ",",
            HasHeaderRecord = false,
            NewLine = Environment.NewLine,
        };




    }

}
