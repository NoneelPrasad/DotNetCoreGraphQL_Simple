using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLSimple.Model
{
    public class Student
    {
        public Guid StudentId { get; set; }

        public string FirstName { get; set; }
        public string OtherNames { get; set; }
        public string LastName { get; set; }
        public int PhoneNumber { get; set; }
    }
}
