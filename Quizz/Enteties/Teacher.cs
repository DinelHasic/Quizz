using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizz
{
    internal class Teacher : User
    {
        public Subject Subject { get; set; }

        public Teacher(string name, string surname, string username, string password, Subject subject) : base(name, surname, username, password)
        {
            Subject = subject;
        }

        public void printStudents(List<Student> students)
        {
            foreach (Student student in students)
            {
                if (student.Grade > 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($" Student:{student.Name} {student.Surname} Grade:{student.Grade}");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($" Student:{student.Name} {student.Surname} Grade: {student.Grade}");
                }
            }
        }
    }
}
