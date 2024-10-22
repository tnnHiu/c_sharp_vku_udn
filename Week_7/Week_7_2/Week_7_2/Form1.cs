using System.Text;

namespace Week_7_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string employeeId = txtEmployeeId.Text;
            string employeeName = txtEmployeeName.Text;
            string phone = mtxtPhone.Text;
            string gender = (rdFemale.Checked ? "Female" : "Male");
            string degree = cboDegree.Text;
            StringBuilder builder = new StringBuilder();
            builder.Append($"EmployeeId: {employeeId}\n");
            builder.Append($"EmployeeName: {employeeName}\n");
            builder.Append($"Phone: {phone}\n");
            builder.Append($"Gender: {gender}\n");
            builder.Append($"Degree: {degree}");
            MessageBox.Show(builder.ToString(), "Employee Details");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
