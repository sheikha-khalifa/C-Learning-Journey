
namespace problem_solving
{
    internal class Program
    {

        //static void search()
        //{
        //    int arrsize, target;
        //    string s=Console.ReadLine();
        //    string[] valgiving = s.Split(" ");
        //    arrsize = int.Parse(valgiving[0]);
        //    target = int.Parse(valgiving[1]);
        //    int[] values= new int[arrsize];
        //    s= Console.ReadLine();
        //    string[] valuesplit = s.Split(" ");

        //    for (int i = 0; i<arrsize; i++)
        //    {
        //        values[i]=int.Parse(valuesplit[i]);
        //    }
        //}
        static void multiblication(int n)
        {
            for(int i=1; i<=n; i++)
            {
                Console.WriteLine($"multiblication table of {i}");
                for (int j=1; j<=12; j++)
                {
                    Console.WriteLine($" {i} * {j} = {n*j}");
                }

            }
        }

        static int  sumnumber(int n) 
        {
            int sum = n * (n + 1) / 2;
            return sum;
        }
        //. Write a C# Sharp program to swap two numbers.
        static void swap()
        {
            Console.WriteLine("enter first number:");
           int first=Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("enter second number:");
            int second = Convert.ToInt32(Console.ReadLine());
            int swap = first;
            first = second;
            second = swap;
            Console.WriteLine($"fisrt after swap:{first}");
            Console.WriteLine($"second after swap:{second}");
        }

        static void Main(string[] args)
        {
            //multiblication(3);
            //Console.WriteLine(sumnumber(15));
            //swap();
            //search();

            Console.ReadKey();
        }
    }
}