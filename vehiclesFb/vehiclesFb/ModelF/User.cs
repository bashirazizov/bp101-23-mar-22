using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehiclesFb.ModelF
{
    class User
    {
        public string Name;
        public string Surname;
        public string Email;
        public DateTime DateOfBirth;
        public bool IsSingle;

        public Post[] Posts;

        public User()
        {}

        public User(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        public User(string name, string surname, string email, bool isSingle):this(name, surname)
        {
            Email = email;
            IsSingle = isSingle;
        }
    }
}
