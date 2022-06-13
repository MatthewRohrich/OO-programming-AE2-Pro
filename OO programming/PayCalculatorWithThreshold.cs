using System.Collections;

namespace OO_programming
{
    /// <summary>
    /// Extends PayCalculator class handling With tax free threshold
    /// </summary>
    public class PayCalculatorWithThreshold : PayCalculator
    {
        decimal grossPay;
        /// <summary>
        /// Local declaration of  imported list of tax rates with the tax free threshold
        /// </summary>
        protected ArrayList taxRatesListWithThreshold;

        /// <summary>
        /// imported list of tax rates with the tax free threshold
        /// </summary>
        public ArrayList TaxRatesListWithThreshold { get => taxRatesListWithThreshold; set => taxRatesListWithThreshold = value; }

        // initialise the two tax rates
        decimal taxRateA = -1;
        decimal taxRateB = -1;


        /// <summary>
        /// Constructor inherited from the base class
        /// </summary>
        /// <param name="hourlyRate"></param>
        /// <param name="hoursWorked"></param>
        /// <param name="taxRatesListWithThreshold"></param>
        public PayCalculatorWithThreshold(decimal hourlyRate, int hoursWorked, ArrayList taxRatesListWithThreshold) : base(hourlyRate, hoursWorked)
        {
            TaxRatesListWithThreshold = taxRatesListWithThreshold;
            grossPay = base.calculateGrossPay();
            GetTaxRate(grossPay, out taxRateA, out taxRateB);
        }

        /// <summary>
        /// Find the specific tax rates for a given pay : Note taxRates are passed by reference
        /// </summary>
        /// <param name="grossPay"></param>
        /// <param name="taxRateA"></param>
        /// <param name="taxRateB"></param>
        /// <returns></returns>
        public int GetTaxRate(decimal grossPay, out decimal taxRateA, out decimal taxRateB)
        {
            taxRateA = -1;
            taxRateB = -1;
            foreach (TaxRate taxRate in TaxRatesListWithThreshold)
            {
                if (grossPay >= taxRate.WeeklyPayLow && grossPay < taxRate.WeeklyPayHigh)
                {
                    taxRateA = taxRate.TaxRateA;
                    taxRateB = taxRate.TaxRateB;
                    return 0; // success finding a matching tax rate
                }
            }

            // something went wrong
            return -1;

        }


        /// <summary>
        /// calculate the tax on the gross pay
        /// </summary>
        /// <returns></returns>
        public decimal CalculateTax()
        {

            calculatedTax = taxRateA * (grossPay + 0.99m) - taxRateB;
            return calculatedTax;
        }
        /// <summary>
        /// calculate the netPay of the employee 
        /// </summary>
        /// <returns></returns>
        public decimal CalculateNetPay()
        {
            netPay = grossPay - calculatedTax;
            return netPay;
        }
    }
}
