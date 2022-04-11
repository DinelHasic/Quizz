using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizz
{
    public class User : Object
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public string Username { get; set; }

        private string _password;

        public User(string name, string surname, string username, string password)
        {
            Name = name;
            Surname = surname;
            Username = username;
            _password = password;
        }

        public override string ToString()
        {
            return $"Welcome {Name} {Surname}";
        }

        public string GetPassword()
        {
            return _password;
        }
    }
}
