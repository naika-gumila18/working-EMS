using System.Windows.Forms.VisualStyles;

namespace Employee_Management_System
{
    public partial class frmMotherForm : Form
    {
        public frmMotherForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void pnlTitleBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Common.ReleaseCapture();
                Common.SendMessage(Handle, Common.WM_NCLBUTTONDOWN, Common.HT_CAPTION, 0);
            }
        }


        private void frmMotherForm_Load(object sender, EventArgs e)
        {
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            lblFullName.Text = frmLogin.Fullname;
            lblSection.Text = frmLogin.Section;
            lblAge.Text = frmLogin.Age;
        }

        private Button currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;


        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlStage.Controls.Add(childForm);
            pnlStage.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnMasterData_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmMasterData());
        }

        private void btnAddEmp_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmAddEmployee());
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form2());
        }

        private void lblSection_Click(object sender, EventArgs e)
        {

        }
    }
}

