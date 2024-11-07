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

namespace GUI
{
    public partial class StudentListViewForm : Form
    {
        StudentBUS studentBUS = new StudentBUS();

        public StudentListViewForm()
        {
            InitializeComponent();
        }

        private void btnViewStudent_Click(object sender, EventArgs e)
        {
            List<Student> students = studentBUS.GetAllStudents();
            foreach (Student student in students)
            {
                ListViewItem item = new ListViewItem(student.StudentID);
                item.SubItems.Add(student.Name);
                item.SubItems.Add(student.ClassID);
                lvStudent.Items.Add(item);
            }
        }
    }
}
