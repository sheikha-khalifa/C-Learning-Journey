using System.Reflection.Metadata.Ecma335;
using System.Xml.Serialization;

namespace functions_day6
{
    enum grades
    {
        a=1,b,c,d=10, e, f//after a=1 b=2 and d=15 after d e=16
    }
    class Program
    {
        

        //    static DataType functionname(CustomAttributeNamedArgumentsEncoder or parameter)
        //{
        //    logic----
        //return something from the same datatype
        //}
        //-----------------------------------------------------------------------------------
        //    void DataType functionname(CustomAttributeNamedArgumentsEncoder or parameter)
        //{
        //    logic----
        //without return data
        //Console.WriteLine("");

        //}

        //static int Sum1(int x, int y)
        //{
        //    return x + y;//return same as break ,,,all things after return not working
        //}
        //static void PrintLine()
        //    {
        //        Console.WriteLine("-----------");
        //    }
        /* static void PrintLine(int n,string pattern)///(int n=8,string pattern="*____*")///here defualt value and call function with no value will call this data.
         {
             for (int i = 0; i< n; i++)
             {
                 Console.WriteLine(pattern);
             }
             Console.WriteLine("----------------------");
         }*/
        //--------------------------------------- 
        //if you want one parameter defualt and other parameter is user enterit ,the defualt should be at last
        //static void PrintLine(string pattern,int n=10)
        //{
        //    for (int i = 0; i < n; i++)
        //    {
        //        Console.WriteLine(pattern);
        //    }
        //    Console.WriteLine("----------------------");
        //}
        //---------------------------------------------------------------
        static void numberfunction(string pattern, int lengthpattern, bool flag)
        {
            if (flag == true)


                for (int i = 0; i < lengthpattern; i++)
                {
                    Console.WriteLine(pattern, lengthpattern, flag);
                }

            else
                Console.WriteLine(pattern, lengthpattern, flag);
        }

        //------ swap by datatype
        static void swap(int x, int y)
        {
            Console.WriteLine($"original values: {x}, {y}");
            int temp = x;//take the x value into temp
            x = y;//replace x value with y value
            y = temp;//replace y value with x(old x)
            Console.WriteLine($"swapped vales :{x}, {y}");

        }

        //swap by reference
        static void swapbyreference(ref int x, ref int y)
        {
            Console.WriteLine($"original values: {x}, {y}");
            int temp = x;//take the x value into temp
            x = y;//replace x value with y value
            y = temp;//replace y value with x(old x)
            Console.WriteLine($"swapped vales :{x}, {y}");

        }
        //create function for reference datatype(string)
        static void refferenceDatatype(ref string s)
        {
            s += "world";
        }
    
        //sumarray with params keyword
        static bool sumarray(out int sum, out int multi, params int[] arr)
        {
            sum = 0;
            multi = 0;
            for (int i = 2; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            multi = arr[0] * arr[1];

            return true;
        }

        //ENUM IS A VALAUE TYPE STORE FIXED VALUE
        grades grade = (grades)1;
        


        
        static void Main(string[] args)//start up function
            {
            //Console.WriteLine("sum is: " +Sum1(2,8));
            //Console.WriteLine("");
            //PrintLine();
            //PrintLine();
            //PrintLine(6,"*___*");
            //PrintLine(pattern: "*___*", n: 6);///other way.
            //PrintLine(8, "*,----,*");
            //PrintLine();//this is for deafult values.
            //PrintLine("*--*");
            //numberfunction("____",3,true);
            //numberfunction("***",1,false);
            int a = 3, b= 10;
            swap(a, b);//swap by datatype
            Console.WriteLine("----------------------------------------");
            swapbyreference(ref a, ref b);//swap by refference
            Console.WriteLine("----------------------------------------");
            Console.WriteLine($"A value: {a}, B value is {b}");
            Console.WriteLine("----------------------------------------");
            string s = "hello";
            //refferenceDatatype(s);//hello
            refferenceDatatype(ref s);//hello,world

            int sum;
            int multi;
            //sum array with params
            Console.WriteLine( sumarray(out sum,out multi, 1,2,3,4,5));
            Console.WriteLine("sum is:"+sum);
            Console.WriteLine("multi is:"+multi);

            //Console.WriteLine(grade(1));
        }
        }
    }
