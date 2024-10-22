namespace Week_9_1
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
            dgvStudent = new DataGridView();
            grbStudentInfo = new GroupBox();
            txtClassId = new TextBox();
            txtStudentName = new TextBox();
            txtStudentId = new TextBox();
            lbClassId = new Label();
            lbStudentName = new Label();
            lbStudentId = new Label();
            btnInsert = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnLoad = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvStudent).BeginInit();
            grbStudentInfo.SuspendLayout();
            SuspendLayout();
            // 
            // dgvStudent
            // 
            dgvStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudent.Location = new Point(12, 107);
            dgvStudent.MultiSelect = false;
            dgvStudent.Name = "dgvStudent";
            dgvStudent.Size = new Size(497, 331);
            dgvStudent.TabIndex = 1;
            dgvStudent.CellContentClick += dgvStudent_CellContentClick;
            // 
            // grbStudentInfo
            // 
            grbStudentInfo.Controls.Add(txtClassId);
            grbStudentInfo.Controls.Add(txtStudentName);
            grbStudentInfo.Controls.Add(txtStudentId);
            grbStudentInfo.Controls.Add(lbClassId);
            grbStudentInfo.Controls.Add(lbStudentName);
            grbStudentInfo.Controls.Add(lbStudentId);
            grbStudentInfo.Location = new Point(526, 107);
            grbStudentInfo.Name = "grbStudentInfo";
            grbStudentInfo.Size = new Size(347, 224);
            grbStudentInfo.TabIndex = 2;
            grbStudentInfo.TabStop = false;
            grbStudentInfo.Text = "Student Information";
            // 
            // txtClassId
            // 
            txtClassId.Location = new Point(139, 172);
            txtClassId.Name = "txtClassId";
            txtClassId.Size = new Size(202, 23);
            txtClassId.TabIndex = 1;
            // 
            // txtStudentName
            // 
            txtStudentName.Location = new Point(139, 111);
            txtStudentName.Name = "txtStudentName";
            txtStudentName.Size = new Size(202, 23);
            txtStudentName.TabIndex = 1;
            // 
            // txtStudentId
            // 
            txtStudentId.Location = new Point(139, 47);
            txtStudentId.Name = "txtStudentId";
            txtStudentId.Size = new Size(202, 23);
            txtStudentId.TabIndex = 1;
            // 
            // lbClassId
            // 
            lbClassId.AutoSize = true;
            lbClassId.Location = new Point(16, 175);
            lbClassId.Name = "lbClassId";
            lbClassId.Size = new Size(44, 15);
            lbClassId.TabIndex = 0;
            lbClassId.Text = "ClassId";
            // 
            // lbStudentName
            // 
            lbStudentName.AutoSize = true;
            lbStudentName.Location = new Point(16, 114);
            lbStudentName.Name = "lbStudentName";
            lbStudentName.Size = new Size(83, 15);
            lbStudentName.TabIndex = 0;
            lbStudentName.Text = "Student Name";
            // 
            // lbStudentId
            // 
            lbStudentId.AutoSize = true;
            lbStudentId.Location = new Point(16, 50);
            lbStudentId.Name = "lbStudentId";
            lbStudentId.Size = new Size(61, 15);
            lbStudentId.TabIndex = 0;
            lbStudentId.Text = "Student Id";
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(542, 354);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(86, 43);
            btnInsert.TabIndex = 3;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(665, 354);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(86, 43);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(787, 354);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(86, 43);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnLoad
            // 
            btnLoad.BackColor = SystemColors.ActiveBorder;
            btnLoad.BackgroundImageLayout = ImageLayout.None;
            btnLoad.FlatStyle = FlatStyle.Popup;
            btnLoad.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLoad.Location = new Point(175, 38);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(146, 51);
            btnLoad.TabIndex = 4;
            btnLoad.Text = "Load table Student on DataGridView";
            btnLoad.UseVisualStyleBackColor = false;
            btnLoad.Click += btnLoad_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(885, 450);
            Controls.Add(btnLoad);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(grbStudentInfo);
            Controls.Add(dgvStudent);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStudent).EndInit();
            grbStudentInfo.ResumeLayout(false);
            grbStudentInfo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgvStudent;
        private GroupBox grbStudentInfo;
        private Button btnInsert;
        private Button btnUpdate;
        private Button btnDelete;
        private TextBox txtStudentId;
        private Label lbClassId;
        private Label lbStudentName;
        private Label lbStudentId;
        private TextBox txtClassId;
        private TextBox txtStudentName;
        private Button btnLoad;
    }
}
