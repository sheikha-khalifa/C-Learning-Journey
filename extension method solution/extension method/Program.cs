using System.Collections.Generic;

namespace extension_method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int x = 12345;
            //int y =IntegerMirror.mirror(x);
            //Console.WriteLine(y);

            //List<int> list = new List<int> { 1,2,3,4,5,6,7,8,9 };
            ////List<int> result=Enumerable.Where(list,x=>x % 2 == 1).ToList();
            //List<int> result = list.Where(x => x % 2 == 1).ToList();//other form of linq operator
            //foreach (var x in result)
            //{
            //    Console.WriteLine(x);
            //}
            //Console.WriteLine(result.GetType());


            //how the query is executed(deffered execustion)
            List<int> lst = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine(lst.GetType());
            List<int> result = lst.Where(x => x % 2 == 1).ToList();//sfter this will be disconnected from this
            lst.Remove(2);
            lst.AddRange(new int[] { 10, 11, 12, 13, 14, 15 });

          foreach(int i in lst)
            {
                Console.WriteLine($"{i}");
            }
            lst.AddRange(new int[] { 16, 17, 18, 19 });
            Console.WriteLine("");
            foreach(int i in lst)
            {
                Console.WriteLine($"{i}");
            }
            Console.WriteLine("");
        }
    }
}