
using System.Xml.Linq;

namespace inheritance
{
    sealed class Employees:Human //sealed it means we cant inherit from Employee
    {
        //by defualt private
        string role;
        int workinghours;
        string department;
        int wage;
        public Employees(string role, int workinghours,string department,int wag,int id, int age, string name,bool hasjob, bool isMarried) : base (id,age,name,hasjob,isMarried)
        {
            this.role = role;
            this.workinghours = workinghours;
            this.department = department;
            this.wage = wage;

        }
        public override string ToString()
        {
            return base.ToString() + $" your position is {this.role}";
        }
        public override void calculatesalary()
        { 
            int salary = workinghours * wage;
            Console.WriteLine(salary);
        }
        public void printInfo()
        {
            Console.WriteLine($"hello {name}");
        }
    }
}
