using System;
using System.Windows.Forms;

namespace PayrollSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            btnEmployees.Click += BtnEmployees_Click;
            btnPayroll.Click += BtnPayroll_Click;
            btnReports.Click += BtnReports_Click;
            btnExit.Click += BtnExit_Click;
        }

        private void BtnEmployees_Click(object sender, EventArgs e)
        {
            ManageEmployeesForm form = new ManageEmployeesForm();
            form.ShowDialog();
        }

        private void BtnPayroll_Click(object sender, EventArgs e)
        {
            PayrollForm form = new PayrollForm();
            form.ShowDialog();
        }

        private void BtnReports_Click(object sender, EventArgs e)
        {
            ReportsForm report = new ReportsForm();
            report.ShowDialog();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}