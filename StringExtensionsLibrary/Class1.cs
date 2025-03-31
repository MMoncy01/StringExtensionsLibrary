using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExtensionsLibrary
{
    public static class Class1
    {
        public static bool StartsWithUpperCase(this string input)
        {
            if (string.IsNullOrEmpty(input)) return false;
            return char.IsUpper(input[0]);
        }
    }
}
