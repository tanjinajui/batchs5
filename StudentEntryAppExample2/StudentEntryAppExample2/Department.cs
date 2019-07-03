using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentEntryAppExample2
{
    class Department
    {
        public Department()
        {
            students = new List<Student>();
        }
        public string Code { get; set; }
        public string Name { get; set; }

        private List<Student> students;

        public bool AddStudent(Student student)
        {
            if (students.Count < 15)
            {
                students.Add(student);
                return true;
            }
            return false;
        }


        public string GetDetails()
        {
            
            string deptInfo = "Code: " + Code + " Name: " + Name;
            string header = "RegNo \t\t Name \t\t Email";
            string studentDetails = "";
            foreach (Student student in students)
            {
                studentDetails += student.RegNo + " \t\t " + student.Name + " \t\t " + student.Email+Environment.NewLine;
            }

            string message = deptInfo + Environment.NewLine + header + Environment.NewLine + studentDetails;

            return message;

        }
    }
}
