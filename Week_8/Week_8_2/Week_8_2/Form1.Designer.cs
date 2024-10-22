namespace Week_8_2
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
            LbClassId = new Label();
            TbId = new TextBox();
            label1 = new Label();
            tbResult = new TextBox();
            btnCalNumOfStudents = new Button();
            SuspendLayout();
            // 
            // LbClassId
            // 
            LbClassId.AutoSize = true;
            LbClassId.Font = new Font("Segoe UI", 12F);
            LbClassId.Location = new Point(63, 111);
            LbClassId.Name = "LbClassId";
            LbClassId.Size = new Size(127, 28);
            LbClassId.TabIndex = 0;
            LbClassId.Text = "Enter Class Id";
            // 
            // TbId
            // 
            TbId.Font = new Font("Segoe UI", 12F);
            TbId.Location = new Point(257, 108);
            TbId.Margin = new Padding(3, 4, 3, 4);
            TbId.Name = "TbId";
            TbId.Size = new Size(251, 34);
            TbId.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(63, 179);
            label1.Name = "label1";
            label1.Size = new Size(188, 28);
            label1.TabIndex = 0;
            label1.Text = "Number of Students";
            // 
            // tbResult
            // 
            tbResult.Font = new Font("Segoe UI", 12F);
            tbResult.Location = new Point(257, 176);
            tbResult.Margin = new Padding(3, 4, 3, 4);
            tbResult.Name = "tbResult";
            tbResult.ReadOnly = true;
            tbResult.Size = new Size(251, 34);
            tbResult.TabIndex = 1;
            // 
            // btnCalNumOfStudents
            // 
            btnCalNumOfStudents.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalNumOfStudents.Location = new Point(63, 240);
            btnCalNumOfStudents.Margin = new Padding(3, 4, 3, 4);
            btnCalNumOfStudents.Name = "btnCalNumOfStudents";
            btnCalNumOfStudents.Size = new Size(445, 77);
            btnCalNumOfStudents.TabIndex = 2;
            btnCalNumOfStudents.Text = "Calculate Number of Students";
            btnCalNumOfStudents.UseVisualStyleBackColor = true;
            btnCalNumOfStudents.Click += btnCalNumOfStudents_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 421);
            Controls.Add(btnCalNumOfStudents);
            Controls.Add(tbResult);
            Controls.Add(label1);
            Controls.Add(TbId);
            Controls.Add(LbClassId);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LbClassId;
        private TextBox TbId;
        private Label label1;
        private TextBox tbResult;
        private Button btnCalNumOfStudents;
    }
}
