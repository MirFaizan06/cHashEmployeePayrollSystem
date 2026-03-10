using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace PayrollSystem
{
    public partial class PayrollForm : Form
    {
        public PayrollForm()
        {
            InitializeComponent();

            btnCalculate.Click += BtnCalculate_Click;
            btnClear.Click += BtnClear_Click;

            LoadEmployees();
            LoadPayroll();
        }

        private void LoadEmployees()
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();

                string query = "SELECT EmployeeID, Name FROM Employees";

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                DataTable table = new DataTable();
                table.Load(reader);

                cmbEmployee.DataSource = table;
                cmbEmployee.DisplayMember = "Name";
                cmbEmployee.ValueMember = "EmployeeID";
            }
        }

        private void LoadPayroll()
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();

                string query = "SELECT * FROM Payroll";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);

                DataTable table = new DataTable();
                adapter.Fill(table);

                dgvPayroll.DataSource = table;
            }
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            int empId = Convert.ToInt32(cmbEmployee.SelectedValue);
            string month = txtMonth.Text;
            int leaves = int.Parse(txtLeaves.Text);

            int basicSalary = 0;

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();

                string query = "SELECT BasicSalary FROM Employees WHERE EmployeeID=@id";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", empId);

                basicSalary = Convert.ToInt32(cmd.ExecuteScalar());
            }

            int deduction = leaves * 500;
            int finalSalary = basicSalary - deduction;

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();

                string query =
                "INSERT INTO Payroll(EmployeeID,Month,Leaves,FinalSalary) VALUES(@emp,@month,@leaves,@salary)";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@emp", empId);
                cmd.Parameters.AddWithValue("@month", month);
                cmd.Parameters.AddWithValue("@leaves", leaves);
                cmd.Parameters.AddWithValue("@salary", finalSalary);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Payroll Generated");

            LoadPayroll();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtMonth.Clear();
            txtLeaves.Clear();
        }
    }
}