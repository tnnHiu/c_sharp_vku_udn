using System.Data.SqlClient;

namespace Week_8_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Chuoi ket noi
        SqlConnection? conn;

        string connString = "Data Source=TNN-HIU-LEGION-;Initial Catalog=STUDENT_MANAGEMENT;User ID=tnnh;TrustServerCertificate= True";


        private void BtnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(connString);
                conn.Open();

                MessageBox.Show("Ket noi thanh cong");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void BtnDisconnect_Click(object sender, EventArgs e)
        {
            if (conn != null && conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
                MessageBox.Show("Ngat ket noi thanh cong");
            }
        }
    }
}
