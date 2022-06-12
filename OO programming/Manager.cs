namespace OO_programming
{
    /// <summary>
    /// Manager is an employee with more permissions to enable Timesheet approval
    /// </summary>
    public class Manager : Employee
    {
        // permissions to control timesheet approval
        private string permissions;

        /// <summary>
        /// Manager constructor inherits from Employee
        /// </summary>
        /// <param name="employeeId"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="hrlyRate"></param>
        /// <param name="taxWithThresholdFlag"></param>
        /// <param name="permissions"></param>
        public Manager(int employeeId, string firstName, string lastName, int hrlyRate, string taxWithThresholdFlag, string permissions) : base(employeeId, firstName, lastName, hrlyRate, taxWithThresholdFlag)
        {
            this.EmployeeId = employeeId;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.HrlyRate = hrlyRate;
            this.TaxThresholdFlag = taxWithThresholdFlag;
            this.Permissions = permissions;

        }

        /// <summary>
        /// Permissions of the manager in the pay system.
        /// permissions are currently only a placeholder and
        /// not implemented
        /// </summary>
        public string Permissions { get => permissions; set => permissions = value; }
    }
}
