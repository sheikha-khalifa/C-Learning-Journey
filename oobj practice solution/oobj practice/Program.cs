namespace oobj_practice
{
    internal class Program
    {
        static decimal calculatesalary(int logedhours, int wages)
        {
            int totalsalary = logedhours * wages;
            decimal tax = totalsalary * 0.3m;
            return totalsalary - tax;

        }
        static void Main(string[] args)
        {
            Employee employee1 = new Employee("sheikha", "alquyudhi", 2000);
            Employee employee2 = new Employee("maitha", "alquyudhi", 2500);
            Employee[] Employees = { employee1, employee2 };
            foreach (Employee emp in Employees)
            {
                Console.WriteLine($"{emp.Fname},{emp.Lname},{emp.salary}");
            }
            //--------------------------------------------
            //Employee employee = new Employee();
            //Console.WriteLine("please enter your first name:");
            //employee.Fname = Console.ReadLine();
            //Console.WriteLine("please enter your last name:");
            //employee.Lname = Console.ReadLine();
            //Console.WriteLine("please enter your age:");
            //employee.age = int.Parse(Console.ReadLine());
            //Console.WriteLine("please enter your salary :");
            //employee.salary = int.Parse(Console.ReadLine());
            //Console.WriteLine("please enter your wages:");
            //int wages = int.Parse(Console.ReadLine());
            //Console.WriteLine("please enter your logged houres:");
            //int loggedhours = int.Parse(Console.ReadLine());
            //Console.WriteLine($"welcome on board: {employee.Fname}\n your age is:{employee.age}\n" +
            //    $" and your salary is {calculatesalary(loggedhours, wages)} after cut tax about 3%");
            #region frequency array
            //frequency array
            int[] numbers = { 1, 2, 2, 3, 3, 3, 4, 4, 4, 4 };

            // Creating a frequency array using LINQ and GroupBy
            var frequencyArray = numbers.GroupBy(n => n).ToDictionary(g => g.Key, g => g.Count());

            // Displaying the frequency array
            Console.WriteLine("Frequency array:");
            foreach (var pair in frequencyArray)
            {
                Console.WriteLine($"Number {pair.Key} occurs {pair.Value} times.");
            }
            #endregion
            Console.ReadKey();
        }
    }
}