namespace Week_8_4
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
            lbListOfStudents = new Label();
            listOfClasses = new ListBox();
            lbListOfClasses = new Label();
            listOfStudents = new ListView();
            studentId = new ColumnHeader();
            name = new ColumnHeader();
            classId = new ColumnHeader();
            SuspendLayout();
            // 
            // lbListOfStudents
            // 
            lbListOfStudents.AutoSize = true;
            lbListOfStudents.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbListOfStudents.Location = new Point(494, 60);
            lbListOfStudents.Name = "lbListOfStudents";
            lbListOfStudents.Size = new Size(163, 28);
            lbListOfStudents.TabIndex = 0;
            lbListOfStudents.Text = "List Of Students";
            // 
            // listOfClasses
            // 
            listOfClasses.FormattingEnabled = true;
            listOfClasses.Location = new Point(12, 105);
            listOfClasses.Name = "listOfClasses";
            listOfClasses.Size = new Size(350, 204);
            listOfClasses.TabIndex = 1;
            listOfClasses.SelectedIndexChanged += listOfClasses_SelectedIndexChanged;
            // 
            // lbListOfClasses
            // 
            lbListOfClasses.AutoSize = true;
            lbListOfClasses.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbListOfClasses.Location = new Point(115, 60);
            lbListOfClasses.Name = "lbListOfClasses";
            lbListOfClasses.Size = new Size(147, 28);
            lbListOfClasses.TabIndex = 0;
            lbListOfClasses.Text = "List Of Classes";
            // 
            // listOfStudents
            // 
            listOfStudents.Columns.AddRange(new ColumnHeader[] { studentId, name, classId });
            listOfStudents.Location = new Point(403, 106);
            listOfStudents.Name = "listOfStudents";
            listOfStudents.Size = new Size(350, 204);
            listOfStudents.TabIndex = 2;
            listOfStudents.UseCompatibleStateImageBehavior = false;
            listOfStudents.View = View.Details;
            // 
            // studentId
            // 
            studentId.Text = "Student Id";
            // 
            // name
            // 
            name.Text = "Name";
            // 
            // classId
            // 
            classId.Text = "Class ID";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(781, 362);
            Controls.Add(listOfStudents);
            Controls.Add(listOfClasses);
            Controls.Add(lbListOfClasses);
            Controls.Add(lbListOfStudents);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbListOfStudents;
        private ListBox listOfClasses;
        private Label lbListOfClasses;
        private ListView listOfStudents;
        private ColumnHeader studentId;
        private ColumnHeader name;
        private ColumnHeader classId;
    }
}
