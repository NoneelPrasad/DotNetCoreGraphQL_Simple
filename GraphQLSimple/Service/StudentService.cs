using GraphQLSimple.IServices;
using GraphQLSimple.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLSimple.Service
{
    public class StudentService : IStudentService
    {
        public List<Student> GetStudents()
        {
            List<Student> students = new List<Student>();
            for(int i = 0; i < 10; i++)
            {
                students.Add(new Student() 
                {
                    StudentId = new Guid(),
                    FirstName = $"Student {i}",
                    LastName = $"Student {i}",
                    OtherNames = $"Student {i}",

                });

            }

            return students;
            //throw new NotImplementedException();
        }
    }
}
