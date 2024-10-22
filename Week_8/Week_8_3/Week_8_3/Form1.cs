using System.Data.SqlClient;

namespace Week_8_3
{
    public partial class Form1 : Form
    {
        private readonly string stringConn = "Data Source=TNN-HIU-LEGION-;Initial Catalog=STUDENT_MANAGEMENT;User ID=tnnh;Encrypt=True;TrustServerCertificate=True";
        private SqlConnection? conn;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnViewInDetail_Click(object sender, EventArgs e)
        {

            try
            {
                tbClassId.Text = "";
                tbClassName.Text = "";
                tbYear.Text = "";

                if (conn == null)
                {
                    conn = new SqlConnection(stringConn);
                }
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    conn.Open();
                }
                SqlCommand command = new SqlCommand();
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = $"Select * from CLASS Where ClassId = '{tbEnterClassId.Text}'";
                command.Connection = conn;

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    tbClassId.Text = reader.GetString(0);
                    tbClassName.Text = reader.GetString(1);
                    tbYear.Text = reader.GetInt32(2).ToString();
                }
                conn.Close();

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }


        }

        private void btnViewListOfStudents_Click(object sender, EventArgs e)
        {
            listViewOfStudents.Items.Clear();
            if (conn == null) conn = new SqlConnection(stringConn);
            if (conn.State == System.Data.ConnectionState.Closed) conn.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = $"Select * from STUDENT Where ClassId = '{tbEnterClassId.Text}'";
            command.Connection = conn;

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string studentId = reader.GetString(0);
                string studentName = reader.GetString(1);
                string classId = reader.GetString(2);
                ListViewItem item = new ListViewItem(studentId);
                item.SubItems.Add(studentName);
                item.SubItems.Add(classId);
                listViewOfStudents.Items.Add(item);
            }
            conn.Close();
        }    
    }
}
