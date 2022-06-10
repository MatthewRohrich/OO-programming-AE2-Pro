using System;

namespace OO_programming
{
    /// <summary>
    /// Class a capture details accociated with an employee's pay slip record
    /// </summary>
    public class PaySlip
    {
        private Employee employee;
        private int weekHours;
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

        public PaySlip(Employee employee, int weekHours, int weekNumber, Employee submittedBy, DateTime submittedDate, DateTime submittedTime, Manager approvedBy, DateTime approvedDate, decimal payGrossCalculated, decimal taxCalculated, decimal superCalculated, decimal payNetCalculated)
        {
            this.employee = employee;
            this.weekHours = weekHours;
            this.weekNumber = weekNumber;
            this.submittedBy = submittedBy;
            this.submittedDate = submittedDate;
            this.submittedTime = submittedTime;
            this.approvedBy = approvedBy;
            this.approvedDate = approvedDate;
            this.payGrossCalculated = payGrossCalculated;
            this.taxCalculated = taxCalculated;
            this.superCalculated = superCalculated;
            this.payNetCalculated = payNetCalculated;
        }

        public PaySlip paySlipDetails()
        {
            return this;
        }
 }


}
