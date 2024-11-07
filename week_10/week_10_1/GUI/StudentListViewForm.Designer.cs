namespace GUI
{
    partial class StudentListViewForm
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
            btnViewStudent = new Button();
            lvStudent = new ListView();
            studentId = new ColumnHeader();
            studentName = new ColumnHeader();
            classId = new ColumnHeader();
            SuspendLayout();
            // 
            // btnViewStudent
            // 
            btnViewStudent.BackColor = SystemColors.ActiveBorder;
            btnViewStudent.BackgroundImageLayout = ImageLayout.None;
            btnViewStudent.FlatAppearance.BorderColor = Color.Blue;
            btnViewStudent.FlatAppearance.MouseDownBackColor = Color.Blue;
            btnViewStudent.FlatAppearance.MouseOverBackColor = Color.Blue;
            btnViewStudent.FlatStyle = FlatStyle.Flat;
            btnViewStudent.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnViewStudent.Location = new Point(76, 41);
            btnViewStudent.Name = "btnViewStudent";
            btnViewStudent.Size = new Size(209, 57);
            btnViewStudent.TabIndex = 0;
            btnViewStudent.Text = "View Student Table";
            btnViewStudent.UseVisualStyleBackColor = false;
            btnViewStudent.Click += btnViewStudent_Click;
            // 
            // lvStudent
            // 
            lvStudent.Columns.AddRange(new ColumnHeader[] { studentId, studentName, classId });
            lvStudent.Location = new Point(12, 126);
            lvStudent.Name = "lvStudent";
            lvStudent.Size = new Size(336, 312);
            lvStudent.TabIndex = 1;
            lvStudent.UseCompatibleStateImageBehavior = false;
            lvStudent.View = View.Details;
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
            // StudentListViewForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(360, 450);
            Controls.Add(lvStudent);
            Controls.Add(btnViewStudent);
            Cursor = Cursors.IBeam;
            Name = "StudentListViewForm";
            Text = "StudentListViewForm";
            ResumeLayout(false);
        }

        #endregion

        private Button btnViewStudent;
        private ListView lvStudent;
        private ColumnHeader studentId;
        private ColumnHeader studentName;
        private ColumnHeader classId;
    }
}