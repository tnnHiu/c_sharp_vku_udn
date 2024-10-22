using System.Data.SqlClient;

namespace Week_8_2
{
    public partial class Form1 : Form
    {
        private readonly string stringConn = "Data Source=TNN-HIU-LEGION-;Initial Catalog=STUDENT_MANAGEMENT;User ID=tnnh;Encrypt=True;TrustServerCertificate=True";
        SqlConnection? conn;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalNumOfStudents_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn == null)
                {
                    conn = new SqlConnection(stringConn);
                    if (conn.State == System.Data.ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                }
                SqlCommand command = new SqlCommand($"Select count(*) from STUDENT Where ClassID = '{TbId.Text}'", conn);

                // Execute the sql command to return value
                int result = (int)command.ExecuteScalar();
                tbResult.Text = result.ToString();
                conn.Close();
            }
            catch (Exception exeption)
            {
                MessageBox.Show(exeption.Message);
            }
        }
    }
}
