namespace GUI_Student_Management
{
    partial class StudentManagementForm
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
            gbInfo = new GroupBox();
            txtClassId = new TextBox();
            lbClassId = new Label();
            txtFullName = new TextBox();
            lbFullName = new Label();
            txtStudentId = new TextBox();
            lbStudentId = new Label();
            btnInsert = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            dgvStudent = new DataGridView();
            gbInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStudent).BeginInit();
            SuspendLayout();
            // 
            // gbInfo
            // 
            gbInfo.Controls.Add(txtClassId);
            gbInfo.Controls.Add(lbClassId);
            gbInfo.Controls.Add(txtFullName);
            gbInfo.Controls.Add(lbFullName);
            gbInfo.Controls.Add(txtStudentId);
            gbInfo.Controls.Add(lbStudentId);
            gbInfo.Location = new Point(42, 36);
            gbInfo.Name = "gbInfo";
            gbInfo.Size = new Size(486, 175);
            gbInfo.TabIndex = 0;
            gbInfo.TabStop = false;
            gbInfo.Text = "Student Information";
            // 
            // txtClassId
            // 
            txtClassId.Location = new Point(154, 127);
            txtClassId.Name = "txtClassId";
            txtClassId.Size = new Size(293, 23);
            txtClassId.TabIndex = 2;
            // 
            // lbClassId
            // 
            lbClassId.AutoSize = true;
            lbClassId.Location = new Point(19, 130);
            lbClassId.Name = "lbClassId";
            lbClassId.Size = new Size(47, 15);
            lbClassId.TabIndex = 1;
            lbClassId.Text = "Class Id";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(154, 82);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(293, 23);
            txtFullName.TabIndex = 2;
            // 
            // lbFullName
            // 
            lbFullName.AutoSize = true;
            lbFullName.Location = new Point(19, 85);
            lbFullName.Name = "lbFullName";
            lbFullName.Size = new Size(61, 15);
            lbFullName.TabIndex = 1;
            lbFullName.Text = "Full Name";
            // 
            // txtStudentId
            // 
            txtStudentId.Location = new Point(154, 37);
            txtStudentId.Name = "txtStudentId";
            txtStudentId.Size = new Size(293, 23);
            txtStudentId.TabIndex = 2;
            // 
            // lbStudentId
            // 
            lbStudentId.AutoSize = true;
            lbStudentId.Location = new Point(19, 40);
            lbStudentId.Name = "lbStudentId";
            lbStudentId.Size = new Size(61, 15);
            lbStudentId.TabIndex = 1;
            lbStudentId.Text = "Student Id";
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(587, 36);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(100, 42);
            btnInsert.TabIndex = 1;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(587, 99);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(100, 42);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(587, 169);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 42);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvStudent
            // 
            dgvStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudent.Location = new Point(42, 217);
            dgvStudent.Name = "dgvStudent";
            dgvStudent.Size = new Size(645, 221);
            dgvStudent.TabIndex = 2;
            dgvStudent.CellContentClick += dgvStudent_CellContentClick;
            // 
            // StudentManagementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(724, 450);
            Controls.Add(dgvStudent);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(gbInfo);
            Name = "StudentManagementForm";
            Text = "StudentManagementForm";
            Load += StudentManagementForm_Load;
            gbInfo.ResumeLayout(false);
            gbInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStudent).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbInfo;
        private TextBox txtClassId;
        private Label lbClassId;
        private TextBox txtFullName;
        private Label lbFullName;
        private TextBox txtStudentId;
        private Label lbStudentId;
        private Button btnInsert;
        private Button btnUpdate;
        private Button btnDelete;
        private DataGridView dgvStudent;
    }
}