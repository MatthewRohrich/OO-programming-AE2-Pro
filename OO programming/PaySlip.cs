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



        public Employee Employee { get => employee; set => employee = value; }
        public int HrsWorked { get => hrsWorked; set => hrsWorked = value; }
        public int WeekNumber { get => weekNumber; set => weekNumber = value; }
        public Employee SubmittedBy { get => submittedBy; set => submittedBy = value; }
        public DateTime SubmittedDate { get => submittedDate; set => submittedDate = value; }
        public DateTime SubmittedTime { get => submittedTime; set => submittedTime = value; }
        public Manager ApprovedBy { get => approvedBy; set => approvedBy = value; }
        public DateTime ApprovedDate { get => approvedDate; set => approvedDate = value; }
        public decimal PayGrossCalculated { get => payGrossCalculated; set => payGrossCalculated = value; }
        public decimal TaxCalculated { get => taxCalculated; set => taxCalculated = value; }
        public decimal SuperCalculated { get => superCalculated; set => superCalculated = value; }
        public decimal PayNetCalculated { get => payNetCalculated; set => payNetCalculated = value; }

        public string PaySummary()
        {
            string detail =
                "Employee ID: " + employee.EmployeeId + "\r\n" +
                "Name: " + employee.FirstName + " " + employee.LastName + "\r\n" +
                "Hrs Worked: " + hrsWorked + "\r\n" +
                "Hourly Rate: " + employee.HrlyRate.ToString() + "\r\n" +
                "Tax Threshold: " + employee.TaxThresholdFlag.ToString() + "\r\n" +
                "Gross Pay: " + payGrossCalculated.ToString() + "\r\n" +
                "Tax: " + taxCalculated.ToString() + "\r\n" +
                "Net Pay: " + payNetCalculated.ToString() + "\r\n" +
                "Superannuation: " + superCalculated.ToString();

            return detail;
        }
    }


}
