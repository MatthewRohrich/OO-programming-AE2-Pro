using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;
using System.Collections;
using System.Globalization;

namespace OO_programming
{
    public partial class frmPayCalc : Form
    {
        //declare empty employee objects
        List<Employee> employeesList = new List<Employee>();

        //declare an empty payslip oject
        PaySlip paySlip;

        public Employee Manager { get; private set; }

        public frmPayCalc()
        {
            InitializeComponent();

            // Add code below to complete the implementation to populate the listBox
            // by reading the employee.csv file into a List of PaySlip objects, then binding this to the ListBox.
            // CSV file format: <employee ID>, <first name>, <last name>, <hourly rate>,<taxthreshold>


            // load the employees from file into a list
            LoadEmployees(employeesList);


            // add the employees to the form listbox
            foreach (Employee employee in employeesList)
            {
                // add each employee to the list box
                lbEmployees.Items.Add(employee.ToString());
            }



            //PayCalculator myTestCalc = new PayCalculator();
            //MessageBox.Show(myTestCalc.calculatePay(34).ToString());

            TaxRate taxRatesListNoThreshold = new TaxRate();
            taxRatesListNoThreshold = LoadTaxRates("..\\..\\..\\taxrate-nothreshold.csv");

            TaxRate taxRatesListWithThreshold = new TaxRate();
            taxRatesListWithThreshold = LoadTaxRates("..\\..\\..\\taxrate-withthreshold.csv");

            //MessageBox.Show("how many entries :" + taxRatesListNoThreshold.Count);
            //MessageBox.Show("how many entries :" + (taxRatesListNoThreshold.ToArray()).Count());

            //foreach (ArrayList taxRate in taxRatesListNoThreshold)
            //{


            //    foreach (decimal taxItem in taxRate)
            //    {
            //        MessageBox.Show(taxItem.ToString());
            //    }
            //}
        }


        private void btnCalcPay_Click(object sender, EventArgs e)
        {
            // Add code below to complete the implementation to populate the
            // payment summary (textBox2) using the PaySlip and PayCalculatorNoThreshold
            // and PayCalculatorWithThresholds classes object and methods.

            // display the selected employee
            int lbIndex = (lbEmployees.SelectedIndex);
            if (lbIndex == -1)
            {
                MessageBox.Show($"please select an Employee {DateTime.Now:s}");
            }
            else if (int.Parse(tbHrsWorked.Text) < 0 || int.Parse(tbHrsWorked.Text)  > 40)
            {
                MessageBox.Show("Work hrs must be greater than 0 and cannot exceed 40hrs");
            }
            else
            { 
            

                Manager myBoss = new Manager(8, "Matthew", "Rohrich", 38, "Y", "I have the power");

                //create the payslip here with raw data
                paySlip = new PaySlip
                {
                    Employee = employeesList[lbEmployees.SelectedIndex],
                    HrsWorked = int.Parse(tbHrsWorked.Text),
                    WeekNumber = 18,
                    SubmittedBy = employeesList[lbEmployees.SelectedIndex],
                    SubmittedDate = DateTime.Now,
                    SubmittedTime = DateTime.Now,
                    ApprovedBy = myBoss,
                    ApprovedDate = DateTime.Now
                };



                // TODO: calculate the pay
                PayCalculator payCalc = new PayCalculator(
                    int.Parse(tbHrsWorked.Text), 
                    employeesList[lbEmployees.SelectedIndex].HrlyRate,
                    employeesList[lbEmployees.SelectedIndex].TaxThresholdFlag
                    );
                paySlip.PayGrossCalculated = payCalc.calculateGrossPay();
                paySlip.SuperCalculated = payCalc.calculateSuperannuation();
                paySlip.TaxCalculated = payCalc.CalculateTax(0.19m, 68.3462m);
                paySlip.PayNetCalculated = payCalc.CalculateNetPay();

                // populate the payment summary screen
                tbPaymentSummary.Text = paySlip.PaySummary();

                //now is a good time to display the button so the payslip can be saved
                btnSavePaySummary.Visible = true;
                btnSavePaySummary.Text = "Save *";

            }
        }

