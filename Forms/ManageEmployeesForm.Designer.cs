using System;
using System.Drawing;
using System.Windows.Forms;

namespace PayrollSystem
{
    partial class ManageEmployeesForm
    {
        private Panel card;
        private Label lblTitle;

        private Label lblName;
        private Label lblDept;
        private Label lblSalary;

        private TextBox txtName;
        private TextBox txtDept;
        private TextBox txtSalary;

        private Button btnAdd;
        private Button btnDelete;
        private Button btnClear;

        private DataGridView dgvEmployees;

        private void InitializeComponent()
        {
            this.SuspendLayout();

            this.Text = "Manage Employees";
            this.WindowState = FormWindowState.Maximized;
            this.BackColor = ColorTranslator.FromHtml("#F1F5F9");
            this.Font = new Font("Segoe UI", 10);

            // TITLE
            lblTitle = new Label();
            lblTitle.Text = "Manage Employees";
            lblTitle.Font = new Font("Segoe UI", 18, FontStyle.Bold);
            lblTitle.Location = new Point(40, 20);
            lblTitle.AutoSize = true;

            // CARD PANEL
            card = new Panel();
            card.BackColor = Color.White;
            card.Location = new Point(40, 80);
            card.Size = new Size(400, 260);
            card.Padding = new Padding(20);

            // LABELS
            lblName = new Label();
            lblName.Text = "Employee Name";
            lblName.Location = new Point(20, 20);

            lblDept = new Label();
            lblDept.Text = "Department";
            lblDept.Location = new Point(20, 80);

            lblSalary = new Label();
            lblSalary.Text = "Basic Salary";
            lblSalary.Location = new Point(20, 140);

            // TEXTBOXES
            txtName = new TextBox();
            txtName.Location = new Point(20, 45);
            txtName.Width = 300;

            txtDept = new TextBox();
            txtDept.Location = new Point(20, 105);
            txtDept.Width = 300;

            txtSalary = new TextBox();
            txtSalary.Location = new Point(20, 165);
            txtSalary.Width = 300;

            // BUTTON STYLE
            Button CreateButton(string text, int x)
            {
                Button btn = new Button();
                btn.Text = text;
                btn.Width = 100;
                btn.Height = 40;
                btn.Location = new Point(x, 210);
                btn.BackColor = ColorTranslator.FromHtml("#6366F1");
                btn.ForeColor = Color.White;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                return btn;
            }

            btnAdd = CreateButton("Add", 20);
            btnDelete = CreateButton("Delete", 140);
            btnClear = CreateButton("Clear", 260);

            card.Controls.Add(lblName);
            card.Controls.Add(txtName);
            card.Controls.Add(lblDept);
            card.Controls.Add(txtDept);
            card.Controls.Add(lblSalary);
            card.Controls.Add(txtSalary);
            card.Controls.Add(btnAdd);
            card.Controls.Add(btnDelete);
            card.Controls.Add(btnClear);

            // DATAGRID
            dgvEmployees = new DataGridView();
            dgvEmployees.Location = new Point(480, 80);
            dgvEmployees.Size = new Size(700, 400);
            dgvEmployees.BackgroundColor = Color.White;
            dgvEmployees.BorderStyle = BorderStyle.None;
            dgvEmployees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEmployees.RowHeadersVisible = false;

            this.Controls.Add(lblTitle);
            this.Controls.Add(card);
            this.Controls.Add(dgvEmployees);

            this.ResumeLayout(false);
        }
    }
}