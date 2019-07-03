using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentEntryAppExample2
{
    public partial class StudentEntryUi : Form
    {
        public StudentEntryUi()
        {
            InitializeComponent();
        }

        private Department department;
        private void DepartmentSaveButton_Click(object sender, EventArgs e)
        {
            department = new Department();
            department.Code = codeTextBox.Text;
            department.Name = departmentNameTextBox.Text;

        }

        private void StudentSaveButton_Click(object sender, EventArgs e)
        {
            if (department == null)
            {
                MessageBox.Show("Please Create Department First!");
                return;
            }

            Student student = new Student();

            student.Name = studentNameTextBox.Text;
            student.RegNo = regNoTextBox.Text;
            student.Email = emailTextBox.Text;

            bool isAdded = department.AddStudent(student);
            if (isAdded)
            {
                studentNameTextBox.Text = "";
                regNoTextBox.Text = "";
                emailTextBox.Text = "";
            }
            else
            {
                MessageBox.Show("Department Capacity Full!");
            }
        }

        private void ShowDetailsButton_Click(object sender, EventArgs e)
        {
            string message = department.GetDetails();
            MessageBox.Show(message);
        }
    }
}
