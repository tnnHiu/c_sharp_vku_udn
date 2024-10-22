using System.Data;
using System.Data.SqlClient;

namespace Week_9_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string connectionString = "Data Source=TNN-HIU-LEGION-;Initial Catalog=STUDENT_MANAGEMENT;User ID=tnnh;Encrypt=True;TrustServerCertificate=True";
        SqlDataAdapter? adapter = null;
        DataSet? dataSet = null;


        private void Form1_Load(object sender, EventArgs e)
        {
            adapter = new SqlDataAdapter("Select * from STUDENT", connectionString);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            dataSet = new DataSet();
            // fill data from adapter to dataset
            adapter.Fill(dataSet, "STUDENT");
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            dgvStudent.DataSource = dataSet!.Tables[0];
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            int result = 0;
            DataRow dataRow = dataSet!.Tables[0].NewRow();
            dataRow[0] = txtStudentId.Text;
            dataRow["Name"] = txtStudentName.Text;
            dataRow[2] = txtClassId.Text;
            // add the row to dataset
            dataSet.Tables[0].Rows.Add(dataRow);
            // Update adapter
            try
            {
                adapter!.Update(dataSet, "STUDENT");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Insert Failed \n" + ex.Message);
            }
            if (result > 0) MessageBox.Show("Insert Successfully");
        }


        int position = -1;
        private void dgvStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            position = e.RowIndex;
            if (position == -1)
            {
                MessageBox.Show("No row is selected");
                return;
            }
            // get selected row
            DataRow dataRow = dataSet!.Tables[0].Rows[position];
            txtStudentId.Text = dataRow[0].ToString();
            txtStudentName.Text = dataRow["Name"].ToString();
            txtClassId.Text = dataRow[2].ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (position == -1)
            {
                MessageBox.Show("No row is selected");
                return;
            }
            // get a selected row in dataset
            DataRow dataRow = dataSet!.Tables[0].Rows[position];
            // edit the row
            dataRow.BeginEdit();
            dataRow[0] = txtStudentId.Text;
            dataRow[1] = txtStudentName.Text;
            dataRow[2] = txtClassId.Text;
            dataRow.EndEdit();
            // update adapter
            int result = adapter!.Update(dataSet.Tables[0]);
            if (result > 0)
            {
                MessageBox.Show("Update successfully");
            }
            else
            {
                MessageBox.Show("Update failed");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (position == -1)
            {
                MessageBox.Show("No row selected");
                return;
            }
            DataRow dataRow = dataSet!.Tables[0].Rows[position];
            dataRow.Delete();
            int result = adapter!.Update(dataSet.Tables[0]);
            if (result > 0)
            {
                MessageBox.Show("Delete successfully");
            }
            else
            {
                MessageBox.Show("Delete failed");
            }
        }
    }
}
