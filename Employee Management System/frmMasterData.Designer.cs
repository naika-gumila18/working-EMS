namespace Employee_Management_System
{
    partial class frmMasterData
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            pnlChildTitle = new Panel();
            lblMasterData = new Label();
            dtgMasterData = new DataGridView();
            btnEditData = new Button();
            lblTransactionNo = new Label();
            pnlChildTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgMasterData).BeginInit();
            SuspendLayout();
            // 
            // pnlChildTitle
            // 
            pnlChildTitle.BackColor = SystemColors.ActiveCaption;
            pnlChildTitle.Controls.Add(lblMasterData);
            pnlChildTitle.Dock = DockStyle.Top;
            pnlChildTitle.Location = new Point(0, 0);
            pnlChildTitle.Name = "pnlChildTitle";
            pnlChildTitle.Size = new Size(748, 57);
            pnlChildTitle.TabIndex = 0;
            // 
            // lblMasterData
            // 
            lblMasterData.AutoSize = true;
            lblMasterData.Font = new Font("Sitka Heading", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMasterData.Location = new Point(3, 18);
            lblMasterData.Name = "lblMasterData";
            lblMasterData.Size = new Size(97, 23);
            lblMasterData.TabIndex = 0;
            lblMasterData.Text = "Master Data";
            // 
            // dtgMasterData
            // 
            dtgMasterData.BackgroundColor = SystemColors.ScrollBar;
            dtgMasterData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgMasterData.Dock = DockStyle.Fill;
            dtgMasterData.Location = new Point(0, 57);
            dtgMasterData.Name = "dtgMasterData";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.BottomLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtgMasterData.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtgMasterData.Size = new Size(748, 266);
            dtgMasterData.TabIndex = 1;
            dtgMasterData.CellClick += dtgMasterData_CellClick;
            dtgMasterData.CellContentClick += dtgMasterData_CellContentClick;
            dtgMasterData.RowHeaderMouseClick += dtgMasterData_RowHeaderMouseClick;
            // 
            // btnEditData
            // 
            btnEditData.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEditData.BackColor = SystemColors.ActiveCaption;
            btnEditData.Location = new Point(627, 329);
            btnEditData.Name = "btnEditData";
            btnEditData.Size = new Size(106, 33);
            btnEditData.TabIndex = 2;
            btnEditData.Text = "Edit Data";
            btnEditData.UseVisualStyleBackColor = false;
            btnEditData.Click += btnEditData_Click;
            // 
            // lblTransactionNo
            // 
            lblTransactionNo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblTransactionNo.AutoSize = true;
            lblTransactionNo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTransactionNo.Location = new Point(12, 333);
            lblTransactionNo.Name = "lblTransactionNo";
            lblTransactionNo.Size = new Size(205, 21);
            lblTransactionNo.TabIndex = 3;
            lblTransactionNo.Text = "<TRANSACTION NUMBER>";
            // 
            // frmMasterData
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(748, 373);
            Controls.Add(lblTransactionNo);
            Controls.Add(btnEditData);
            Controls.Add(dtgMasterData);
            Controls.Add(pnlChildTitle);
            Name = "frmMasterData";
            Padding = new Padding(0, 0, 0, 50);
            Text = "frmMasterData";
            Load += frmMasterData_Load;
            pnlChildTitle.ResumeLayout(false);
            pnlChildTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgMasterData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlChildTitle;
        private Label lblMasterData;
        private DataGridView dtgMasterData;
        private Button btnEditData;
        private Label lblTransactionNo;
    }
}