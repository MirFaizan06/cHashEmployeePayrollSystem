using System;
using System.Drawing;
using System.Windows.Forms;

namespace PayrollSystem
{
    partial class ReportsForm
    {
        private Label lblTitle;
        private Panel topPanel;
        private Button btnRefresh;
        private DataGridView dgvReport;

        private void InitializeComponent()
        {
            this.SuspendLayout();

            this.Text = "Payroll Reports";
            this.WindowState = FormWindowState.Maximized;
            this.BackColor = ColorTranslator.FromHtml("#F1F5F9");
            this.Font = new Font("Segoe UI", 10);

            // TITLE
            lblTitle = new Label();
            lblTitle.Text = "Payroll Report";
            lblTitle.Font = new Font("Segoe UI", 20, FontStyle.Bold);
            lblTitle.Location = new Point(40, 20);
            lblTitle.AutoSize = true;

            // TOP PANEL
            topPanel = new Panel();
            topPanel.BackColor = Color.White;
            topPanel.Location = new Point(40, 80);
            topPanel.Size = new Size(1180, 70);

            // REFRESH BUTTON
            btnRefresh = new Button();
            btnRefresh.Text = "Refresh Report";
            btnRefresh.Width = 160;
            btnRefresh.Height = 40;
            btnRefresh.Location = new Point(20, 15);
            btnRefresh.BackColor = ColorTranslator.FromHtml("#10B981");
            btnRefresh.ForeColor = Color.White;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.FlatAppearance.BorderSize = 0;

            topPanel.Controls.Add(btnRefresh);

            // DATAGRID
            dgvReport = new DataGridView();
            dgvReport.Location = new Point(40, 170);
            dgvReport.Size = new Size(1180, 500);
            dgvReport.BackgroundColor = Color.White;
            dgvReport.BorderStyle = BorderStyle.None;
            dgvReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReport.RowHeadersVisible = false;
            dgvReport.AllowUserToAddRows = false;

            this.Controls.Add(lblTitle);
            this.Controls.Add(topPanel);
            this.Controls.Add(dgvReport);

            this.ResumeLayout(false);
        }
    }
}