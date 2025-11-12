using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Employee_Management_System
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    
        public static string Fullname, Section, Age;
        private void button1_Click_1(object sender, EventArgs e)
        {
           
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
           

            if (string.IsNullOrWhiteSpace(username) && string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please input username and password");
                return;
            }
            else if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Please input username");
                return;
            }
            else if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please input password");
                return;
            }


            string sql = $"SELECT [Fullname], [Section], [Age], [Username], [Password] FROM tblUsers WHERE Username = '{username}'";

            bool foundUser = CRUD.CRUD.RETRIEVESINGLE(sql);

            if (foundUser && CRUD.CRUD.dt.Rows.Count > 0)
            {
                string dbUsername = CRUD.CRUD.dt.Rows[0]["Username"].ToString();
                string dbPassword = CRUD.CRUD.dt.Rows[0]["Password"].ToString();

                if (username.Equals(dbUsername, StringComparison.Ordinal) &&
                    password.Equals(dbPassword, StringComparison.Ordinal))
                {
                    Fullname = CRUD.CRUD.dt.Rows[0]["Fullname"].ToString();
                    Section = CRUD.CRUD.dt.Rows[0]["Section"].ToString();
                    Age = CRUD.CRUD.dt.Rows[0]["Age"].ToString();

                    
                    MessageBox.Show($"Welcome to EMS, {Fullname}!", "Login Successfully");
                    this.Hide();

                    frmMotherForm openForm = new frmMotherForm();
                    openForm.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid username or password (case-sensitive).", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
             else
             {
                MessageBox.Show("Username not found.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Information);
             }
            }
        }
    }

   