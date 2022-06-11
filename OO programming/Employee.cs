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
        private int hrlyRate;
        private string taxWithThresholdFlag;  // file contains Y or N will need conversion

        //employee constructor used to create each employee object.
        public Employee(int employeeId, string firstName, string lastName, int hrlyRate, string taxWithThresholdFlag)
        {
            this.employeeId = employeeId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.hrlyRate = hrlyRate;
            this.taxWithThresholdFlag = taxWithThresholdFlag;
        }

        /// <summary>
        /// Set employee attributes
        /// </summary>
        public int EmployeeId { get => employeeId; set => employeeId = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public int HrlyRate { get => hrlyRate; set => hrlyRate = value; }
        public string TaxWithThresholdFlag { get => taxWithThresholdFlag; set => taxWithThresholdFlag = value; }
        public override string ToString(){
            return EmployeeId + " " + FirstName + " " + LastName;
        }
    }


}
