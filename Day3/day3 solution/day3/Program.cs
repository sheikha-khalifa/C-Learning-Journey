using System.Data.Common;

namespace day3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region refrence type comparision
            string s1 = "hello there";
            string s2 = s1;
            s1 = "what is this?";
            Console.WriteLine("s1 value"+s1);
            Console.WriteLine("s1 place" + s1.GetHashCode());

            Console.WriteLine("s2 value" + s2);
            //0x3fc21==> memory address in hexadecimal
            Console.WriteLine("s2 value" + s2.GetHashCode());//GetHashCode get the address where its saved with hexadeimalin memory
            #endregion

            #region odd & even
            //odd & even in one line
            int x = 10;
            string result = (x % 2 == 0) ? "x is even" : "x is odd";
            Console.WriteLine(result);
            #endregion

            //another way for print output
            Console.WriteLine($"welcome :{s1}\n value 2 is:{s2}");//$ ==> formatted string
           
            //create program that will check if number is divisable by 3 or not
            int mod = 8;
            string mood = (mod % 3 == 0) ? "mod is divisable" : "mod is not divisable";
            Console.WriteLine (mood);
            #region Operators precedence
            //Operators precedence
            Console.WriteLine("------------------------------------------------");
            int resu = 2 + 3 * 5;
            int resu1 = 2 + (3 * 5);
            Console.WriteLine (resu);
            Console.WriteLine(resu1);
            #endregion

            #region postfix
            int c = 1;
            //postfix ===>after one step
            Console.WriteLine(c++);//res 1
            Console.WriteLine(c);// res 2

            //c++;
            //Console.WriteLine(c);
            #endregion
        }
    }
}