using System.ComponentModel;
using System.Xml.Linq;

namespace Task1_day3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //1- Write a program that allows the user to enter a number then print it.
            Console.WriteLine("please Enter Number:");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your entered number is:" +number);
            #endregion

            Console.WriteLine("-----------------------------------------");

            #region Q2
            //2- Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.
            Console.WriteLine("Enter a number:");
            int num = Convert.ToInt32(Console.ReadLine());
            string result = (num % 3 == 0) && (num % 4 == 0) ? "can be divided" : "can be divided";
            Console.WriteLine("Your entered number is:" + result);
            #endregion

            #region Q3
            //3- Write a program that allows the user to insert 2 integers then print the max.
            // Console.WriteLine("Please enter first integer:" + "\n Please enter second integer:");
            // int first = Convert.ToInt32(Console.ReadLine());
            // int second = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine($"Your first integer is: { first} \nyour second integer is: { second}");

            //string max =(first > second) && (second > first)? "The Max is:" +first : "The MAX is:"  +second;
            // Console.WriteLine(max);
            #endregion

            #region Q4
            //4- Write a program that allows the user to insert an integer then
            //print negative if it is negative number otherwise print positive.
            //Console.WriteLine("enter integer(positive or negative)");
            //int input = Convert.ToInt32(Console.ReadLine());
            //string output = (input < 0) ? "The number is negative: " + input : "The number is positive: " + input;
            //Console.WriteLine(output);
            #endregion

            #region Q5
            //5 - Write a program that takes 3 integers from the user then prints the max element and the min element.
            //int[] values = new int[3];
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine($"Enter integer {i + 1}: ");
            //    if (!int.TryParse(Console.ReadLine(), out values[i]))
            //    {
            //        Console.WriteLine("Invalid input. Please enter a valid integer.");
            //        i--;
            //    }
            //}
            //int max = values[0];
            //int min = values[0];

            //for (int i = 1; i < 3; i++)
            //{
            //    if (values[i] > max)
            //        max = values[i];

            //    if (values[i] < min)
            //        min = values[i];
            //}
            //Console.WriteLine($"Maximum number: {max}");
            //Console.WriteLine($"Minimum number: {min}");
            #endregion

            #region Q6
            //6- Write a program that allows the user to insert an integer number then check If a number is even or odd.
            //Console.WriteLine(" Enter Number:");
            //int val=Convert.ToInt32(Console.ReadLine());
            //string result = (val % 2 == 0) ? "this is even number" : "this is odd number";
            //Console.WriteLine(result);

            #endregion

            #region Q7
            //7- Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u) then print (vowel)
            //otherwise print (consonant).

            //Console.WriteLine(" Enter character:");
            //Char character = Convert.ToChar(Console.ReadLine());
            //string VOWEL = (character == 'a') || (character == 'e') || (character == 'I') || (character == 'o') || (character == 'u') ? " vowel" : "Consonant";
            //Console.WriteLine(VOWEL);
            #endregion

            #region Q8 
            //8- Write a program that allows the user to insert an integer then print all numbers between 1 to that number.

            //Console.WriteLine("Enter integer number:");
            //int read = Convert.ToInt32(Console.ReadLine());
            //for(int i = 1; i <= read; i++)
            //{
            //    Console.Write( i+ ",");
            //}
            #endregion

            #region Q9
            //9- Write a program that allows the user to insert an integer then print a multiplication table up to 12.

                Console.WriteLine("Enter Integer value:");
                int val=Convert.ToInt32(Console.ReadLine()); 
                for (int i = val;i<=12; i++)
                {
                    Console.WriteLine($"{val} * {i} = {val * i}");
               }
            #endregion

            #region Q10
            //10- Write a program that allows user to insert number then print all even numbers between 1 to this number
            Console.WriteLine("Enter number:");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i <= num; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i+" ");
                }
            }
            #endregion
        }

    }
    }
    
