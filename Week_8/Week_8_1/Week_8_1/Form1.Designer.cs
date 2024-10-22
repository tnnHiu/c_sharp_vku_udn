namespace Week_8_1
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
            BtnConnect = new Button();
            BtnDisconnect = new Button();
            SuspendLayout();
            // 
            // BtnConnect
            // 
            BtnConnect.Location = new Point(177, 58);
            BtnConnect.Name = "BtnConnect";
            BtnConnect.Size = new Size(275, 84);
            BtnConnect.TabIndex = 0;
            BtnConnect.Text = "Connect";
            BtnConnect.UseVisualStyleBackColor = true;
            BtnConnect.Click += BtnConnect_Click;
            // 
            // BtnDisconnect
            // 
            BtnDisconnect.Location = new Point(177, 189);
            BtnDisconnect.Name = "BtnDisconnect";
            BtnDisconnect.Size = new Size(275, 94);
            BtnDisconnect.TabIndex = 1;
            BtnDisconnect.Text = "Disconnect";
            BtnDisconnect.UseVisualStyleBackColor = true;
            BtnDisconnect.Click += BtnDisconnect_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 450);
            Controls.Add(BtnDisconnect);
            Controls.Add(BtnConnect);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button BtnConnect;
        private Button BtnDisconnect;
    }
}
