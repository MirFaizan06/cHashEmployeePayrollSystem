using System;
using System.Drawing;
using System.Windows.Forms;

namespace PayrollSystem
{
    partial class PayrollForm
    {
        private Label lblTitle;

        private Panel card;

        private Label lblEmployee;
        private Label lblMonth;
        private Label lblLeaves;

        private ComboBox cmbEmployee;
        private TextBox txtMonth;
        private TextBox txtLeaves;

        private Button btnCalculate;
        private Button btnClear;

        private DataGridView dgvPayroll;

        private void InitializeComponent()
        {
            this.SuspendLayout();

            this.Text = "Payroll";
            this.WindowState = FormWindowState.Maximized;
            this.BackColor = ColorTranslator.FromHtml("#F1F5F9");
            this.Font = new Font("Segoe UI", 10);

            // TITLE
            lblTitle = new Label();
            lblTitle.Text = "Generate Payroll";
            lblTitle.Font = new Font("Segoe UI", 18, FontStyle.Bold);
            lblTitle.Location = new Point(40, 20);
            lblTitle.AutoSize = true;

            // CARD
            card = new Panel();
            card.BackColor = Color.White;
            card.Location = new Point(40, 80);
            card.Size = new Size(420, 260);
            card.Padding = new Padding(20);

            // LABELS
            lblEmployee = new Label();
            lblEmployee.Text = "Employee";
            lblEmployee.Location = new Point(20, 20);

            lblMonth = new Label();
            lblMonth.Text = "Month";
            lblMonth.Location = new Point(20, 90);

            lblLeaves = new Label();
            lblLeaves.Text = "Leaves";
            lblLeaves.Location = new Point(20, 150);

            // INPUTS
            cmbEmployee = new ComboBox();
            cmbEmployee.Location = new Point(20, 45);
            cmbEmployee.Width = 320;

            txtMonth = new TextBox();
            txtMonth.Location = new Point(20, 115);
            txtMonth.Width = 320;

            txtLeaves = new TextBox();
            txtLeaves.Location = new Point(20, 175);
            txtLeaves.Width = 320;

            // BUTTON STYLE
            Button CreateButton(string text, int x)
            {
                Button btn = new Button();
                btn.Text = text;
                btn.Width = 120;
                btn.Height = 40;
                btn.Location = new Point(x, 210);
                btn.BackColor = ColorTranslator.FromHtml("#6366F1");
                btn.ForeColor = Color.White;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                return btn;
            }

            btnCalculate = CreateButton("Calculate", 20);
            btnClear = CreateButton("Clear", 160);

            card.Controls.Add(lblEmployee);
            card.Controls.Add(cmbEmployee);
            card.Controls.Add(lblMonth);
            card.Controls.Add(txtMonth);
            card.Controls.Add(lblLeaves);
            card.Controls.Add(txtLeaves);
            card.Controls.Add(btnCalculate);
            card.Controls.Add(btnClear);

            // DATAGRID
            dgvPayroll = new DataGridView();
            dgvPayroll.Location = new Point(500, 80);
            dgvPayroll.Size = new Size(720, 400);
            dgvPayroll.BackgroundColor = Color.White;
            dgvPayroll.BorderStyle = BorderStyle.None;
            dgvPayroll.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPayroll.RowHeadersVisible = false;

            this.Controls.Add(lblTitle);
            this.Controls.Add(card);
            this.Controls.Add(dgvPayroll);

            this.ResumeLayout(false);
        }
    }
}