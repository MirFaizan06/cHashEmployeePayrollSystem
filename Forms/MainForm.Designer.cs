using System;
using System.Drawing;
using System.Windows.Forms;

namespace PayrollSystem
{
    partial class MainForm
    {
        private Panel sidebar;
        private Panel header;
        private Panel content;

        private Label lblTitle;

        private Button btnEmployees;
        private Button btnPayroll;
        private Button btnReports;
        private Button btnExit;

        private void InitializeComponent()
        {
            this.SuspendLayout();

            // FORM
            this.Text = "Payroll System";
            this.WindowState = FormWindowState.Maximized;
            this.BackColor = ColorTranslator.FromHtml("#F1F5F9");
            this.Font = new Font("Segoe UI", 10);

            // SIDEBAR
            sidebar = new Panel();
            sidebar.Dock = DockStyle.Left;
            sidebar.Width = 220;
            sidebar.BackColor = ColorTranslator.FromHtml("#1E293B");

            // HEADER
            header = new Panel();
            header.Dock = DockStyle.Top;
            header.Height = 70;
            header.BackColor = Color.White;

            // CONTENT
            content = new Panel();
            content.Dock = DockStyle.Fill;
            content.BackColor = ColorTranslator.FromHtml("#F8FAFC");

            // TITLE
            lblTitle = new Label();
            lblTitle.Text = "Employee Payroll System";
            lblTitle.Font = new Font("Segoe UI", 18, FontStyle.Bold);
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(20, 20);

            header.Controls.Add(lblTitle);

            // BUTTON STYLE FUNCTION
            Button CreateButton(string text)
            {
                Button btn = new Button();
                btn.Text = text;
                btn.Dock = DockStyle.Top;
                btn.Height = 60;
                btn.ForeColor = Color.White;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.BackColor = ColorTranslator.FromHtml("#1E293B");
                btn.Font = new Font("Segoe UI", 11, FontStyle.Bold);
                return btn;
            }

            btnEmployees = CreateButton("👥 Employees");
            btnPayroll = CreateButton("💰 Payroll");
            btnReports = CreateButton("📊 Reports");
            btnExit = CreateButton("🚪 Exit");

            sidebar.Controls.Add(btnExit);
            sidebar.Controls.Add(btnReports);
            sidebar.Controls.Add(btnPayroll);
            sidebar.Controls.Add(btnEmployees);

            this.Controls.Add(content);
            this.Controls.Add(header);
            this.Controls.Add(sidebar);

            this.ResumeLayout(false);
        }
    }
}