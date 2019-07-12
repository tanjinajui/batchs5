using ClassLibraryApp.BLL.BLL;
using ClassLibraryApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibraryApp
{
    public partial class StudentUiDesign : Form
    {
        public StudentUiDesign()
        {
            InitializeComponent();
        }

        private void StudentUiDesign_Load(object sender, EventArgs e)
        {
            Student student = new Student();
            student.Id = 1;
            student.Name = "Tanjina";

        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            
                Student student = new Student();
                StudentManager _studentManager = new StudentManager();
                student.Id = Convert.ToInt32(idTextBox.Text);
                student.Name = nameTextBox.Text;
                MessageBox.Show(_studentManager.AddStudent(student));
            

        }
    }
}
