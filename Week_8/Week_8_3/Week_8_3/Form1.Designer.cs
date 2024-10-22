namespace Week_8_3
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
            lbEnterClassId = new Label();
            tbEnterClassId = new TextBox();
            btnViewInDetail = new Button();
            btnViewListOfStudents = new Button();
            lbClassId = new Label();
            tbClassId = new TextBox();
            lbClassName = new Label();
            tbClassName = new TextBox();
            lbYear = new Label();
            tbYear = new TextBox();
            listViewOfStudents = new ListView();
            studentId = new ColumnHeader();
            studentName = new ColumnHeader();
            classId = new ColumnHeader();
            SuspendLayout();
            // 
            // lbEnterClassId
            // 
            lbEnterClassId.AutoSize = true;
            lbEnterClassId.Location = new Point(75, 69);
            lbEnterClassId.Name = "lbEnterClassId";
            lbEnterClassId.Size = new Size(77, 15);
            lbEnterClassId.TabIndex = 0;
            lbEnterClassId.Text = "Enter Class Id";
            // 
            // tbEnterClassId
            // 
            tbEnterClassId.Location = new Point(209, 66);
            tbEnterClassId.Name = "tbEnterClassId";
            tbEnterClassId.Size = new Size(206, 23);
            tbEnterClassId.TabIndex = 1;
            // 
            // btnViewInDetail
            // 
            btnViewInDetail.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnViewInDetail.Location = new Point(75, 112);
            btnViewInDetail.Name = "btnViewInDetail";
            btnViewInDetail.Size = new Size(340, 46);
            btnViewInDetail.TabIndex = 2;
            btnViewInDetail.Text = "View in Detail";
            btnViewInDetail.UseVisualStyleBackColor = true;
            btnViewInDetail.Click += btnViewInDetail_Click;
            // 
            // btnViewListOfStudents
            // 
            btnViewListOfStudents.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnViewListOfStudents.Location = new Point(457, 112);
            btnViewListOfStudents.Name = "btnViewListOfStudents";
            btnViewListOfStudents.Size = new Size(340, 46);
            btnViewListOfStudents.TabIndex = 2;
            btnViewListOfStudents.Text = "View List Of Students";
            btnViewListOfStudents.UseVisualStyleBackColor = true;
            btnViewListOfStudents.Click += btnViewListOfStudents_Click;
            // 
            // lbClassId
            // 
            lbClassId.AutoSize = true;
            lbClassId.Location = new Point(75, 178);
            lbClassId.Name = "lbClassId";
            lbClassId.Size = new Size(47, 15);
            lbClassId.TabIndex = 0;
            lbClassId.Text = "Class Id";
            // 
            // tbClassId
            // 
            tbClassId.Location = new Point(209, 175);
            tbClassId.Name = "tbClassId";
            tbClassId.ReadOnly = true;
            tbClassId.Size = new Size(206, 23);
            tbClassId.TabIndex = 1;
            // 
            // lbClassName
            // 
            lbClassName.AutoSize = true;
            lbClassName.Location = new Point(75, 226);
            lbClassName.Name = "lbClassName";
            lbClassName.Size = new Size(69, 15);
            lbClassName.TabIndex = 0;
            lbClassName.Text = "Class Name";
            // 
            // tbClassName
            // 
            tbClassName.Location = new Point(209, 223);
            tbClassName.Name = "tbClassName";
            tbClassName.ReadOnly = true;
            tbClassName.Size = new Size(206, 23);
            tbClassName.TabIndex = 1;
            // 
            // lbYear
            // 
            lbYear.AutoSize = true;
            lbYear.Location = new Point(75, 275);
            lbYear.Name = "lbYear";
            lbYear.Size = new Size(29, 15);
            lbYear.TabIndex = 0;
            lbYear.Text = "Year";
            // 
            // tbYear
            // 
            tbYear.Location = new Point(209, 272);
            tbYear.Name = "tbYear";
            tbYear.ReadOnly = true;
            tbYear.Size = new Size(206, 23);
            tbYear.TabIndex = 1;
            // 
            // listViewOfStudents
            // 
            listViewOfStudents.Columns.AddRange(new ColumnHeader[] { studentId, studentName, classId });
            listViewOfStudents.Location = new Point(457, 175);
            listViewOfStudents.Name = "listViewOfStudents";
            listViewOfStudents.Size = new Size(340, 120);
            listViewOfStudents.TabIndex = 3;
            listViewOfStudents.UseCompatibleStateImageBehavior = false;
            listViewOfStudents.View = View.Details;
 
            // 
            // studentId
            // 
            studentId.Text = "Student Id";
            // 
            // studentName
            // 
            studentName.Text = "Name";
            // 
            // classId
            // 
            classId.Text = "Class Id";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(894, 378);
            Controls.Add(listViewOfStudents);
            Controls.Add(btnViewListOfStudents);
            Controls.Add(btnViewInDetail);
            Controls.Add(tbYear);
            Controls.Add(lbYear);
            Controls.Add(tbClassName);
            Controls.Add(lbClassName);
            Controls.Add(tbClassId);
            Controls.Add(lbClassId);
            Controls.Add(tbEnterClassId);
            Controls.Add(lbEnterClassId);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbEnterClassId;
        private TextBox tbEnterClassId;
        private Button btnViewInDetail;
        private Button btnViewListOfStudents;
        private Label lbClassId;
        private TextBox tbClassId;
        private Label lbClassName;
        private TextBox tbClassName;
        private Label lbYear;
        private TextBox tbYear;
        private ListView listViewOfStudents;
        private ColumnHeader studentId;
        private ColumnHeader studentName;
        private ColumnHeader classId;
    }
}
