using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizz
{
    public class Student : User
    {
        public int Grade { get; set; }

        public Subject Subject { get; set; }

        public Student(string name,string surname,string username, string password):base(name,surname,username, password)
        {
            Grade = 0;
        }
    }
}