        private void btnSavePaySummary_Click(object sender, EventArgs e)
        {
            // Add code below to complete the implementation for saving the
            // calculated payment data into a csv file.
            // File naming convention: Pay_<full name>_<datetimenow>.csv
            // Data fields expected - EmployeeId, Full Name, Hours Worked, Hourly Rate, Tax Threshold, Gross Pay, Tax, Net Pay, Superannuation

            //something went wrong and the save button is visible when it shouldn't be
            if (paySlip == null)
            {

                MessageBox.Show("Please choose an employee and calculate their pay before trying to save");
                return;
            }

            

            // generate the payslip filename - no spaces in the filename
            string saveFileName = 
                $"Pay-{paySlip.Employee.EmployeeId}" +
                $"-{(paySlip.Employee.Fullname).Replace(" ","-")}" +  
                $"-{DateTime.Now:yyyy-MM-dd-HH-mm-ss}.csv";
            string saveFilePath = $"..\\..\\..\\{saveFileName}";
            var records = new List<PaySlip> {
                paySlip
            };

         
            // save the payslip object to csv file
            using (var writer = new StreamWriter(saveFilePath))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.Context.RegisterClassMap<PaySlipMap>();
                csv.WriteRecords(records);
            }

            btnSavePaySummary.Text = "Save";
        }   


        /// <summary>
        /// read the employees from from a file into an ArrayList
        /// </summary>
        /// <param name="employeesList"></param>
        private static void LoadEmployees(List<Employee> employeesList)
        {
            // setup the csv config to deal with no headers
            CsvConfiguration localConfig = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                Delimiter = ",",
                HasHeaderRecord = false,
                NewLine = Environment.NewLine,
            };

            // open csv into a streamreader
            using (var reader = new StreamReader("..\\..\\..\\employee.csv"))
            //load file data into csv helper
            using (var csv = new CsvReader(reader, localConfig))
            {

                //csv.Context.RegisterClassMap<EmployeeMap>();
                var staff = csv.GetRecords<Employee>();

                // add each employee record to our list
                foreach (var person in staff)
                {
                    employeesList.Add(new Employee(person.EmployeeId,
                                person.FirstName,
                                person.LastName,
                                person.HrlyRate,
                                person.TaxThresholdFlag));
                };

            }
        }

        /// <summary>
        /// Load the TaxRates from file
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        private static TaxRate LoadTaxRates(string fileName )
        {

            // setup the csv config to deal with no headers
            CsvConfiguration localConfig = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                Delimiter = ",",
                HasHeaderRecord = false,
                NewLine = Environment.NewLine,
            };

            // open csv into a streamreader
            using (var reader = new StreamReader(fileName))
            //load file data into csv helper
            using (var csv = new CsvReader(reader, localConfig))
            {

                //csv.Context.RegisterClassMap<EmployeeMap>();
                var rates = csv.GetRecords<TaxRate>();

                // need to be in 4 arrays to match the 4 columns 

                //ArrayList arrPayLow = new ArrayList();
                //ArrayList arrPayHigh = new ArrayList();
                //ArrayList arrTaxRateA = new ArrayList();
                //ArrayList arrTaxRateB = new ArrayList();

                //// add each column to a seperate array
                //foreach (var rate in rates)
                //{

                //    arrPayLow.Add(rate.WeeklyPayLow);
                //    arrPayHigh.Add(rate.WeeklyPayHigh);
                //    arrTaxRateA.Add(rate.TaxRateA);
                //    arrTaxRateB.Add(rate.TaxRateB);



                //};
                //// merge the columns to a single array
                //ArrayList taxRate = new ArrayList();
                //taxRateList.Add(arrPayLow); 
                //taxRateList.Add(arrPayHigh);
                //taxRateList.Add(arrTaxRateA);
                //taxRateList.Add(arrTaxRateB);

                //return taxRateList;

                return (TaxRate)rates;
            }

        }

    }
}
