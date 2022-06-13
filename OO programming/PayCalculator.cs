using System;

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
        private decimal hoursWorked;

        /// <summary>
        /// Tax Threshold defines if the first part of the pay is taxed
        /// this changes which tax rates are used.
        /// </summary>
        public string TaxThreshold { get; }

        // init the gross pay variable
        private decimal grossPay;

        /// <summary>
        /// calculated tax amount
        /// </summary>
        protected decimal calculatedTax;

        // init superannution variable.
        private decimal superannuation;

        /// <summary>
        /// netpay of the employee is gross pay minus tax
        /// </summary>
        protected decimal netPay;

        /// <summary>
        /// Constructor for PayCalculator
        /// </summary>
        /// <param name="hourlyRate"></param>
        /// <param name="hoursWorked"></param>
        public PayCalculator(decimal hourlyRate, int hoursWorked)
        {
            HourlyRate = hourlyRate;
            HoursWorked = hoursWorked;
        }





        /// <summary>
        /// Hourly rate of pay
        /// </summary>
        protected decimal HourlyRate { get => hourlyRate; set => hourlyRate = value; }
        /// <summary>
        /// Number of hrs worked in a week
        /// </summary>
        protected decimal HoursWorked { get => hoursWorked; set => hoursWorked = value; }
        

        /// <summary>
        /// Superannuation value (only available after being calculated
        /// </summary>
        protected decimal Superannuation { get => superannuation; set => superannuation = value; }



        /// <summary>
        /// Calculate and return Gross pay amount
        /// </summary>
        /// <returns>decimal</returns>
        public decimal calculateGrossPay()
        {
            grossPay =  HourlyRate * HoursWorked;
            return grossPay;
        }


        /// <summary>
        /// calculate and return the superannuation amount
        /// </summary>
        /// <returns>decimal</returns>
        public decimal calculateSuperannuation()
        {
            Superannuation = grossPay * superRate;  
            return Superannuation;  
        }


 
    }
}
