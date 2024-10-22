namespace Week_7
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
            tbNum1 = new TextBox();
            lb = new Label();
            tbNum2 = new TextBox();
            label2 = new Label();
            tbSum = new TextBox();
            label3 = new Label();
            btnAdd = new Button();
            btnRefresh = new Button();
            btnExit = new Button();
            lbMain = new Label();
            SuspendLayout();
            // 
            // tbNum1
            // 
            tbNum1.Location = new Point(167, 149);
            tbNum1.Name = "tbNum1";
            tbNum1.Size = new Size(292, 27);
            tbNum1.TabIndex = 0;
            // 
            // lb
            // 
            lb.AutoSize = true;
            lb.Location = new Point(53, 152);
            lb.Name = "lb";
            lb.Size = new Size(85, 20);
            lb.TabIndex = 1;
            lb.Text = "Số thứ nhất";
            // 
            // tbNum2
            // 
            tbNum2.Location = new Point(167, 204);
            tbNum2.Name = "tbNum2";
            tbNum2.Size = new Size(292, 27);
            tbNum2.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 207);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 1;
            label2.Text = "Số thứ hai";
            // 
            // tbSum
            // 
            tbSum.Location = new Point(167, 265);
            tbSum.Name = "tbSum";
            tbSum.ReadOnly = true;
            tbSum.Size = new Size(292, 27);
            tbSum.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(53, 268);
            label3.Name = "label3";
            label3.Size = new Size(43, 20);
            label3.TabIndex = 1;
            label3.Text = "Tổng";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(55, 337);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Tính tổng";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(207, 337);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(94, 29);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "Nhập lại";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(365, 337);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 4;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lbMain
            // 
            lbMain.AutoSize = true;
            lbMain.BorderStyle = BorderStyle.Fixed3D;
            lbMain.Font = new Font("Segoe UI", 20F);
            lbMain.Location = new Point(55, 50);
            lbMain.Name = "lbMain";
            lbMain.Size = new Size(400, 48);
            lbMain.TabIndex = 5;
            lbMain.Text = "Chương trình cộng hai số";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(527, 450);
            Controls.Add(lbMain);
            Controls.Add(btnExit);
            Controls.Add(btnRefresh);
            Controls.Add(btnAdd);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lb);
            Controls.Add(tbSum);
            Controls.Add(tbNum2);
            Controls.Add(tbNum1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbNum1;
        private Label lb;
        private TextBox tbNum2;
        private Label label2;
        private TextBox tbSum;
        private Label label3;
        private Button btnAdd;
        private Button btnRefresh;
        private Button btnExit;
        private Label lbMain;
    }
}
