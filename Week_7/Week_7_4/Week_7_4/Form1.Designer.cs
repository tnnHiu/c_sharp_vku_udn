namespace Week_7_4
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
            gbArray = new GroupBox();
            TxtArray = new TextBox();
            gbResult = new GroupBox();
            TxtResult = new TextBox();
            BtnXuatMang = new Button();
            BtnPhanTuNhoNhat = new Button();
            BtnTongGiaTri = new Button();
            BtnDemPhanTuLe = new Button();
            BtnTongLe = new Button();
            BtnTang2 = new Button();
            BtnSapXepTang = new Button();
            BtnSapXepGiam = new Button();
            gbArray.SuspendLayout();
            gbResult.SuspendLayout();
            SuspendLayout();
            // 
            // gbArray
            // 
            gbArray.Controls.Add(TxtArray);
            gbArray.Location = new Point(34, 46);
            gbArray.Name = "gbArray";
            gbArray.Size = new Size(569, 68);
            gbArray.TabIndex = 0;
            gbArray.TabStop = false;
            gbArray.Text = "Mảng gốc";
            // 
            // TxtArray
            // 
            TxtArray.Location = new Point(6, 26);
            TxtArray.Name = "TxtArray";
            TxtArray.ReadOnly = true;
            TxtArray.Size = new Size(557, 27);
            TxtArray.TabIndex = 1;
            // 
            // gbResult
            // 
            gbResult.Controls.Add(TxtResult);
            gbResult.Location = new Point(34, 138);
            gbResult.Name = "gbResult";
            gbResult.Size = new Size(569, 68);
            gbResult.TabIndex = 1;
            gbResult.TabStop = false;
            gbResult.Text = "Kết quả";
            // 
            // TxtResult
            // 
            TxtResult.Location = new Point(6, 26);
            TxtResult.Name = "TxtResult";
            TxtResult.ReadOnly = true;
            TxtResult.Size = new Size(557, 27);
            TxtResult.TabIndex = 2;
            // 
            // BtnXuatMang
            // 
            BtnXuatMang.Location = new Point(34, 228);
            BtnXuatMang.Name = "BtnXuatMang";
            BtnXuatMang.Size = new Size(250, 30);
            BtnXuatMang.TabIndex = 2;
            BtnXuatMang.Text = "Xuất mảng ngẫu nhiên";
            BtnXuatMang.UseVisualStyleBackColor = true;
            BtnXuatMang.Click += BtnXuatMang_Click;
            // 
            // BtnPhanTuNhoNhat
            // 
            BtnPhanTuNhoNhat.Location = new Point(353, 228);
            BtnPhanTuNhoNhat.Name = "BtnPhanTuNhoNhat";
            BtnPhanTuNhoNhat.Size = new Size(250, 30);
            BtnPhanTuNhoNhat.TabIndex = 3;
            BtnPhanTuNhoNhat.Text = "Tìm phần tử nhỏ nhất";
            BtnPhanTuNhoNhat.UseVisualStyleBackColor = true;
            BtnPhanTuNhoNhat.Click += BtnPhanTuNhoNhat_Click;
            // 
            // BtnTongGiaTri
            // 
            BtnTongGiaTri.Location = new Point(34, 264);
            BtnTongGiaTri.Name = "BtnTongGiaTri";
            BtnTongGiaTri.Size = new Size(250, 30);
            BtnTongGiaTri.TabIndex = 2;
            BtnTongGiaTri.Text = "Tính tổng giá trị mảng";
            BtnTongGiaTri.UseVisualStyleBackColor = true;
            BtnTongGiaTri.Click += BtnTongGiaTri_Click;
            // 
            // BtnDemPhanTuLe
            // 
            BtnDemPhanTuLe.Location = new Point(34, 300);
            BtnDemPhanTuLe.Name = "BtnDemPhanTuLe";
            BtnDemPhanTuLe.Size = new Size(250, 30);
            BtnDemPhanTuLe.TabIndex = 2;
            BtnDemPhanTuLe.Text = "Đếm số phần tử lẻ";
            BtnDemPhanTuLe.UseVisualStyleBackColor = true;
            BtnDemPhanTuLe.Click += BtnDemPhanTuLe_Click;
            // 
            // BtnTongLe
            // 
            BtnTongLe.Location = new Point(34, 336);
            BtnTongLe.Name = "BtnTongLe";
            BtnTongLe.Size = new Size(250, 30);
            BtnTongLe.TabIndex = 2;
            BtnTongLe.Text = "Tổng giá trị phần tử lẻ";
            BtnTongLe.UseVisualStyleBackColor = true;
            BtnTongLe.Click += BtnTongLe_Click;
            // 
            // BtnTang2
            // 
            BtnTang2.Location = new Point(353, 264);
            BtnTang2.Name = "BtnTang2";
            BtnTang2.Size = new Size(250, 30);
            BtnTang2.TabIndex = 3;
            BtnTang2.Text = "Tăng mỗi phần tử lên 2";
            BtnTang2.UseVisualStyleBackColor = true;
            BtnTang2.Click += BtnTang2_Click;
            // 
            // BtnSapXepTang
            // 
            BtnSapXepTang.Location = new Point(353, 300);
            BtnSapXepTang.Name = "BtnSapXepTang";
            BtnSapXepTang.Size = new Size(250, 30);
            BtnSapXepTang.TabIndex = 3;
            BtnSapXepTang.Text = "Sắp xếp mảng tăng";
            BtnSapXepTang.UseVisualStyleBackColor = true;
            BtnSapXepTang.Click += BtnSapXepTang_Click;
            // 
            // BtnSapXepGiam
            // 
            BtnSapXepGiam.Location = new Point(353, 336);
            BtnSapXepGiam.Name = "BtnSapXepGiam";
            BtnSapXepGiam.Size = new Size(250, 30);
            BtnSapXepGiam.TabIndex = 3;
            BtnSapXepGiam.Text = "Sắp xếp mảng giảm";
            BtnSapXepGiam.UseVisualStyleBackColor = true;
            BtnSapXepGiam.Click += BtnSapXepGiam_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(634, 396);
            Controls.Add(BtnSapXepGiam);
            Controls.Add(BtnSapXepTang);
            Controls.Add(BtnTang2);
            Controls.Add(BtnPhanTuNhoNhat);
            Controls.Add(BtnTongLe);
            Controls.Add(BtnDemPhanTuLe);
            Controls.Add(BtnTongGiaTri);
            Controls.Add(BtnXuatMang);
            Controls.Add(gbResult);
            Controls.Add(gbArray);
            Name = "Form1";
            Text = "Working With Array";
            Load += Form1_Load;
            gbArray.ResumeLayout(false);
            gbArray.PerformLayout();
            gbResult.ResumeLayout(false);
            gbResult.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbArray;
        private TextBox TxtArray;
        private GroupBox gbResult;
        private TextBox TxtResult;
        private Button BtnXuatMang;
        private Button BtnPhanTuNhoNhat;
        private Button BtnTongGiaTri;
        private Button BtnDemPhanTuLe;
        private Button BtnTongLe;
        private Button BtnTang2;
        private Button BtnSapXepTang;
        private Button BtnSapXepGiam;
    }
}
