using System.Xml.Linq;

namespace Homework_1___Week_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Zoo myZoo = new Zoo();

            Console.WriteLine("Welcome to the Minimalist Zoo Animal Management System!");

            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("1. Add Animals to the Zoo");
                Console.WriteLine("2. Display Zoo Animals");
                Console.WriteLine("3. Add More Animals");
                Console.WriteLine("4. Observe Animal Actions");
                Console.WriteLine("5. Exit");

                int choice;
                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Enter Animal Name:");
                            string name = Console.ReadLine();
                            Console.WriteLine("Enter Animal Age:");
                            int age;
                            int.TryParse(Console.ReadLine(), out age);
                            Console.WriteLine("Enter Animal Species:");
                            string species = Console.ReadLine();
                            Console.WriteLine("Select Animal Diet Type (1. Carnivore, 2. Herbivore, 3. Omnivore):");
                            string dietType = Console.ReadLine();
                            int dietType1;
                            int.TryParse(Console.ReadLine(), out dietType1);
                            string diet = " ";
                            switch (dietType)
                            {
                                case "1":
                                    dietType = "Carnivore";
                                    break;
                                case "2":
                                    dietType = "Herbivore";
                                    break;
                                case "3":
                                    dietType = "Omnivore";
                                    break;
                                default:
                                    dietType = "Unknown";
                                    break;
                            }
                            myZoo.AddAnimal(name, age, species, (DietType)dietType1);
                            break;
                        case 2:
                            Console.WriteLine("Display Zoo Animals:");
                            myZoo.DisplayZooAnimals();
                            break;
                        case 3:
                            Console.WriteLine("Add More Animals:");
                            Console.WriteLine("Enter Animal Name:");
                            string nameToAdd = Console.ReadLine();
                            Console.WriteLine("Enter Animal Age:");
                            int ageToAdd;
                            int.TryParse(Console.ReadLine(), out ageToAdd);
                            Console.WriteLine("Enter Animal Species:");
                            string speciesToAdd = Console.ReadLine();
                            Console.WriteLine("Select Animal Diet Type (1. Carnivore, 2. Herbivore, 3. Omnivore):");
                            if (Enum.TryParse(Console.ReadLine(), out DietType dietTypeToAdd))
                            {
                                myZoo.AddAnimal(nameToAdd, ageToAdd, speciesToAdd, dietTypeToAdd);
                                Console.WriteLine("Animal Added Successfully!");
                            }
                            else
                            {
                                Console.WriteLine("Invalid diet type. Animal not added.");
                            }
                            break;
                        case 4:
                            Console.WriteLine("Observe Animal Actions:");
                            myZoo.ObserveAnimalActions();
                            break;
                        case 5:
                          

                            Console.WriteLine("Thank you for using the Minimalist Zoo Animal Management System!");
                            exit = true;
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please select a valid option.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
            }
        }
    }
}