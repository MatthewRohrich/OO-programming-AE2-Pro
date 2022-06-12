using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using CsvHelper.Configuration;

namespace OO_programming
{
    /// <summary>
    /// Class to Map the Properties of the payslip object with csvHelper 
    /// for saving to csv file
    /// </summary>
    public class PaySlipMap : ClassMap<PaySlip>
    {
        /// <summary>
        /// Constructor to Map the Properties of the payslip object with csvHelper 
        /// for saving to csv file
        /// </summary>
        public PaySlipMap()
        {
            Map(m => m.Employee.EmployeeId).Index(0).Name("EmployeeID");
            Map(m => m.HrsWorked).Index(1).Name("Hours Worked");
            Map(m => m.Employee.HrlyRate).Index(2).Name("Hourly Rate");
            Map(m => m.Employee.TaxThresholdFlag).Index(3).Name("Tax threshold");
            Map(m => m.PayGrossCalculated).Index(4).Name("Gross Pay");
            Map(m => m.TaxCalculated).Index(5).Name("Tax");
            Map(m => m.PayNetCalculated).Index(6).Name("Net Pay");
            Map(m => m.SuperCalculated).Index(7).Name("Superannuation");

        }
    }
}
