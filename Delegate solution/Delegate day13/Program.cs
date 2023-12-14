namespace Delegate_day13
{
    internal class Program
    {
        //GENERIC method===> PRINT
        public static void print<T>(T value)
        {
            Console.WriteLine(typeof(T));
            Console.WriteLine(value);
        }
        static void Main(string[] args)
        {
            #region delegate & generic value
            Employee[] emps = new Employee[]
            {
               new Employee{id=22,name="sheikha",Gender="female",totalsales=3000.5m},
               new Employee{id=23,name="maitha",Gender="female",totalsales=6000.5m},
               new Employee{id=24,name="kholood",Gender="female",totalsales=7000.5m},
               new Employee{id=25,name="mohammed",Gender="male",totalsales=3000m},
            };
            Report repo=new Report();
            repo.totalsalesbetween30kto59999k(emps);
            repo.totalsalesmorethan60k(emps);
            repo.totalsaleslessthan30k(emps);
            Console.WriteLine("******************************************************************");
            Report reports=new Report();
            reports.processEmployee(emps, "report for employees sales more tha 60k",(emp)=>emp.totalsales>=60000m);
            reports.processEmployee(emps, "report for employees sales between 30000a and 59999k", (emp)=> 30000m >= emp.totalsales && emp.totalsales <= 59999m);
            reports.processEmployee(emps, "report for employees sales less than 30k", (emp)=> emp.totalsales < 30000m);
            Console.WriteLine("==========================================================================================");
            //GENERIC VALUE from genaric method
            print(3);//int type
            print("sheikha ALQuyudhi");//string type
            print(3.300);//double type
        }
        #endregion

    }
}