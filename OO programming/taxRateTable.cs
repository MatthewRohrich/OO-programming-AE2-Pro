using CsvHelper.Configuration.Attributes;

namespace OO_programming
{
    /// <summary>
    /// Configuration settings to show columns in the 
    /// tax rate files.
    /// </summary>
    public class TaxRate
    {
        [Index(0)]
        public decimal HrlyIndexLow { get; set; }

        [Index(1)]
        public decimal HrlyIndexHigh { get; set; }

        [Index(2)]
        public decimal TaxRateA { get; set; }

        [Index(3)]
        public decimal TaxRateB { get; set; }  

    }
}