using System.Data.SqlClient;

namespace Week_8_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ViewListOfStudents();
        }

        SqlConnection? conn;
        string stringConn = "Data Source=TNN-HIU-LEGION-;Initial Catalog=STUDENT_MANAGEMENT;User ID=tnnh;Encrypt=True;TrustServerCertificate=True";

        private void ViewListOfStudents()
        {
            lvwStudent.Items.Clear();
            conn ??= new SqlConnection(stringConn);
            if (conn.State == System.Data.ConnectionState.Closed) conn.Open();
            SqlCommand command = new SqlCommand("Select * from Student", conn);

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {

                string studentId = reader.GetString(0);
                string studentName = reader.GetString(1);
                string classId = reader.GetString(2);
                ListViewItem item = lvwStudent.Items.Add(studentId);
                item.SubItems.Add(studentName);
                item.SubItems.Add(classId);
            }
            conn.Close();

        }



        int result = -1;
        private void btnInsert_Click(object sender, EventArgs e)
        {
            conn ??= new SqlConnection(stringConn);
            if (conn.State == System.Data.ConnectionState.Closed) conn.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.Connection = conn;
            command.CommandText = "Insert into STUDENT(StudentID, Name, ClassID) " +
                "values(@StudentId, @Name, @ClassID)";

            SqlParameter param1 = new SqlParameter("@StudentId", txtStudentId.Text);
            command.Parameters.Add(param1);

            SqlParameter param2 = new SqlParameter("Name", txtFullName.Text);
            command.Parameters.Add(param2);

            SqlParameter param3 = new SqlParameter("ClassId", txtClassId.Text);
            command.Parameters.Add(param3);

            try
            {
                result = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n Insert a record failed!");
            }
            if (result > 0)
            {
                ViewListOfStudents();
            }

        }

        private void lvwStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwStudent.SelectedIndices.Count > 0)
            {
                txtStudentId.Text = lvwStudent.SelectedItems[0].SubItems[0].Text;
                txtFullName.Text = lvwStudent.SelectedItems[0].SubItems[1].Text;
                txtClassId.Text = lvwStudent.SelectedItems[0].SubItems[2].Text;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            conn ??= new SqlConnection(stringConn);
            if (conn.State == System.Data.ConnectionState.Closed) conn.Open();
            SqlCommand command = new SqlCommand($"Update Student set" +
                $" Name = '{txtFullName.Text}'," +
                $" ClassID = '{txtClassId.Text}' " +
                $"where StudentID = '{txtStudentId.Text}'", conn);
            try
            {
                result = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n Update failded!");
            }
            if (result > 0)
            {
                ViewListOfStudents();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            conn ??= new SqlConnection(stringConn);
            if (conn.State == System.Data.ConnectionState.Closed) conn.Open();
            SqlCommand command = new SqlCommand($"Delete from STUDENT " +
                $"where StudentId = '{txtStudentId.Text}'",conn);

            try
            {
                result=command.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + "\n Delete failed!");
            }
            if (result > 0) {
                ViewListOfStudents();
                txtClassId.Text = "";
                txtFullName.Text = "";
                txtStudentId.Text = "";
            }
        }
    }
}
