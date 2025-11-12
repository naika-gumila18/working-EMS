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
    public partial class frmMasterData : Form
    {
        public frmMasterData()
        {
            InitializeComponent();
        }

        private void frmMasterData_Load(object sender, EventArgs e)
        {
          
            string select_tblrequestorlist = "select * from tblEmployeeData ORDER BY ID DESC";
            CRUD.CRUD.RETRIEVEDTG(dtgMasterData, select_tblrequestorlist);
        }

        private void dtgMasterData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgMasterData_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            lblTransactionNum = dtgMasterData.CurrentRow.Cells["ID"].Value.ToString();
            selectedTransaction = lblTransactionNo.Text;
            RequestorName = dtgMasterData.CurrentRow.Cells["RequestorName"].Value.ToString();
            RequestorEmail = dtgMasterData.CurrentRow.Cells["RequestorEmail"].Value.ToString();
            Section = dtgMasterData.CurrentRow.Cells["Section"].Value.ToString();
            LocalNumber = dtgMasterData.CurrentRow.Cells["LocalNumber"].Value.ToString();
            EmployeeNumber = dtgMasterData.CurrentRow.Cells["EmployeeNumber"].Value.ToString();
        }


        public static string EmployeeNumber, lblTransactionNum;
        public static string RequestorName;
        public static string RequestorEmail;
        public static string Section;
        public static string LocalNumber, selectedTransaction;

        private void btnEditData_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrEmpty(selectedTransaction))
            {
                MessageBox.Show("Please select a record to edit.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Load selected row details into static variables
            DataGridViewRow row = dtgMasterData.CurrentRow;

            RequestorName = row.Cells["RequestorName"].Value.ToString();
            RequestorEmail = row.Cells["RequestorEmail"].Value.ToString();
            Section = row.Cells["Section"].Value.ToString();
            LocalNumber = row.Cells["LocalNumber"].Value.ToString();
            EmployeeNumber = row.Cells["EmployeeNumber"].Value.ToString();

            // Open Add/Edit form
            frmAddEmployee frmAddEmployee = new frmAddEmployee();
            frmAddEmployee.ShowDialog();

            Refresh();

            ClearSelection();
        }

        private void ClearSelection()
        {
            selectedTransaction = "";
            RequestorName = "";
            RequestorEmail = "";
            Section = "";
            LocalNumber = "";
            EmployeeNumber = "";
            lblTransactionNo.Text = "";
        }


        public void Refresh()
        {
            string query = "Select * from tblEmployeeData ORDER BY ID DESC";
            CRUD.CRUD.RETRIEVEDTG(dtgMasterData, query);
        }

        private void dtgMasterData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                lblTransactionNo.Text = dtgMasterData.CurrentRow.Cells["ID"].Value.ToString();
                selectedTransaction = lblTransactionNo.Text;
            }

        }
    }
}

//lblTransactionNo.Text = dtgMasterData.CurrentRow.Cells["ID"].Value.ToString();
//selectedTransaction = lblTransactionNo.Text;
//RequestorName = dtgMasterData.CurrentRow.Cells["RequestorName"].Value.ToString();
//RequestorEmail = dtgMasterData.CurrentRow.Cells["RequestorEmail"].Value.ToString();
//Section = dtgMasterData.CurrentRow.Cells["Section"].Value.ToString();
//LocalNumber = dtgMasterData.CurrentRow.Cells["LocalNumber"].Value.ToString();
//EmployeeNumber = dtgMasterData.CurrentRow.Cells["EmployeeNumber"].Value.ToString();


