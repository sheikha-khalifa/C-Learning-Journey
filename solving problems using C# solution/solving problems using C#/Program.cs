using System;
using System.Runtime.InteropServices;

namespace solving_problems_using_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----Problems solved using C#------");
            #region Q11
            //11- Write a program that takes two integers then prints the power.
           
            //Console.WriteLine("please enter first integer:");
            //int first = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("please enter second integer:");
            //int second = Convert.ToInt32(Console.ReadLine());
            //int output = first * second;
            //Console.WriteLine("output:" + output);
            #endregion

            #region Q12
            //12- Write a program to enter marks of five subjects and calculate total, average and percentage.
            
            //Console.WriteLine($"please enter marks of five subjects :\n");
            //int firstMark = Convert.ToInt32(Console.ReadLine());
            //int secondMark = Convert.ToInt32(Console.ReadLine());
            //int thirdMark = Convert.ToInt32(Console.ReadLine());
            //int fourthMark = Convert.ToInt32(Console.ReadLine());
            //int fifthMark = Convert.ToInt32(Console.ReadLine());
            //int total= firstMark + secondMark+thirdMark+fourthMark+fifthMark;
            //int average=(total/ 5);
            //int Percentage = (average*100)/100;
            //Console.WriteLine($"Total Marks:{total}\n Average Marks:{average}\n Percentage Marks:{Percentage} ");
            #endregion

            #region Q13
            //13- Write a program to input the month number and print the number of days in that month.
            
          //  int jan = 31;int feb = 28;int mar = 31; int apr = 30;int may = 31;int jun = 30; int july = 31; 
          //  int aug = 31; int sep = 30; int oct = 31; int nov = 30; int dec = 31;

          //  Console.WriteLine("Enter Month Number(1-12");
          //  int read=Convert.ToInt32(Console.ReadLine());

          //  if ( read==1)
          //  {
          //      Console.WriteLine("Month Number:" + read);
          //      Console.WriteLine("Days in Month:" +jan);
          //  }
          //else if ( read==2)
          //  {
          //      Console.WriteLine("Month Number:" + read);
          //      Console.WriteLine("Days in Month:" + feb);
          //  }
          //else if (read == 3)
          //  {
          //      Console.WriteLine("Month Number:" + read);
          //      Console.WriteLine("Days in Month:" + mar);
          //  }
          // else if (read == 4)
          //  {
          //      Console.WriteLine("Month Number:" + read);
          //      Console.WriteLine("Days in Month:" + apr);
          //  }
          // else if (read == 5)
          //  {
          //      Console.WriteLine("Month Number:" + read);
          //      Console.WriteLine("Days in Month:" + may);
          //  }
          // else if (read == 6)
          //  {
          //      Console.WriteLine("Month Number:" + read);
          //      Console.WriteLine("Days in Month:" + jun);
          //  }
          //else if (read == 7)
          //  {
          //      Console.WriteLine("Month Number:" + read);
          //      Console.WriteLine("Days in Month:" + july);
          //  }
          // else if (read == 8)
          //  {
          //      Console.WriteLine("Month Number:" + read);
          //      Console.WriteLine("Days in Month:" + aug);
          //  }
          //else if (read == 9)
          //  {
          //      Console.WriteLine("Month Number:" + read);
          //      Console.WriteLine("Days in Month:" + sep);
          //  }
          // else if (read == 10)
          //  {
          //      Console.WriteLine("Month Number:" + read);
          //      Console.WriteLine("Days in Month:" + oct);
          //  }
          // else if (read == 11)
          //  {
          //      Console.WriteLine("Month Number:" + read);
          //      Console.WriteLine("Days in Month:" + nov);
          //  }
          //else if (read == 12)
          //  {
          //      Console.WriteLine("Month Number:" + read);
          //      Console.WriteLine("Days in Month:" + dec);
          //  }
          //  else
          //  {
          //      Console.WriteLine("wrong choise");
          //  }
            #endregion

            #region Q14
            //14- Write a program to input marks of five subjects
            //Physics, Chemistry, Biology, Mathematics and Computer, And Calculate percentage and grade.
            int A = 90; int B = 80; int C = 70; int D = 60; int E= 40, F = 40;
            Console.WriteLine("Enter Mraks of five subjets:");
            int Physics = Convert.ToInt32(Console.ReadLine());
            int Chemistry = Convert.ToInt32(Console.ReadLine());
            int Biology = Convert.ToInt32(Console.ReadLine());
            int Mathematics = Convert.ToInt32(Console.ReadLine());
            int Computer = Convert.ToInt32(Console.ReadLine());
            int Total=Physics+Chemistry+Biology+Mathematics+Computer;
            if (Total >= 90)
            {
                Console.WriteLine($"percentage==>{A} Grade:A");
            }
            else if(Total >= 80)
            {
                Console.WriteLine($"percentage==>{B} Grade:B");
            }
            else if (Total >= 70)
            {
                Console.WriteLine($"percentage==>{C} Grade:C");
            }
            else if(Total >= 60)
            {
                Console.WriteLine($"percentage==>{D} Grade:D");
            }
            else if (Total >= 40)
            {
                Console.WriteLine($"percentage==>{E} Grade:E");
            }
            else if (Total < 40)
            {
                Console.WriteLine($"percentage==>{F} Grade:F");
            }
            else
            {
                Console.WriteLine("please try again");
            }
            #endregion

            #region Q15
            //15 - Write a program to check whether a number is positive or negative or zero.
            Console.WriteLine("Enter an Integer Number:");
            int number=Convert.ToInt32(Console.ReadLine());
            if (number > 0)
            {
                Console.WriteLine("The Number is Positive: " +number);
            }
            else if(number < 0)
                {
                    Console.WriteLine("The Number is Negative: " + number);
                }
            else
            {
               Console.WriteLine("The Number is Zero: " + number);
            }
            #endregion

            #region Q16
            //16- Write a program to create a Simple Calculator.
            Console.WriteLine("please choose operation to do(1-3)");
            Console.WriteLine($"1.add \n 2. divide\n 3. multibly\n");
            int choise = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please Enter two numbers:");
            int FirstNum=Convert.ToInt32(Console.ReadLine());
            int SecondNum = Convert.ToInt32(Console.ReadLine());
            int Totalnumber=FirstNum+SecondNum;
            int division = FirstNum / SecondNum;
            int muliply = FirstNum * SecondNum;
            if (choise == 1)
            {
                Console.WriteLine(" total number is:" + Totalnumber);

            }
            else if(choise==2)
            {
                Console.WriteLine(" divion number is:" + division);
            }

            else if(choise==3)
            {
                Console.WriteLine(" muliply number is:" + muliply);
            }
            else
            {
                Console.WriteLine("bad choise");
            }
            #endregion

            #region Q17
            //17- Write a program to allow the user to enter a string and print the REVERSE of it.
            Console.WriteLine("Enter a word:");
            string word=Console.ReadLine();
            char[] charArray = word.ToCharArray(); // Convert the string to a character array
            Array.Reverse(charArray);// Reverse the character array
            string reversedString = new string(charArray); // Convert the reversed character array back to a string
            Console.WriteLine("Reversed string: " + reversedString);
            #endregion

            #region Q18
            //18- Write a program to allow the user to enter int and print the REVERSED of it.
            Console.WriteLine("enter an integer :");
            int userinput = Convert.ToInt32(Console.ReadLine());
            // Convert the integer to a string
            string numberAsString = userinput.ToString();
            // Reverse the string
            char[] reverse = numberAsString.ToCharArray();
            Array.Reverse(reverse);
            string reversedNumberAsString = new string(reverse);

            // Convert the reversed string back to an integer
            int reversedNumber;
            bool isConversionSuccessful = int.TryParse(reversedNumberAsString, out reversedNumber);

            if (isConversionSuccessful)
            {
                Console.WriteLine("Reversed integer: " + reversedNumber);
            }
            else
            {
                Console.WriteLine("Invalid input. Couldn't reverse the integer.");
            }
            #endregion

        }
    }
}