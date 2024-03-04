using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Namespace_Dll_Static_Extention.Models
{
    internal class User
    {
        public string name;
        public string surname;
        public int age;
        private string password;

        public User()
        {
            
        }

        public User(string name, string surname, int age)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
        }

        public void Set(string pass)
        {
           password = pass;
        }

        public string Get( )
        {
            return password;
        }


    }
}
