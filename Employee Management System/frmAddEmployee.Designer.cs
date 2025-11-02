namespace Employee_Management_System
{
    partial class frmAddEmployee
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
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtEmpID = new TextBox();
            txtRequestorName = new TextBox();
            txtEmailAddress = new TextBox();
            txtLocalNumber = new TextBox();
            groupBox1 = new GroupBox();
            btnDelete = new Button();
            cmbSection = new ComboBox();
            btnInsertUpdate = new Button();
            button2 = new Button();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 66);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Heading", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 28);
            label1.Name = "label1";
            label1.Size = new Size(112, 23);
            label1.TabIndex = 0;
            label1.Text = "Add Employee";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Text", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(8, 2);
            label2.Name = "label2";
            label2.Size = new Size(296, 19);
            label2.TabIndex = 1;
            label2.Text = "Employee Details Manual Insert and Update:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(8, 36);
            label3.Name = "label3";
            label3.Size = new Size(116, 18);
            label3.TabIndex = 2;
            label3.Text = "Employee Number:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(19, 79);
            label4.Name = "label4";
            label4.Size = new Size(104, 18);
            label4.TabIndex = 3;
            label4.Text = "Requestor Name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(33, 124);
            label5.Name = "label5";
            label5.Size = new Size(93, 18);
            label5.TabIndex = 4;
            label5.Text = "Email Address:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Sitka Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(32, 168);
            label6.Name = "label6";
            label6.Size = new Size(90, 18);
            label6.TabIndex = 5;
            label6.Text = "Local Number:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Sitka Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(68, 209);
            label7.Name = "label7";
            label7.Size = new Size(54, 18);
            label7.TabIndex = 6;
            label7.Text = "Section:";
            // 
            // txtEmpID
            // 
            txtEmpID.Location = new Point(123, 33);
            txtEmpID.Multiline = true;
            txtEmpID.Name = "txtEmpID";
            txtEmpID.Size = new Size(295, 30);
            txtEmpID.TabIndex = 7;
            // 
            // txtRequestorName
            // 
            txtRequestorName.Location = new Point(123, 76);
            txtRequestorName.Multiline = true;
            txtRequestorName.Name = "txtRequestorName";
            txtRequestorName.Size = new Size(295, 30);
            txtRequestorName.TabIndex = 8;
            // 
            // txtEmailAddress
            // 
            txtEmailAddress.Location = new Point(123, 121);
            txtEmailAddress.Multiline = true;
            txtEmailAddress.Name = "txtEmailAddress";
            txtEmailAddress.Size = new Size(295, 30);
            txtEmailAddress.TabIndex = 9;
            // 
            // txtLocalNumber
            // 
            txtLocalNumber.Location = new Point(123, 165);
            txtLocalNumber.Multiline = true;
            txtLocalNumber.Name = "txtLocalNumber";
            txtLocalNumber.Size = new Size(295, 30);
            txtLocalNumber.TabIndex = 10;
            txtLocalNumber.TextChanged += txtLocalNumber_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ButtonFace;
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(cmbSection);
            groupBox1.Controls.Add(btnInsertUpdate);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtLocalNumber);
            groupBox1.Controls.Add(txtEmailAddress);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtRequestorName);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(txtEmpID);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(4, 67);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(794, 305);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(304, 209);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(114, 23);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // cmbSection
            // 
            cmbSection.BackColor = SystemColors.ActiveCaption;
            cmbSection.DropDownHeight = 110;
            cmbSection.ForeColor = SystemColors.ButtonHighlight;
            cmbSection.FormattingEnabled = true;
            cmbSection.IntegralHeight = false;
            cmbSection.Location = new Point(123, 209);
            cmbSection.Name = "cmbSection";
            cmbSection.Size = new Size(175, 23);
            cmbSection.TabIndex = 11;
            // 
            // btnInsertUpdate
            // 
            btnInsertUpdate.BackColor = SystemColors.ActiveCaption;
            btnInsertUpdate.Font = new Font("Sitka Text", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInsertUpdate.Location = new Point(123, 239);
            btnInsertUpdate.Name = "btnInsertUpdate";
            btnInsertUpdate.Size = new Size(124, 36);
            btnInsertUpdate.TabIndex = 12;
            btnInsertUpdate.Text = "INSERT/UPDATE";
            btnInsertUpdate.UseVisualStyleBackColor = false;
            btnInsertUpdate.Click += btnInsertUpdate_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.Font = new Font("Sitka Text", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(424, 33);
            button2.Name = "button2";
            button2.Size = new Size(87, 30);
            button2.TabIndex = 13;
            button2.Text = "Search";
            button2.UseVisualStyleBackColor = false;
            // 
            // frmAddEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Name = "frmAddEmployee";
            Text = "frmAddEmployee";
            Load += frmAddEmployee_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private GroupBox groupBox1;
        private Button button1;
        private ComboBox comboBox1;
        private Button button2;
        private Button btnInsertUpdate;
        private TextBox txtEmpID;
        private TextBox txtRequestorName;
        private TextBox txtEmailAddress;
        private TextBox txtLocalNumber;
        private ComboBox cmbSection;
        private Button btnDelete;
    }
}