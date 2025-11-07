using Employee_Management_System.CRUD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Management_System
{
    public partial class frmAddEmployee : Form
    {
        public frmAddEmployee()
        {
            InitializeComponent();
        }

        private void btnInsertUpdate_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtRequestorName.Text) || string.IsNullOrWhiteSpace(txtEmailAddress.Text) || string.IsNullOrWhiteSpace(txtLocalNumber.Text) || string.IsNullOrWhiteSpace(txtLocalNumber.Text) || string.IsNullOrWhiteSpace(txtEmpID.Text))
            {
                MessageBox.Show("Please fill up all the fields.", "Incomplete Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!txtEmailAddress.Text.EndsWith("@firstasia.edu.ph"))
            {
                MessageBox.Show("Please Enter Valid Email", "Invalid Email", MessageBoxButtons.OKCancel);
                return;
            }


            string check = "Select * from [tblEmployeeData] WHERE [ID] =  " + frmMasterData.selectedTransaction;


            if (!string.IsNullOrEmpty(frmMasterData.selectedTransaction))
            {
                bool exists = CRUD.CRUD.RETRIEVESINGLE(check);

                if (exists)
                {
                    string update = "UPDATE [tblEmployeeData] SET [RequestorName] = '" + txtRequestorName.Text + "', [RequestorEmail] = '" + txtEmailAddress.Text + "', [Section] = '" + cmbSection.Text + "', [LocalNumber] = '" + txtLocalNumber.Text + "', [EmployeeNumber] = '" + txtEmpID.Text + "' where [ID] = " + frmMasterData.selectedTransaction;
                    CRUD.CRUD.CUD(update);
                    MessageBox.Show("Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    txtEmailAddress.Clear();
                    txtEmpID.Clear();
                    txtLocalNumber.Clear();
                    txtRequestorName.Clear();
                    this.Close();
                }
                txtRequestorName.Text = "";
                txtEmailAddress.Text = "";
                txtLocalNumber.Text = "";


            }

            else
            {
                string add_requestor = "Insert into [tblEmployeeData] ([EmployeeNumber], [RequestorName], [RequestorEmail], [Section], [LocalNumber]) values ('" + txtEmpID.Text + "','" + txtRequestorName.Text + "','" + txtEmailAddress.Text + "','" + cmbSection.Text + "','" + txtLocalNumber.Text + "')";
                CRUD.CRUD.CUD(add_requestor);
                MessageBox.Show("Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                
              
            }
            this.Close();
        }
        private void frmAddEmployee_Load(object sender, EventArgs e)
        {
            txtEmpID.Text = frmMasterData.EmployeeNumber;
            txtEmailAddress.Text = frmMasterData.RequestorEmail;
            txtRequestorName.Text = frmMasterData.RequestorName;
            cmbSection.Text = frmMasterData.Section;
            txtLocalNumber.Text = frmMasterData.LocalNumber;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                string delete_requestor = "Delete from [tblEmployeeData] where [ID] = " + frmMasterData.selectedTransaction;
                CRUD.CRUD.CUD(delete_requestor);
                MessageBox.Show("Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Refresh();
                this.Close();

            }
        }

        private void ClearFields()
        {
            txtEmpID.Clear();
            txtRequestorName.Clear();
            txtEmailAddress.Clear();
            txtLocalNumber.Clear();
            cmbSection.SelectedIndex = -1;
        }

        private void NotifyParentToRefresh()
        {

            foreach (Form form in Application.OpenForms)
            {
                if (form is frmMasterData masterDataForm)
                {
                    masterDataForm.Refresh();
                    break;
                }
            }
        }

        private void txtLocalNumber_TextChanged(object sender, EventArgs e)
        {

        }
       
    }
}


//if (string.IsNullOrWhiteSpace(txtRequestorName.Text) || string.IsNullOrWhiteSpace(txtEmailAddress.Text) || string.IsNullOrWhiteSpace(txtLocalNumber.Text) || string.IsNullOrWhiteSpace(txtLocalNumber.Text) || string.IsNullOrWhiteSpace(txtEmpID.Text))
//{
//    MessageBox.Show("Please fill up all the fields.", "Incomplete Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
//    return;
//}
//if (!txtEmailAddress.Text.EndsWith("@firstasia.edu.ph"))
//{
//    MessageBox.Show("Please Enter Valid Email", "Invalid Email", MessageBoxButtons.OKCancel);
//    return;
//}

//else
//{
//    MessageBox.Show("Please enter a valid First Asia email address.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
//    return;
//}

//bool dtg_addrequestor = false;
//string EMS_data = string.Empty;
////EMS_data = "Select * from [tblEmployeeData] where [EmployeeNumber] = '" + txtEmpID.Text + "'";
////dtg_addrequestor = CRUD.CRUD.RETRIEVESINGLE(EMS_data);


//string check = "Select * from [tblEmployeeData] WHERE [EmployeeID] = '" + txtEmpID.Text + "'";
//bool exists = CRUD.CRUD.RETRIEVESINGLE(check);

//if (exists)
//{
//    DialogResult result = MessageBox.Show("This account '" + txtRequestorName.Text + "' already exists.", "Not found.", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
//    txtRequestorName.Text = "";
//    txtEmailAddress.Text = "";
//    txtLocalNumber.Text = "";

//    if (result == DialogResult.Yes)
//    {
//        string update = "update [tblEmployeeData] set [RequestorName] = '" + txtRequestorName.Text + "', [RequestorEmail] = '" + txtEmailAddress.Text + "', [Section] = '" + cmbSection.Text + "', [LocalNumber] = '" + txtLocalNumber.Text + "' where [EmployeeNumber] = '" + txtEmpID.Text + "'";
//        CRUD.CRUD.CUD(update);
//        MessageBox.Show("Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

//    }

//}

//else
//{
//    string add_requestor = "Insert into [tblEmployeeData] ([EmployeeNumber], [RequestorName], [RequestorEmail], [Section], [LocalNumber]) values ('" + txtEmpID.Text + "','" + txtRequestorName.Text + "','" + txtEmailAddress.Text + "','" + cmbSection.Text + "','" + txtLocalNumber.Text + "')";
//    CRUD.CRUD.CUD(add_requestor);
//    MessageBox.Show("Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
//}

//this.Close();
//        }
//DialogResult result = MessageBox.Show("This account '" + txtRequestorName.Text + "' already exists.", "Not found.", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
//txtRequestorName.Text = "";
//txtEmailAddress.Text = "";
//txtLocalNumber.Text = "";

//if (result == DialogResult.Yes)
//{