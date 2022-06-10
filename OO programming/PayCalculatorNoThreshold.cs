namespace OO_programming
{
    /// <summary>
    /// Extends PayCalculator class handling No tax threshold
    /// </summary>
    public class PayCalculatorNoThreshold : PayCalculator
    {
        private decimal[] taxThresholds;
        private decimal[] taxRatesA;
        private decimal[] taxRatesB;

        public PayCalculatorNoThreshold(decimal[] taxThresholds, decimal[] taxRatesA, decimal[] taxRatesB)
        {
            this.taxThresholds = taxThresholds;
            this.taxRatesA = taxRatesA;
            this.taxRatesB = taxRatesB;
        }

        public decimal[] TaxThresholds { get => taxThresholds; set => taxThresholds = value; }
        public decimal[] TaxRatesA { get => taxRatesA; set => taxRatesA = value; }
        public decimal[] TaxRatesB { get => taxRatesB; set => taxRatesB = value; }

        public decimal calculateTax()
        {
            return -1;
        }

    }
}
