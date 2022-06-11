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
        public Manager(int employeeId, string firstName, string lastName, int hrlyRate, string taxWithThresholdFlag, string permissions) : base(employeeId, firstName, lastName, hrlyRate, taxWithThresholdFlag)
        {
            this.EmployeeId = employeeId;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.HrlyRate = hrlyRate;
            this.TaxWithThresholdFlag = taxWithThresholdFlag;
            this.Permissions = permissions;

        }


        public string Permissions { get => permissions; set => permissions = value; }
    }
}
