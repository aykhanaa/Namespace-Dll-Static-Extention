using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Namespace_Dll_Static_Extention.Models
{
    internal class Doctor
    {
        public static int Id { get; set; }
        public static string Name { get; set; }

        static Doctor()
        {
            Console.WriteLine("Static contructor");
        }

        public Doctor()
        {
            Console.WriteLine("Non-tatic contructor");

        }
    }
}
