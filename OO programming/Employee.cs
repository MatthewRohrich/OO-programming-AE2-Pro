namespace OO_programming
{
    /// <summary>
    /// Employee details
    /// </summary>
    public class Employee
    {
        //define the employee attributes
        private int employeeId;
        private string firstName;
        private string lastName;
        private int weekHrs;
        private bool taxWithThresholdFlag;  // file contains Y or N will need conversion

        //employee constructor used to create each employee object.
        public Employee(int employeeId, string firstName, string lastName, int weekHrs, bool taxWithThresholdFlag)
        {
            this.employeeId = employeeId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.weekHrs = weekHrs;
            this.taxWithThresholdFlag = taxWithThresholdFlag;
        }

        /// <summary>
        /// Set employee attributes
        /// </summary>
        public int EmployeeId { get => employeeId; set => employeeId = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public int WeekHrs { get => weekHrs; set => weekHrs = value; }
        public bool TaxWithThresholdFlag { get => taxWithThresholdFlag; set => taxWithThresholdFlag = value; }
    }
}
