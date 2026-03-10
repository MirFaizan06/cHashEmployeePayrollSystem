using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace PayrollSystem
{
    public partial class ManageEmployeesForm : Form
    {
        public ManageEmployeesForm()
        {
            InitializeComponent();

            btnAdd.Click += BtnAdd_Click;
            btnDelete.Click += BtnDelete_Click;
            btnClear.Click += BtnClear_Click;

            LoadEmployees();
        }

        private void LoadEmployees()
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();

                string query = "SELECT * FROM Employees";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);

                DataTable table = new DataTable();
                adapter.Fill(table);

                dgvEmployees.DataSource = table;
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();

                string query = "INSERT INTO Employees(Name,Department,BasicSalary) VALUES(@name,@dept,@salary)";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@dept", txtDept.Text);
                cmd.Parameters.AddWithValue("@salary", int.Parse(txtSalary.Text));

                cmd.ExecuteNonQuery();

                MessageBox.Show("Employee Added");

                LoadEmployees();
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dgvEmployees.CurrentRow == null) return;

            int id = Convert.ToInt32(dgvEmployees.CurrentRow.Cells["EmployeeID"].Value);

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();

                string query = "DELETE FROM Employees WHERE EmployeeID=@id";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Employee Deleted");

                LoadEmployees();
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtDept.Clear();
            txtSalary.Clear();
        }
    }
}