using ClassLibraryApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryApp.Repository.Repository
{
    public class StudentRepository
    {
        public string AddStudent(Student student)
        {
            return "My Id: " + student.Id + "& Name: " + student.Name;
        }
    }
}
