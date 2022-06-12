namespace OO_programming
{
    /// <summary>
    /// Extends PayCalculator class handling No tax threshold
    /// </summary>
    public class PayCalculatorNoThreshold : PayCalculator
    {
        private decimal[] taxThresholdsLow;
        private decimal[] taxThresholdsHigh;
        private decimal[] taxRatesA;
        private decimal[] taxRatesB;

        /// <summary>
        /// Constructor inherited from the base class
        /// </summary>
        /// <param name="hourlyRate"></param>
        /// <param name="hoursWorked"></param>
        public PayCalculatorNoThreshold(decimal hourlyRate, int hoursWorked) : base(hourlyRate, hoursWorked)
        {

        }

        public decimal[] TaxThresholdsLow { get => taxThresholdsLow; set => taxThresholdsLow = value; }
        public decimal[] TaxThresholdsHigh { get => taxThresholdsHigh; set => taxThresholdsHigh = value; }
        public decimal[] TaxRatesA { get => taxRatesA; set => taxRatesA = value; }
        public decimal[] TaxRatesB { get => taxRatesB; set => taxRatesB = value; }

        public decimal calculateNetTax()
        {
            return -1; //ToDo 
        }

    }
}
