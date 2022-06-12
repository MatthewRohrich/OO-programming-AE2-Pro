﻿namespace OO_programming
{
    /// <summary>
    /// Extends PayCalculator class handling With tax threshold
    /// </summary>
    public class PayCalculatorWithThreshold : PayCalculator
    {
        private decimal[] taxThresholds;
        private decimal[] taxRatesA;
        private decimal[] taxRatesB;

        /// <summary>
        /// Constructor inherited from the base class  
        /// </summary>
        /// <param name="hourlyRate"></param>
        /// <param name="hoursWorked"></param>
        public PayCalculatorWithThreshold(decimal hourlyRate, int hoursWorked) : base(hourlyRate, hoursWorked)
        {
        }




        /// <summary>
        /// Calculate tax With tax threshold
        /// </summary>
        /// <returns>decimal</returns>
        public decimal calculateTax()
        {
            return -1;
        }
    }
}
