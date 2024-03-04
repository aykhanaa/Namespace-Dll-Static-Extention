using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Namespace_Dll_Static_Extention_HomeWork.Helpers.Extensions
{
    internal static class TextExtension
    {
        public static int Division(this int[] arr)
        {
            int result = 1;
            foreach (int i in arr)
            {
                result *= i;
            }
            return result;
        }
    }
}
