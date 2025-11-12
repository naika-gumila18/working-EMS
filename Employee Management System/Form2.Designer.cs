namespace Employee_Management_System
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Label lblUsername;
            Label lblFullName;
            Label lblSection;
            Label lblAge;
            Label lblPassword;
            Label lblConPass;
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            panel1 = new Panel();
            panel2 = new Panel();
            btnExecute = new Button();
            lblNumber = new Label();
            lblMatch = new Label();
            txtConfirmPassword = new TextBox();
            txtPassword = new TextBox();
            txtAge = new TextBox();
            cbSection = new ComboBox();
            txtFullname = new TextBox();
            txtUsername = new TextBox();
            dataGridView1 = new DataGridView();
            dgvUsers = new DataGridView();
            panel3 = new Panel();
            Download = new Button();
            tabPage2 = new TabPage();
            lblUsername = new Label();
            lblFullName = new Label();
            lblSection = new Label();
            lblAge = new Label();
            lblPassword = new Label();
            lblConPass = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsername.Location = new Point(2, 9);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(75, 20);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username";
            lblUsername.UseWaitCursor = true;
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFullName.Location = new Point(3, 67);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(73, 20);
            lblFullName.TabIndex = 3;
            lblFullName.Text = "Full name";
            lblFullName.UseWaitCursor = true;
            // 
            // lblSection
            // 
            lblSection.AutoSize = true;
            lblSection.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSection.Location = new Point(4, 125);
            lblSection.Name = "lblSection";
            lblSection.Size = new Size(58, 20);
            lblSection.TabIndex = 5;
            lblSection.Text = "Section";
            lblSection.UseWaitCursor = true;
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAge.Location = new Point(3, 174);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(36, 20);
            lblAge.TabIndex = 7;
            lblAge.Text = "Age";
            lblAge.TextAlign = ContentAlignment.TopCenter;
            lblAge.UseWaitCursor = true;
            lblAge.Click += label1_Click;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(3, 232);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(70, 20);
            lblPassword.TabIndex = 9;
            lblPassword.Text = "Password";
            lblPassword.TextAlign = ContentAlignment.TopCenter;
            lblPassword.UseWaitCursor = true;
            // 
            // lblConPass
            // 
            lblConPass.AutoSize = true;
            lblConPass.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblConPass.Location = new Point(2, 290);
            lblConPass.Name = "lblConPass";
            lblConPass.Size = new Size(161, 20);
            lblConPass.TabIndex = 10;
            lblConPass.Text = "Password Confirmation";
            lblConPass.TextAlign = ContentAlignment.TopCenter;
            lblConPass.UseWaitCursor = true;
            lblConPass.Click += lblConPass_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 450);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(panel1);
            tabPage1.Controls.Add(dgvUsers);
            tabPage1.Controls.Add(panel3);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 422);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "User Registration";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btnExecute);
            panel1.Controls.Add(lblNumber);
            panel1.Controls.Add(lblMatch);
            panel1.Controls.Add(txtConfirmPassword);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(lblConPass);
            panel1.Controls.Add(lblPassword);
            panel1.Controls.Add(txtAge);
            panel1.Controls.Add(lblAge);
            panel1.Controls.Add(cbSection);
            panel1.Controls.Add(lblSection);
            panel1.Controls.Add(txtFullname);
            panel1.Controls.Add(lblFullName);
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(lblUsername);
            panel1.Controls.Add(dataGridView1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(3, 37);
            panel1.Name = "panel1";
            panel1.Size = new Size(238, 382);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Location = new Point(238, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(548, 29);
            panel2.TabIndex = 3;
            // 
            // btnExecute
            // 
            btnExecute.Location = new Point(130, 351);
            btnExecute.Name = "btnExecute";
            btnExecute.Size = new Size(105, 23);
            btnExecute.TabIndex = 15;
            btnExecute.Text = "EXECUTE";
            btnExecute.UseVisualStyleBackColor = true;
            btnExecute.Click += btnExecute_Click;
            // 
            // lblNumber
            // 
            lblNumber.AutoSize = true;
            lblNumber.Location = new Point(3, 363);
            lblNumber.Name = "lblNumber";
            lblNumber.Size = new Size(59, 15);
            lblNumber.TabIndex = 14;
            lblNumber.Text = "/ Number";
            // 
            // lblMatch
            // 
            lblMatch.AutoSize = true;
            lblMatch.Location = new Point(3, 348);
            lblMatch.Name = "lblMatch";
            lblMatch.Size = new Size(49, 15);
            lblMatch.TabIndex = 13;
            lblMatch.Text = "/ Match";
            lblMatch.Click += lblMatch_Click;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(3, 313);
            txtConfirmPassword.Multiline = true;
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(232, 32);
            txtConfirmPassword.TabIndex = 12;
            txtConfirmPassword.TextChanged += txtConfirmPassword_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(3, 255);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(232, 32);
            txtPassword.TabIndex = 11;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(3, 197);
            txtAge.Multiline = true;
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(232, 32);
            txtAge.TabIndex = 8;
            // 
            // cbSection
            // 
            cbSection.FormattingEnabled = true;
            cbSection.Location = new Point(2, 148);
            cbSection.Name = "cbSection";
            cbSection.Size = new Size(230, 23);
            cbSection.TabIndex = 6;
            cbSection.SelectedIndexChanged += cbSection_SelectedIndexChanged;
            // 
            // txtFullname
            // 
            txtFullname.Location = new Point(3, 90);
            txtFullname.Multiline = true;
            txtFullname.Name = "txtFullname";
            txtFullname.Size = new Size(232, 32);
            txtFullname.TabIndex = 4;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(3, 32);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(232, 32);
            txtUsername.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(251, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(240, 150);
            dataGridView1.TabIndex = 0;
            // 
            // dgvUsers
            // 
            dgvUsers.BackgroundColor = SystemColors.ScrollBar;
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Dock = DockStyle.Fill;
            dgvUsers.Location = new Point(3, 37);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.Size = new Size(786, 382);
            dgvUsers.TabIndex = 1;
            dgvUsers.CellContentClick += dgvUsers_CellContentClick;
            dgvUsers.CellDoubleClick += dgvUsers_CellDoubleClick;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlLight;
            panel3.Controls.Add(Download);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(786, 34);
            panel3.TabIndex = 3;
            // 
            // Download
            // 
            Download.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Download.BackColor = SystemColors.ActiveCaption;
            Download.Location = new Point(658, 5);
            Download.Name = "Download";
            Download.Size = new Size(123, 23);
            Download.TabIndex = 2;
            Download.Text = "Download";
            Download.UseVisualStyleBackColor = false;
            Download.Click += button1_Click;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(792, 422);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Section Registration";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Form2";
            Text = "frmSettings";
            Load += Form2_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView dgvUsers;
        private Panel panel1;
        private DataGridView dataGridView1;
        private TextBox txtFullname;
        private TextBox txtUsername;
        private ComboBox cbSection;
        private TextBox txtAge;
        private TextBox txtConfirmPassword;
        private TextBox txtPassword;
        private Label lblNumber;
        private Label lblMatch;
        private Button btnExecute;
        private Button Download;
        private Panel panel3;
        private Panel panel2;
    }
}