using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Management_System
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string selectUsers = "SELECT * FROM [tblUsers] ORDER BY ID DESC";
            CRUD.CRUD.RETRIEVEDTG(dgvUsers, selectUsers);

            CRUD.CRUD.RETRIEVECBO(cbSection, "SELECT [ID], [SECTION] FROM [tblSection] ORDER BY [Section] asc", "Section", "ID");
            //CRUD.CRUD.RETRIEVEDTG(dgvUsers, "SELECT * FROM [tblUsers]", "Username", "ID");



        }

        private void Match()
        {
            if (txtPassword.Text == txtConfirmPassword.Text)
            {
                lblMatch.Text = "/ Match";
                lblMatch.ForeColor = Color.Green;

            }

            else
            {
                lblMatch.Text = "X Match";
                lblMatch.ForeColor = Color.Red;
            }
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to register?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                //*
                string insertUser = "INSERT INTO [tblUsers] ([Username], [Password], [Fullname], [Age], [Section]) " +
                                   "VALUES ('" + txtUsername.Text + "', '" + txtPassword.Text + "', '" + txtFullname.Text + "', '" + txtAge.Text + "', '" + cbSection.Text + "')";


                CRUD.CRUD.CUD(insertUser);

                MessageBox.Show("User added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                CRUD.CRUD.RETRIEVEDTG(dgvUsers, "SELECT * FROM [tblUsers]");

            }
        }

        private void lblConPass_Click(object sender, EventArgs e)
        {

        }

        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            Match();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            CRUD.CRUD.RETRIEVEDTG(dgvUsers, "SELECT * FROM [tblUsers]");

            if (System.Text.RegularExpressions.Regex.IsMatch(txtPassword.Text, @"\d"))
            {
                lblNumber.Text = "/ Number";
                lblNumber.ForeColor = Color.Green;

            }
            else
            {
                lblNumber.Text = "X Number";
                lblNumber.ForeColor = Color.Red;
            }

            Match();
        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUsername.Text = dgvUsers.Rows[e.RowIndex].Cells["Username"].Value.ToString();
            txtPassword.Text = dgvUsers.Rows[e.RowIndex].Cells["Password"].Value.ToString();
            txtFullname.Text = dgvUsers.Rows[e.RowIndex].Cells["Fullname"].Value.ToString();
            txtAge.Text = dgvUsers.Rows[e.RowIndex].Cells["Age"].Value.ToString();
            cbSection.Text = dgvUsers.Rows[e.RowIndex].Cells["Section"].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ExportDgv.ExportToExcel(dgvUsers, "ExportedData" + DateTime.Now.ToString("MM-dd-yyyy"));
        }

        private void dgvUsers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string templatePath = @"C:\LOCALDB\EmployeeDetails.xlsx";
            string savePath = @"C:\LOCALDB\EmployeeDetails.xlsx";

            ExportCellFromDgv.ExportFromTemplate(
                templatePath,
                savePath,
                "B1", dgvUsers.Rows[e.RowIndex].Cells["Fullname"].Value.ToString(),
                "H2", dgvUsers.Rows[e.RowIndex].Cells["Age"].Value.ToString(),
                "H1", dgvUsers.Rows[e.RowIndex].Cells["Section"].Value.ToString(),
                "B2", dgvUsers.Rows[e.RowIndex].Cells["Username"].Value.ToString(),
                "A32", DateTime.Now.ToString("MM-dd-yyyy"),
                "A33", frmLogin.Fullname
                );
        }

        private void lblMatch_Click(object sender, EventArgs e)
        {

        }

        private void cbSection_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}


