namespace Week_8_5
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
            lvwStudent = new ListView();
            studentId = new ColumnHeader();
            studentName = new ColumnHeader();
            classId = new ColumnHeader();
            groupBox1 = new GroupBox();
            txtClassId = new TextBox();
            lbClassId = new Label();
            txtFullName = new TextBox();
            lbFullName = new Label();
            txtStudentId = new TextBox();
            lbStudentId = new Label();
            btnInsert = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lvwStudent
            // 
            lvwStudent.Columns.AddRange(new ColumnHeader[] { studentId, studentName, classId });
            lvwStudent.Location = new Point(12, 12);
            lvwStudent.Name = "lvwStudent";
            lvwStudent.Size = new Size(445, 426);
            lvwStudent.TabIndex = 0;
            lvwStudent.UseCompatibleStateImageBehavior = false;
            lvwStudent.View = View.Details;
            lvwStudent.SelectedIndexChanged += lvwStudent_SelectedIndexChanged;
            // 
            // studentId
            // 
            studentId.Text = "Student Id";
            // 
            // studentName
            // 
            studentName.Text = "Full Name";
            // 
            // classId
            // 
            classId.Text = "Class Id";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtClassId);
            groupBox1.Controls.Add(lbClassId);
            groupBox1.Controls.Add(txtFullName);
            groupBox1.Controls.Add(lbFullName);
            groupBox1.Controls.Add(txtStudentId);
            groupBox1.Controls.Add(lbStudentId);
            groupBox1.Location = new Point(468, 15);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(367, 142);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Student Information";
            // 
            // txtClassId
            // 
            txtClassId.Location = new Point(89, 99);
            txtClassId.Name = "txtClassId";
            txtClassId.Size = new Size(251, 27);
            txtClassId.TabIndex = 1;
            // 
            // lbClassId
            // 
            lbClassId.AutoSize = true;
            lbClassId.Location = new Point(6, 102);
            lbClassId.Name = "lbClassId";
            lbClassId.Size = new Size(59, 20);
            lbClassId.TabIndex = 0;
            lbClassId.Text = "Class Id";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(89, 66);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(251, 27);
            txtFullName.TabIndex = 1;
            // 
            // lbFullName
            // 
            lbFullName.AutoSize = true;
            lbFullName.Location = new Point(6, 69);
            lbFullName.Name = "lbFullName";
            lbFullName.Size = new Size(76, 20);
            lbFullName.TabIndex = 0;
            lbFullName.Text = "Full Name";
            // 
            // txtStudentId
            // 
            txtStudentId.Location = new Point(89, 33);
            txtStudentId.Name = "txtStudentId";
            txtStudentId.Size = new Size(251, 27);
            txtStudentId.TabIndex = 1;
            // 
            // lbStudentId
            // 
            lbStudentId.AutoSize = true;
            lbStudentId.Location = new Point(6, 36);
            lbStudentId.Name = "lbStudentId";
            lbStudentId.Size = new Size(77, 20);
            lbStudentId.TabIndex = 0;
            lbStudentId.Text = "Student Id";
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(463, 174);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(120, 60);
            btnInsert.TabIndex = 2;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(589, 174);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(120, 60);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(715, 174);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(120, 60);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(841, 447);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(groupBox1);
            Controls.Add(lvwStudent);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListView lvwStudent;
        private GroupBox groupBox1;
        private TextBox txtClassId;
        private Label lbClassId;
        private TextBox txtFullName;
        private Label lbFullName;
        private TextBox txtStudentId;
        private Label lbStudentId;
        private Button btnInsert;
        private Button btnUpdate;
        private Button btnDelete;
        private ColumnHeader studentId;
        private ColumnHeader studentName;
        private ColumnHeader classId;
    }
}
