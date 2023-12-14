using day20_database.Models;
using day20_database.MyDBContext;
using System.Runtime.Intrinsics.Arm;

namespace day20_database
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ApplicationContext db = new ApplicationContext();
            //Departments dept = new Departments();

            //{
            //    dept.deptname = "IT";
            //    dept.depFloor = 1;

            //};
            //// insert data first option
            //Employees emp = new Employees

            //{
            //    name = "ahmed",
            //    Age = 22,
            //    salary = 1000

            //};
            //db.employee.Add(emp);
            //db.department2.Add(dept);
            //db.SaveChanges();

            ////update data in DB

            //using ApplicationContext context3 = new ApplicationContext();
            //var emp2 = (from E in context3.employee
            //            where E.ID == 1
            //            select E).FirstOrDefault();
            //emp2.name = "Ali";
            //context3.employee.Update(emp2);
            //context3.SaveChanges();
            //Console.WriteLine(emp2?.name ?? "NA");


            ///other wayto insert data in DB
            //ApplicationContext context =new ApplicationContext();
            //Employees employee1 = new Employees() { name = "maitha", Age = 20, salary = 3000 };
            //context.employee.Add(employee1);//saved locally
            ////saved changes happened locally
            //context.SaveChanges();

            //to close the connection in old way
            //context.Dispose();
            //try
            //{

            //}
            //finally
            //{
            //    //used to terminate the unused resources
            //}
            #region usingBlock
            //using Block
            //using (ApplicationContext context = new ApplicationContext())
            //{

            //    Employees employee1 = new Employees() { name = "maitha", Age = 20, salary = 3000 };
            //    context.employee.Add(employee1);//saved locally
            //                                    //saved changes happened locally
            //    context.SaveChanges();
            //}
            ////surger syntax for using block 
            //using ApplicationContext context2 = new ApplicationContext();//to close the connection after this will not execute 
            #endregion


        }

    }
}