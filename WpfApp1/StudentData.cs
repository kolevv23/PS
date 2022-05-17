using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1;

namespace StudentInfoSystem
{
    class StudentData
    {
        private List<Student> TestStudents;

        public StudentData()
        {
            TestStudents = new List<Student>();
            TestStudents.Add(exampleStudent());
        }

        public List<Student> GetStudents()
        {
            return TestStudents;
        }

        private void SetStudents(List<Student> list)
        {
            TestStudents = list;
        }

        private Student exampleStudent()
        {
            Student student = new Student();
            student.Name = "Vasko";
            student.FatherName = "Petrov";
            student.Family = "Kolev";
            student.FacultyNumber = "501219038";
            student.Year = 3;
            student.Specialty = "ITI";
            return student;
        }

    }
}
