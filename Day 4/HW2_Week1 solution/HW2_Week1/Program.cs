namespace HW2_Week1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string perfororm_another = "yes";

            Console.WriteLine("Welcome to the Simple Calculator!\n");
            Console.WriteLine("options:\n");
            Console.WriteLine($"1.Addition\n 2.Subtraction\n 3.Multiplication\n 4.Division\n 5.Exit");

            do
            {
                Console.WriteLine("Select an operation(1 - 5)");
                int input = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter first Operand:");
                int First_Oberand = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter second Operand:");
                int Second_Oberand = Convert.ToInt32(Console.ReadLine());
                if (input == 1)
                {
                    int result = First_Oberand + Second_Oberand;
                    Console.WriteLine("result is:" + result);
                }
                else if (input == 2)
                {
                    int result = First_Oberand - Second_Oberand;
                    Console.WriteLine("result is:" + result);

                }
                else if (input == 3)
                {
                    int result = First_Oberand * Second_Oberand;
                    Console.WriteLine("result is:" + result);

                }
                else if (input == 4)
                {
                    int result = First_Oberand / Second_Oberand;
                    Console.WriteLine("result is:" + result);

                }

                Console.WriteLine("Perform another operation? (yes/no):");

                perfororm_another = Console.ReadLine();


            }

            while (perfororm_another == "yes");


            Console.WriteLine("Thank you for using the Simple Calculator!");
        }
            }

            }
    