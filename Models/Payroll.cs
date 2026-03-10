namespace PayrollSystem
{
    public class Payroll
    {
        public int PayrollID { get; set; }

        public int EmployeeID { get; set; }

        public string Month { get; set; }

        public int Leaves { get; set; }

        public decimal FinalSalary { get; set; }
    }
}