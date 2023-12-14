using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extension_method
{
    internal static class IntegerMirror
    {
        public static int mirror(this int Number)
        {
            int result = 0, reminder;
            while(Number != 0)
            {
                reminder = Number % 10;
               result  = result * 10 + reminder;
                Number = Number / 10;

            }
            return result;
        }
    }
}
