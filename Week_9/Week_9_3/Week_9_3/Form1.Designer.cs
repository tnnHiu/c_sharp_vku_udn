namespace Week_9_3
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.sTUDENT_MANAGEMENTDataSet = new Week_9_3.STUDENT_MANAGEMENTDataSet();
            this.sTUDENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sTUDENTTableAdapter = new Week_9_3.STUDENT_MANAGEMENTDataSetTableAdapters.STUDENTTableAdapter();
            this.tableAdapterManager = new Week_9_3.STUDENT_MANAGEMENTDataSetTableAdapters.TableAdapterManager();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnView = new System.Windows.Forms.Button();
            this.cLASSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cLASSTableAdapter = new Week_9_3.STUDENT_MANAGEMENTDataSetTableAdapters.CLASSTableAdapter();
            this.sTUDENTBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cLASSBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cLASSBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.cboClassId = new System.Windows.Forms.ComboBox();
            this.cLASSBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.cboClassName = new System.Windows.Forms.ComboBox();
            this.cLASSBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.cboYear = new System.Windows.Forms.ComboBox();
            this.lbClassId = new System.Windows.Forms.Label();
            this.lbClassName = new System.Windows.Forms.Label();
            this.lbYear = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENT_MANAGEMENTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLASSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLASSBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLASSBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLASSBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLASSBindingSource4)).BeginInit();
            this.SuspendLayout();
            // 
            // sTUDENT_MANAGEMENTDataSet
            // 
            this.sTUDENT_MANAGEMENTDataSet.DataSetName = "STUDENT_MANAGEMENTDataSet";
            this.sTUDENT_MANAGEMENTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sTUDENTBindingSource
            // 
            this.sTUDENTBindingSource.DataMember = "STUDENT";
            this.sTUDENTBindingSource.DataSource = this.sTUDENT_MANAGEMENTDataSet;
            // 
            // sTUDENTTableAdapter
            // 
            this.sTUDENTTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CLASSTableAdapter = null;
            this.tableAdapterManager.STUDENTTableAdapter = this.sTUDENTTableAdapter;
            this.tableAdapterManager.UpdateOrder = Week_9_3.STUDENT_MANAGEMENTDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dgvStudents
            // 
            this.dgvStudents.AutoGenerateColumns = false;
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dgvStudents.DataSource = this.sTUDENTBindingSource;
            this.dgvStudents.Location = new System.Drawing.Point(12, 158);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.Size = new System.Drawing.Size(343, 220);
            this.dgvStudents.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "StudentID";
            this.dataGridViewTextBoxColumn1.HeaderText = "StudentID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ClassID";
            this.dataGridViewTextBoxColumn3.HeaderText = "ClassID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // btnView
            // 
            this.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.Location = new System.Drawing.Point(277, 49);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(78, 39);
            this.btnView.TabIndex = 7;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // cLASSBindingSource
            // 
            this.cLASSBindingSource.DataMember = "CLASS";
            this.cLASSBindingSource.DataSource = this.sTUDENT_MANAGEMENTDataSet;
            // 
            // cLASSTableAdapter
            // 
            this.cLASSTableAdapter.ClearBeforeFill = true;
            // 
            // sTUDENTBindingSource1
            // 
            this.sTUDENTBindingSource1.DataMember = "STUDENT";
            this.sTUDENTBindingSource1.DataSource = this.sTUDENT_MANAGEMENTDataSet;
            // 
            // cLASSBindingSource1
            // 
            this.cLASSBindingSource1.DataMember = "CLASS";
            this.cLASSBindingSource1.DataSource = this.sTUDENT_MANAGEMENTDataSet;
            // 
            // cLASSBindingSource2
            // 
            this.cLASSBindingSource2.DataMember = "CLASS";
            this.cLASSBindingSource2.DataSource = this.sTUDENT_MANAGEMENTDataSet;
            // 
            // cboClassId
            // 
            this.cboClassId.DataSource = this.cLASSBindingSource2;
            this.cboClassId.DisplayMember = "ClassID";
            this.cboClassId.FormattingEnabled = true;
            this.cboClassId.Location = new System.Drawing.Point(87, 32);
            this.cboClassId.Name = "cboClassId";
            this.cboClassId.Size = new System.Drawing.Size(153, 21);
            this.cboClassId.TabIndex = 7;
            // 
            // cLASSBindingSource3
            // 
            this.cLASSBindingSource3.DataMember = "CLASS";
            this.cLASSBindingSource3.DataSource = this.sTUDENT_MANAGEMENTDataSet;
            // 
            // cboClassName
            // 
            this.cboClassName.DataSource = this.cLASSBindingSource3;
            this.cboClassName.DisplayMember = "ClassName";
            this.cboClassName.FormattingEnabled = true;
            this.cboClassName.Location = new System.Drawing.Point(87, 59);
            this.cboClassName.Name = "cboClassName";
            this.cboClassName.Size = new System.Drawing.Size(153, 21);
            this.cboClassName.TabIndex = 7;
            // 
            // cLASSBindingSource4
            // 
            this.cLASSBindingSource4.DataMember = "CLASS";
            this.cLASSBindingSource4.DataSource = this.sTUDENT_MANAGEMENTDataSet;
            // 
            // cboYear
            // 
            this.cboYear.DataSource = this.cLASSBindingSource4;
            this.cboYear.DisplayMember = "Year";
            this.cboYear.FormattingEnabled = true;
            this.cboYear.Location = new System.Drawing.Point(87, 89);
            this.cboYear.Name = "cboYear";
            this.cboYear.Size = new System.Drawing.Size(153, 21);
            this.cboYear.TabIndex = 7;
            // 
            // lbClassId
            // 
            this.lbClassId.AutoSize = true;
            this.lbClassId.Location = new System.Drawing.Point(16, 35);
            this.lbClassId.Name = "lbClassId";
            this.lbClassId.Size = new System.Drawing.Size(44, 13);
            this.lbClassId.TabIndex = 8;
            this.lbClassId.Text = "Class Id";
            // 
            // lbClassName
            // 
            this.lbClassName.AutoSize = true;
            this.lbClassName.Location = new System.Drawing.Point(16, 62);
            this.lbClassName.Name = "lbClassName";
            this.lbClassName.Size = new System.Drawing.Size(63, 13);
            this.lbClassName.TabIndex = 8;
            this.lbClassName.Text = "Class Name";
            // 
            // lbYear
            // 
            this.lbYear.AutoSize = true;
            this.lbYear.Location = new System.Drawing.Point(16, 92);
            this.lbYear.Name = "lbYear";
            this.lbYear.Size = new System.Drawing.Size(29, 13);
            this.lbYear.TabIndex = 8;
            this.lbYear.Text = "Year";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 398);
            this.Controls.Add(this.lbYear);
            this.Controls.Add(this.lbClassName);
            this.Controls.Add(this.lbClassId);
            this.Controls.Add(this.cboYear);
            this.Controls.Add(this.cboClassName);
            this.Controls.Add(this.cboClassId);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.dgvStudents);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENT_MANAGEMENTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLASSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLASSBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLASSBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLASSBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLASSBindingSource4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private STUDENT_MANAGEMENTDataSet sTUDENT_MANAGEMENTDataSet;
        private System.Windows.Forms.BindingSource sTUDENTBindingSource;
        private STUDENT_MANAGEMENTDataSetTableAdapters.STUDENTTableAdapter sTUDENTTableAdapter;
        private STUDENT_MANAGEMENTDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.BindingSource cLASSBindingSource;
        private STUDENT_MANAGEMENTDataSetTableAdapters.CLASSTableAdapter cLASSTableAdapter;
        private System.Windows.Forms.BindingSource sTUDENTBindingSource1;
        private System.Windows.Forms.BindingSource cLASSBindingSource1;
        private System.Windows.Forms.BindingSource cLASSBindingSource2;
        private System.Windows.Forms.ComboBox cboClassId;
        private System.Windows.Forms.BindingSource cLASSBindingSource3;
        private System.Windows.Forms.ComboBox cboClassName;
        private System.Windows.Forms.BindingSource cLASSBindingSource4;
        private System.Windows.Forms.ComboBox cboYear;
        private System.Windows.Forms.Label lbClassId;
        private System.Windows.Forms.Label lbClassName;
        private System.Windows.Forms.Label lbYear;
    }
}

