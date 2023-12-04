
namespace classes_example
{
    internal class Program
    {
   
        static void Main(string[] args)
        {
            Console.WriteLine("---------------welcome on the board------------------");
            Console.WriteLine("please enter yourname:");
            string name = Console.ReadLine();
            Console.WriteLine("please enter yourage:");
            int age;
            string sage;
            do
            {
                sage = Console.ReadLine();
            }
            while (int.TryParse(sage, out age) && Human.validateage(age));

            Console.WriteLine("enter your address:");
            string address = Console.ReadLine();

            Console.WriteLine("enter your id:");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter your email:");
            string email = Console.ReadLine();

            //objetc decleration
            Human human = new Human(name, age, address, id, email);
            Console.WriteLine(human.greetingname());

            // object declear with values
            Human human1 = new Human("mohammed", 23, "Ibri", 224, "email.com");
            Console.WriteLine(human1.greetingname());

            // calling get and set functions 

            //Console.WriteLine($"the get email is:{human.Getemail()}");
            Human emp = new Human(name, age, address, id, email);
            emp.Name = "sheikha AL-Quyudhi";//set name
            Console.WriteLine($"the getted name is: {emp.Name}");//get Name

            emp.Age = 26;//set age
            Console.WriteLine($"the getted age is: {emp.Age}");//get age

            emp.Address = "ibri";//set address
            Console.WriteLine($"the getted address is: {emp.Address}");//get address

            emp.ID = 2275;//set ID
            Console.WriteLine($"the getted address is: {emp.ID}");//get ID

            emp.Email="sheikha@gmail.com";// set email
            Console.WriteLine($"the getted email is: {emp.Email}");//get email

            Console.ReadKey();
        }

    }
}