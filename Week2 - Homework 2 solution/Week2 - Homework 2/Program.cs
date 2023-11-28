
namespace Week2___Homework_2
{
    internal class Program
    {
        class CoffeeShop
        {
            static string[] coffeeMenu = { "Americano", "Latte", "Cappuccino" };

            static string display_menu()
            {
                string[] coffee = { "Americano", "Latte", "Cappuccino" };
                double[] price = { 2.50, 3.0, 3.5 };
                Console.WriteLine("Welcome to the Coffee Shop!!\n");
                Console.WriteLine("please select achoise to make an order from the " +
                   "menue:\n");
                Console.WriteLine("please select coffee choise(1-3):");
                Console.WriteLine($"1.{coffee[0]} -${price[0]}");
                Console.WriteLine($"2.{coffee[1]} -${price[1]}");
                Console.WriteLine($"3.{coffee[2]} -${price[2]}");
                int menu_choice = Convert.ToInt32(Console.ReadLine());

                if (menu_choice >= 1 && menu_choice <= coffee.Length)
                {
                    return coffee[menu_choice - 1];
                }
                else
                {
                    Console.WriteLine("Invalid choice!");
                    return null; 
                }
            }
            static void place_order(out string size, out string suger, out string milk)
            {
                size = " ";
                suger = " ";
                milk = " ";
                string[] Size = { "small", "meduim", "large" };
                string[] Suger = { "With suger", "Without suger" };
                string[] Milk = { "With milk", "Without milk" };
                Console.WriteLine($"Please select Customization choice (1-3): \n 1.{Size[0]} \n 2.{Size[1]} \n 3.{Size[2]}");
                int size_choice = Convert.ToInt32(Console.ReadLine());
                if (size_choice > 0 && size_choice <= Size.Length)
                {
                    size = Size[size_choice - 1];
                }
                Console.WriteLine($"Please select Sugar choice (1-2): \n 1.{Suger[0]} \n 2.{Suger[1]}");
                int sugar_choice = Convert.ToInt32(Console.ReadLine());
                if (sugar_choice > 0 && sugar_choice <= Suger.Length)
                {
                    suger = Suger[sugar_choice - 1];
                }
                Console.WriteLine($"Please select Milk choice (1-2): \n 1.{Milk[0]} \n 2.{Milk[1]}");
                int milk_choice = Convert.ToInt32(Console.ReadLine());
                if (milk_choice > 0 && milk_choice <= Milk.Length)
                {
                    milk = Milk[milk_choice - 1];
                }
            }
            static string GetUserChoice(string prompt)
            {
                Console.Write(prompt);
                int choice = int.Parse(Console.ReadLine());
                if (choice < 1 || choice > coffeeMenu.Length)
                {
                    Console.WriteLine("Invalid choice. Please select a valid option.");
                    return null;
                }
                return coffeeMenu[choice - 1];
            }
            //----------------------------------------------------
            static double CalculateCost(string selectedCoffee, string size)
            {
                // Define different prices for each size
                double smallPrice = 2.50;
                double mediumPrice = 3.0;
                double largePrice = 3.5;
                // Calculate the cost based on selected coffee and size
                double coffeePrice = GetCoffeePrice(selectedCoffee);
                double sizePrice = 0.0;

                switch (size.ToLower())
                {
                    case "small":
                        sizePrice = smallPrice;
                        break;
                    case "medium":
                        sizePrice = mediumPrice;
                        break;
                    case "large":
                        sizePrice = largePrice;
                        break;
                    default:
                        Console.WriteLine("Invalid size choice. Defaulting to small.");
                        sizePrice = smallPrice; // Default to small size if invalid input
                        break;
                }

                return coffeePrice + sizePrice;
            }

            static double GetCoffeePrice(string selectedCoffee)
            {
                // Define coffee prices corresponding to their names
                double americanoPrice = 2.50; // Change these values according to actual prices
                double lattePrice = 3.0;
                double cappuccinoPrice = 3.5;

                switch (selectedCoffee.ToLower())
                {
                    case "americano":
                        return americanoPrice;
                    case "latte":
                        return lattePrice;
                    case "cappuccino":
                        return cappuccinoPrice;
                    default:
                        Console.WriteLine("Invalid coffee choice.");
                        return 0.0;
                }
            }

            static void DisplayOrderSummary(string selectedCoffee, string size, string sugar, string milk, double totalCost)
            {
                Console.WriteLine("Order Summary:");
                Console.WriteLine($"Coffee: {selectedCoffee}");
                Console.WriteLine($"Size: {size}");
                Console.WriteLine($"Sugar: {sugar}");
                Console.WriteLine($"Milk: {milk}");
                Console.WriteLine($"Total Cost: ${totalCost}");
            }

            static void Main(string[] args)
            {
                bool exit = false;
                while (!exit)
                {

                    string selectedCoffee = display_menu();
                    if (selectedCoffee != null)
                    {
                        string orderSize;
                        string orderSugar;
                        string orderMilk;

                        place_order(out orderSize, out orderSugar, out orderMilk);

                        double totalCost = CalculateCost(selectedCoffee, orderSize);

                        DisplayOrderSummary(selectedCoffee, orderSize, orderSugar, orderMilk, totalCost);

                        Console.Write("Do you want to place another order? (yes/no): ");
                        string input = Console.ReadLine().ToLower();
                        if (input != "yes")
                        {
                            exit = true;
                            Console.WriteLine("Thank you for visiting! Goodbye!");
                        }
                    }
                }
            }
        }
    }
}