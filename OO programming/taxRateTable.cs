using CsvHelper.Configuration.Attributes;

namespace OO_programming
{
    /// <summary>
    /// Configuration settings to show columns in the 
    /// tax rate files.
    /// Tax is calculated like this   tax = RateA * (weeklypay + 0.99) - RateB
    /// Rates are selected based on the range the pay is between low and high
    /// </summary>
    public class TaxRate
    {
        /// <summary>
        /// Column number definition for the low end of the tax range
        /// </summary>
        [Index(0)]
        public decimal WeeklyPayLow { get; set; }
        /// <summary>
        /// Column number definition for the high end of the tax range
        /// </summary>
        [Index(1)]
        public decimal WeeklyPayHigh { get; set; }
        /// <summary>
        /// Column number definition for tax rate A
        /// </summary>
        [Index(2)]
        public decimal TaxRateA { get; set; }
        /// <summary>
        /// Column number definition for tax rate B
        /// </summary>
        [Index(3)]
        public decimal TaxRateB { get; set; }  

    }
}