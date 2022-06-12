namespace OO_programming
{
    /// <summary>
    /// Employee class holds all the employee fields
    /// </summary>
    public class Employee
    {
        //define the employee attributes
        private int employeeId;
        private string firstName;
        private string lastName;
        private int hrlyRate;
        private string taxThresholdFlag;

        /// <summary>
        /// Constructor used to create each employee object.
        /// </summary>
        /// <param name="employeeId"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="hrlyRate"></param>
        /// <param name="taxThresholdFlag"></param>

        public Employee(int employeeId, string firstName, string lastName, int hrlyRate, string taxThresholdFlag)
        {
            this.employeeId = employeeId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.hrlyRate = hrlyRate;
            this.taxThresholdFlag = taxThresholdFlag;
        }

        /// <summary>
        /// Set employee attributes
        /// </summary>
        public int EmployeeId { get => employeeId; set => employeeId = value; }
        /// <summary>
        /// Set or get the Firstname
        /// </summary>
        public string FirstName { get => firstName; set => firstName = value; }
        /// <summary>
        /// Set or Get the Lastname
        /// </summary>
        public string LastName { get => lastName; set => lastName = value; }
        /// <summary>
        /// Set or Get the Hourly Rate
        /// </summary>
        public int HrlyRate { get => hrlyRate; set => hrlyRate = value; }
        /// <summary>
        /// Set or Get the TaxThreshold flag
        /// this determines if the pay has he tax free threshold applied or note
        /// </summary>
        public string TaxThresholdFlag { get => taxThresholdFlag; set => taxThresholdFlag = value; }
        /// <summary>
        /// Return a summary of the employee  ID + First and Last name
        /// </summary>
        /// <returns></returns>
        public override string ToString(){
            return EmployeeId + " " + FirstName + " " + LastName;
        }

        /// <summary>
        /// Return the Fullname of the employee
        /// </summary>
        public string Fullname { 
            get => firstName + " " + lastName;
        }
    }


}
