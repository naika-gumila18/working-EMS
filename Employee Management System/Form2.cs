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
            DialogResult result = MessageBox.Show("Are you sure you want to execute?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

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
    }
}   

