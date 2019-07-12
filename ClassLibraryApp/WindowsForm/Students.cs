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

namespace WindowsForm
{
    public partial class Students : Form
    {
        public Students()
        {
            InitializeComponent();
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            StudentManager _studentManager = new StudentManager();
            student.Id = Convert.ToInt32 (idTextBox.Text);
            student.Name = nameTextBox.Text;
            MessageBox.Show(_studentManager.AddStudent(student));
        }

        private void Students_Load(object sender, EventArgs e)
        {

        }
    }
}
