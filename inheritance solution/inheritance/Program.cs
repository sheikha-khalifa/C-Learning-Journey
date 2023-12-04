using System.Data;

namespace inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region inheritance for animal
            // Eagle eg= new Eagle();
            //eg.fly();
            //eg.move();
            //Dogs dogs = new Dogs();
            //dogs.eat();
            //dogs.fly();
            //dogs.move();
            #endregion

            Human human = new Human(2279,26,"sheikha ALQuyudhi",false,false);
           //human.describe();

            Employees emp=new Employees("instructor", 190,"information technology", 120,22,26,"youssif",true,false);
            //emp.calculatesalary();
            //emp.printInfo();
          
            Console.WriteLine(emp.ToString());
            //Console.WriteLine(emp);



        }
    }
}