using GraphQLSimple.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLSimple.IServices
{
    public interface IStudentService
    {
        List<Student> GetStudents();
    }
}
