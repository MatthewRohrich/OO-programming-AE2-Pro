using System;

namespace OO_programming
{
    /// <summary>
    /// Class a capture details accociated with an employee's pay slip record
    /// </summary>
    public class PaySlip
    {
        private Employee employee;
        private int hrsWorked;
        private int weekNumber;
        private Employee submittedBy;
        private DateTime submittedDate;
        private DateTime submittedTime;
        private Manager approvedBy;
        private DateTime approvedDate;
        private decimal payGrossCalculated;
        private decimal taxCalculated;
        private decimal superCalculated;
        private decimal payNetCalculated;



        /// <summary>
        /// Employee object that this payslip applies to
        /// </summary>
        public Employee Employee { get => employee; set => employee = value; }
        /// <summary>
        /// How many hrs worked this week
        /// </summary>
        public int HrsWorked { get => hrsWorked; set => hrsWorked = value; }
        /// <summary>
        /// Week of the year
        /// </summary>
        public int WeekNumber { get => weekNumber; set => weekNumber = value; }
        /// <summary>
        /// Employeee who submitted the Timesheet
        /// </summary>
        public Employee SubmittedBy { get => submittedBy; set => submittedBy = value; }
        /// <summary>
        /// Date that the timesheet was submitted
        /// </summary>
        public DateTime SubmittedDate { get => submittedDate; set => submittedDate = value; }
        /// <summary>
        /// Time that this timesheet was submitted
        /// </summary>
        public DateTime SubmittedTime { get => submittedTime; set => submittedTime = value; }
        /// <summary>
        /// Manager who approved the timesheet
        /// </summary>
        public Manager ApprovedBy { get => approvedBy; set => approvedBy = value; }
        /// <summary>
        /// Date this payslip was approved
        /// </summary>
        public DateTime ApprovedDate { get => approvedDate; set => approvedDate = value; }
        /// <summary>
        /// Gross Pay (worked hrs x hourly payrate)
        /// </summary>
        public decimal PayGrossCalculated { get => payGrossCalculated; set => payGrossCalculated = value; }
        /// <summary>
        /// Tax amount to be subtracted from Gross pay
        /// </summary>
        public decimal TaxCalculated { get => taxCalculated; set => taxCalculated = value; }
        /// <summary>
        /// Superannuation amount
        /// </summary>
        public decimal SuperCalculated { get => superCalculated; set => superCalculated = value; }
        /// <summary>
        /// Net pay after tax has been removed
        /// </summary>
        public decimal PayNetCalculated { get => payNetCalculated; set => payNetCalculated = value; }

        /// <summary>
        /// Return a summary of the payslip as a string
        /// </summary>
        /// <returns></returns>
        public string PaySummary()
        {
            string detail =
                "Employee ID: " + employee.EmployeeId + "\r\n" +
                "Name: " + employee.FirstName + " " + employee.LastName + "\r\n" +
                "Hrs Worked: " + hrsWorked + "\r\n" +
                "Hourly Rate: $" + employee.HrlyRate.ToString() + "\r\n" +
                "Tax Threshold: " + employee.TaxThresholdFlag.ToString() + "\r\n" +
                "Gross Pay: $" + payGrossCalculated.ToString() + "\r\n" +
                "Tax: $" + taxCalculated.ToString() + "\r\n" +
                "Net Pay: $" + payNetCalculated.ToString() + "\r\n" +
                "Superannuation: $" + superCalculated.ToString();

            return detail;
        }
    }


}
