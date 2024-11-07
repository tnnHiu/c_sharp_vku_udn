using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Student_Management
{
    public partial class StudentManagementForm : Form
    {

        StudentBUS studentBUS = new StudentBUS();
        int position = -1;
        public StudentManagementForm()
        {
            InitializeComponent();
        }
        private void StudentManagementForm_Load(object sender, EventArgs e)
        {
            ShowAllStudentToGridView();
        }

        public void ShowAllStudentToGridView()
        {
            dgvStudent.DataSource = studentBUS.GetAllStudents();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string studentId = txtStudentId.Text;
            string studentName = txtFullName.Text;
            string classID = txtClassId.Text;
            Student student = new Student(studentId, studentName, classID);
            if (studentBUS.InsertStudent(student))
            {
                ShowAllStudentToGridView();
            }
            else
            {
                MessageBox.Show("Insert failed!");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string studentId = txtStudentId.Text;
            string studentName = txtFullName.Text;
            string classID = txtClassId.Text;
            Student student = new Student(studentId, studentName, classID);
            if (studentBUS.UpdateStudent(student))
            {
                ShowAllStudentToGridView();
            }
            else
            {
                MessageBox.Show("Update failed!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string studentId = txtStudentId.Text;
            if (studentBUS.DeleteStudent(studentId))
            {
                ShowAllStudentToGridView();
                txtStudentId.Text = "";
                txtFullName.Text = "";
                txtClassId.Text = "";
            }
            else
            {
                MessageBox.Show("Delete failed!");
            }
        }

        private void dgvStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            position = e.RowIndex;
            if (position == -1) return;
            DataGridViewRow dataGridViewRow = dgvStudent.Rows[position];
            txtStudentId.Text = dataGridViewRow.Cells[0].Value.ToString();
            txtFullName.Text = dataGridViewRow.Cells[1].Value.ToString();
            txtClassId.Text = dataGridViewRow.Cells[2].Value.ToString();
        }
    }
}
