using System.Collections.Generic;
using Microsoft.Data.SqlClient;

namespace PayrollSystem
{
    public class DatabaseHelper
    {
        public static SqlConnection GetConnection()
        {
            string connectionString = EnvLoader.Get("DB_CONNECTION");
            return new SqlConnection(connectionString);
        }

        public void AddEmployee(Employee emp)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();

                string query = "INSERT INTO Employees (Name, Department, BasicSalary) VALUES (@name,@dept,@salary)";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@name", emp.Name);
                cmd.Parameters.AddWithValue("@dept", emp.Department);
                cmd.Parameters.AddWithValue("@salary", emp.BasicSalary);

                cmd.ExecuteNonQuery();
            }
        }

        public List<Employee> GetEmployees()
        {
            List<Employee> list = new List<Employee>();

            using (SqlConnection conn = GetConnection())
            {
                conn.Open();

                string query = "SELECT * FROM Employees";

                SqlCommand cmd = new SqlCommand(query, conn);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Employee e = new Employee();

                    e.EmployeeID = (int)reader["EmployeeID"];
                    e.Name = reader["Name"].ToString();
                    e.Department = reader["Department"].ToString();
                    e.BasicSalary = Convert.ToDecimal(reader["BasicSalary"]);

                    list.Add(e);
                }
            }

            return list;
        }

        public void SavePayroll(Payroll payroll)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();

                string query =
                "INSERT INTO Payroll (EmployeeID, Month, Leaves, FinalSalary) VALUES (@emp,@month,@leaves,@salary)";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@emp", payroll.EmployeeID);
                cmd.Parameters.AddWithValue("@month", payroll.Month);
                cmd.Parameters.AddWithValue("@leaves", payroll.Leaves);
                cmd.Parameters.AddWithValue("@salary", payroll.FinalSalary);

                cmd.ExecuteNonQuery();
            }
        }
    }
}