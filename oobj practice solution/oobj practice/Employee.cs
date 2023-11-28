
namespace oobj_practice
{
    internal class Employee
    {
        public string Fname;
        public string Lname;
        public decimal salary;
        public int id;
        public int age;


        //public Employee() 
        //{
        //    //by defualt its inside any class empty constructor
        //}
        public Employee(string Fname, string Lname, decimal salary)
        {
            //id =id;
            this.Fname = Fname;
            this.Lname = Lname;
            this.salary = salary;
            //Console.WriteLine($"emp with id: {id} is created");
        }
    }
}
