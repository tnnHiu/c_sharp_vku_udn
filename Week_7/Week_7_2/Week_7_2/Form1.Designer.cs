namespace Week_7_2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbTitle = new Label();
            lbEmpId = new Label();
            txtEmployeeId = new TextBox();
            lbEmpName = new Label();
            txtEmployeeName = new TextBox();
            lbPhone = new Label();
            lbDegree = new Label();
            lbGender = new Label();
            mtxtPhone = new MaskedTextBox();
            gbGender = new GroupBox();
            rdFemale = new RadioButton();
            rdMale = new RadioButton();
            cboDegree = new ComboBox();
            btnSave = new Button();
            btnCancel = new Button();
            fileSystemWatcher1 = new FileSystemWatcher();
            gbGender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.BorderStyle = BorderStyle.FixedSingle;
            lbTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            lbTitle.Location = new Point(156, 36);
            lbTitle.Margin = new Padding(6, 0, 6, 0);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(245, 40);
            lbTitle.TabIndex = 0;
            lbTitle.Text = "Employee Details";
            // 
            // lbEmpId
            // 
            lbEmpId.AutoSize = true;
            lbEmpId.Font = new Font("Segoe UI", 12F);
            lbEmpId.Location = new Point(45, 121);
            lbEmpId.Name = "lbEmpId";
            lbEmpId.Size = new Size(122, 28);
            lbEmpId.TabIndex = 1;
            lbEmpId.Text = "Employee ID";
            // 
            // txtEmployeeId
            // 
            txtEmployeeId.Font = new Font("Segoe UI", 12F);
            txtEmployeeId.Location = new Point(228, 115);
            txtEmployeeId.Name = "txtEmployeeId";
            txtEmployeeId.Size = new Size(279, 34);
            txtEmployeeId.TabIndex = 2;
            // 
            // lbEmpName
            // 
            lbEmpName.AutoSize = true;
            lbEmpName.Font = new Font("Segoe UI", 12F);
            lbEmpName.Location = new Point(45, 174);
            lbEmpName.Name = "lbEmpName";
            lbEmpName.Size = new Size(155, 28);
            lbEmpName.TabIndex = 1;
            lbEmpName.Text = "Employee Name";
            // 
            // txtEmployeeName
            // 
            txtEmployeeName.Font = new Font("Segoe UI", 12F);
            txtEmployeeName.Location = new Point(228, 168);
            txtEmployeeName.Name = "txtEmployeeName";
            txtEmployeeName.Size = new Size(279, 34);
            txtEmployeeName.TabIndex = 2;
            // 
            // lbPhone
            // 
            lbPhone.AutoSize = true;
            lbPhone.Font = new Font("Segoe UI", 12F);
            lbPhone.Location = new Point(45, 225);
            lbPhone.Name = "lbPhone";
            lbPhone.Size = new Size(67, 28);
            lbPhone.TabIndex = 1;
            lbPhone.Text = "Phone";
            // 
            // lbDegree
            // 
            lbDegree.AutoSize = true;
            lbDegree.Font = new Font("Segoe UI", 12F);
            lbDegree.Location = new Point(45, 353);
            lbDegree.Name = "lbDegree";
            lbDegree.Size = new Size(75, 28);
            lbDegree.TabIndex = 1;
            lbDegree.Text = "Degree";
            // 
            // lbGender
            // 
            lbGender.AutoSize = true;
            lbGender.Font = new Font("Segoe UI", 12F);
            lbGender.Location = new Point(45, 286);
            lbGender.Name = "lbGender";
            lbGender.Size = new Size(76, 28);
            lbGender.TabIndex = 1;
            lbGender.Text = "Gender";
            // 
            // mtxtPhone
            // 
            mtxtPhone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mtxtPhone.Location = new Point(228, 225);
            mtxtPhone.Mask = "000-0000000";
            mtxtPhone.Name = "mtxtPhone";
            mtxtPhone.Size = new Size(279, 34);
            mtxtPhone.TabIndex = 3;
            // 
            // gbGender
            // 
            gbGender.Controls.Add(rdFemale);
            gbGender.Controls.Add(rdMale);
            gbGender.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbGender.Location = new Point(228, 265);
            gbGender.Name = "gbGender";
            gbGender.Size = new Size(279, 62);
            gbGender.TabIndex = 4;
            gbGender.TabStop = false;
            // 
            // rdFemale
            // 
            rdFemale.AutoSize = true;
            rdFemale.Location = new Point(148, 19);
            rdFemale.Name = "rdFemale";
            rdFemale.Size = new Size(95, 32);
            rdFemale.TabIndex = 1;
            rdFemale.TabStop = true;
            rdFemale.Text = "Female";
            rdFemale.UseVisualStyleBackColor = true;
            // 
            // rdMale
            // 
            rdMale.AutoSize = true;
            rdMale.Checked = true;
            rdMale.Location = new Point(30, 19);
            rdMale.Name = "rdMale";
            rdMale.Size = new Size(76, 32);
            rdMale.TabIndex = 0;
            rdMale.TabStop = true;
            rdMale.Text = "Male";
            rdMale.UseVisualStyleBackColor = true;
            // 
            // cboDegree
            // 
            cboDegree.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboDegree.FormattingEnabled = true;
            cboDegree.Items.AddRange(new object[] { "Ph. D.", "Master", "Engineer", "Bachelor", "Technician" });
            cboDegree.Location = new Point(228, 345);
            cboDegree.Name = "cboDegree";
            cboDegree.Size = new Size(279, 36);
            cboDegree.TabIndex = 5;
            cboDegree.Text = "---Select Degree---";
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(184, 428);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(121, 37);
            btnSave.TabIndex = 6;
            btnSave.Text = "&Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 12F);
            btnCancel.Location = new Point(386, 428);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(121, 37);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "&Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // Form1
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(574, 512);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(cboDegree);
            Controls.Add(gbGender);
            Controls.Add(mtxtPhone);
            Controls.Add(lbDegree);
            Controls.Add(lbGender);
            Controls.Add(lbPhone);
            Controls.Add(txtEmployeeName);
            Controls.Add(lbEmpName);
            Controls.Add(txtEmployeeId);
            Controls.Add(lbEmpId);
            Controls.Add(lbTitle);
            Font = new Font("Segoe UI", 16.2F);
            Margin = new Padding(6);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Employee Details";
            Load += Form1_Load;
            gbGender.ResumeLayout(false);
            gbGender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTitle;
        private Label lbEmpId;
        private TextBox txtEmployeeId;
        private Label lbEmpName;
        private TextBox txtEmployeeName;
        private Label lbPhone;
        private TextBox textBox1;
        private Label lbDegree;
        private Label lbGender;
        private MaskedTextBox mtxtPhone;
        private GroupBox gbGender;
        private RadioButton rdFemale;
        private RadioButton rdMale;
        private ComboBox cboDegree;
        private Button btnSave;
        private Button btnCancel;
        private FileSystemWatcher fileSystemWatcher1;
    }
}
