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
            string select_tblrequestorlist = "select * from tblEmployeeData ORDER BY EmployeeNumber DESC";
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


            frmAddEmployee frmAddEmployee = new frmAddEmployee();
            frmAddEmployee.ShowDialog();
            string select_tblrequestorlist = "select * from tblEmployeeData ORDER BY EmployeeNumber DESC";
            CRUD.CRUD.RETRIEVEDTG(dtgMasterData, select_tblrequestorlist);


        }

        public void Refresh()
        {
            string query = "Select * from tblEmployeeData ORDER BY EmployeeNumber DESC";
            CRUD.CRUD.RETRIEVEDTG(dtgMasterData, query);
        }

        private void dtgMasterData_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            lblTransactionNo.Text = dtgMasterData.CurrentRow.Cells["ID"].Value.ToString();
            selectedTransaction = lblTransactionNo.Text;
            RequestorName = dtgMasterData.CurrentRow.Cells["RequestorName"].Value.ToString();
            RequestorEmail = dtgMasterData.CurrentRow.Cells["RequestorEmail"].Value.ToString();
            Section = dtgMasterData.CurrentRow.Cells["Section"].Value.ToString();
            LocalNumber = dtgMasterData.CurrentRow.Cells["LocalNumber"].Value.ToString();
            EmployeeNumber = dtgMasterData.CurrentRow.Cells["EmployeeNumber"].Value.ToString();
        }
    }
}

