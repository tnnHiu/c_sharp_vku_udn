using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week_9_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sTUDENTBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sTUDENTBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sTUDENT_MANAGEMENTDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sTUDENT_MANAGEMENTDataSet.STUDENT' table. You can move, or remove it, as needed.
            this.sTUDENTTableAdapter.Fill(this.sTUDENT_MANAGEMENTDataSet.STUDENT);

        }

        string conn = global::Week_9_4.Properties.Settings.Default.STUDENT_MANAGEMENTConnectionString;
        SqlDataAdapter adapter = null;
        DataSet ds = null;

        private void txtSearcher_TextChanged(object sender, EventArgs e)
        {
            string query = $"Select * from STUDENT where Name like '%{txtSearcher.Text}%'";
            adapter = new SqlDataAdapter(query, conn);
            ds = new DataSet();
            adapter.Fill(ds);
            dgvStudents.DataSource = ds.Tables[0];
        }
    }
}
