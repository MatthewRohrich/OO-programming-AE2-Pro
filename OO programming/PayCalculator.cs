namespace OO_programming
{
    /// <summary>
    /// Base class to hold all Pay calculation functions
    /// Default class behaviour is tax calculated with tax threshold applied
    /// </summary>
    public class PayCalculator
    {
        // superannuation rate is fixed at 10% in 2022
        private readonly decimal superRate = 0.1m;

        // init variables that are used in the constructor
        private decimal hourlyRate;
        private int hoursWorked;

        // init the gross pay variable
        private decimal grossPay;

        public PayCalculator(decimal hourlyRate, int hoursWorked)
        {
            HourlyRate = hourlyRate;
            HoursWorked = hoursWorked;
        }

        public decimal HourlyRate { get => hourlyRate; set => hourlyRate = value; }
        public int HoursWorked { get => hoursWorked; set => hoursWorked = value; }


        /// <summary>
        /// Calculate and return Gross pay amount
        /// </summary>
        /// <returns>decimal</returns>
        public decimal calculateGrossPay()
        {
            
            return HourlyRate * HoursWorked;
        }


        /// <summary>
        /// calculate and return the superannuation amount
        /// </summary>
        /// <returns>decimal</returns>
        public decimal calculateSuperannuation()
        {
            return grossPay * superRate;  //calculate and return superannuation
        }
    }
}
