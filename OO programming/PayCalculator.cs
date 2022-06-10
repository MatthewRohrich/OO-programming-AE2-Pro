namespace OO_programming
{
    /// <summary>
    /// Base class to hold all Pay calculation functions
    /// Default class behaviour is tax calculated with tax threshold applied
    /// </summary>
    public class PayCalculator
    {
        private decimal hourlyRate;
        private decimal superRate;


        /// <summary>
        /// Calculate and return pay amount
        /// </summary>
        /// <returns>decimal</returns>
        public decimal calculatePay()
        {
            return -1; //placeholder
        }


        /// <summary>
        /// calculate and return the superannuation amount
        /// </summary>
        /// <returns>decimal</returns>
        public decimal calculateSuperannuation()
        {
            return -1;
        }
    }
}
