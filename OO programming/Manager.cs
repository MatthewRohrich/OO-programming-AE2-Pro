namespace OO_programming
{
    /// <summary>
    /// Manager is an employee with more permissions to enable Timesheet approval
    /// </summary>
    public class Manager : Employee
    {
        // permissions to control timesheet approval
        private string permissions;

        // Manager constructor inherits from Employee
        public Manager(int employeeId, string firstName, string lastName, int weekHrs, bool taxWithThresholdFlag) : base(employeeId, firstName, lastName, weekHrs, taxWithThresholdFlag)
        {
            this.EmployeeId = employeeId;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.WeekHrs = weekHrs;
            this.TaxWithThresholdFlag = taxWithThresholdFlag;

        }
    }
}
