using System.Data;
using System.Data.SqlClient;

namespace Week_8_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string stringConn = "Data Source=TNN-HIU-LEGION-;Initial Catalog=STUDENT_MANAGEMENT;User ID=tnnh;Encrypt=True;TrustServerCertificate=True";
        private SqlConnection? conn;

        private void Form1_Load(object sender, EventArgs e)
        {
            if (conn == null) conn = new SqlConnection(stringConn);
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlCommand command = new SqlCommand("Select * from CLASS", conn);
            listOfClasses.ClearSelected();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string classID = reader.GetString(0);
                string className = reader.GetString(1);
                int year = reader.GetInt32(2);
                string line = classID + "-" + className + "-" + year.ToString();
                listOfClasses.Items.Add(line);
            }
            conn.Close();
        }

        private void listOfClasses_SelectedIndexChanged(object sender, EventArgs e)
        {
            listOfStudents.Items.Clear();
            if (listOfClasses.SelectedIndex == -1) return;
            string? line = listOfClasses.SelectedItem!.ToString();
            string[] array = line!.Split("-");
            string classId = array[0];

            if (conn == null) conn = new SqlConnection(stringConn);
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlCommand command = new SqlCommand($"Select * from STUDENT where ClassId='{classId}'", conn);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string studentId = reader.GetString(0);
                string name = reader.GetString(1);
                string classIdRow = reader.GetString(2);
                ListViewItem item = listOfStudents.Items.Add(studentId);
                item.SubItems.Add(name);
                item.SubItems.Add(classIdRow);
            }
            conn.Close();
        }
    }
}
