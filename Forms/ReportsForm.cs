using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace PayrollSystem
{
    public partial class ReportsForm : Form
    {
        public ReportsForm()
        {
            InitializeComponent();

            btnRefresh.Click += BtnRefresh_Click;

            LoadReport();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            LoadReport();
        }

        private void LoadReport()
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();

                string query = @"
                SELECT 
                e.EmployeeID,
                e.Name,
                e.Department,
                p.Month,
                p.Leaves,
                e.BasicSalary,
                p.FinalSalary
                FROM Employees e
                INNER JOIN Payroll p
                ON e.EmployeeID = p.EmployeeID
                ";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);

                DataTable table = new DataTable();
                adapter.Fill(table);

                dgvReport.DataSource = table;
            }
        }
    }
}