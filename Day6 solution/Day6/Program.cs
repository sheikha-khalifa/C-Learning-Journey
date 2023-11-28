namespace Day6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //type casting
            //Implicit--explicit
            //when change between value types
            //each dattype hase its own range of value

            int x = 10;
            int y = x;//(impicit) because long in range is 

            int A = 10;
            string s=A.ToString();
            //Console.WriteLine(s[0]);// will print 1 as string

            string value = "9999a";//9999a invalid 
            int X;
            bool res=int.TryParse(value, out X);//safe code
            Console.WriteLine(X);

            //-------------------------
            #region try parse

            #endregion




        }
    }
}