using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryApp.Models;
using ClassLibraryApp.Repository.Repository;

namespace ClassLibraryApp.BLL.BLL
{
    
    public class StudentManager
    {
        StudentRepository _studentRepository = new StudentRepository();
        public string AddStudent(Student student)
        {
            return _studentRepository.AddStudent(student);
        }
    }
}
