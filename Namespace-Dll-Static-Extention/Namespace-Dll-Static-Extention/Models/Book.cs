using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Namespace_Dll_Static_Extention.Models
{
    internal class Book:Person
    {
        //public Book()
        //{
        //    Id = 10; 
        //}
        public const int num = 5;
        public int result = 0;

        static Book()
        {
            Console.WriteLine(num);
        }
    }
}
