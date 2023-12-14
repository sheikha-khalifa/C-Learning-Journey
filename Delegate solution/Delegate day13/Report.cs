using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_day13
{
    internal class Report
    {
        //delegate 
        public delegate bool salecondition(Employee emp);
        public void processEmployee(Employee[] emp,string title,salecondition salecondition)
        {
            Console.WriteLine(title);
            Console.WriteLine("----------------------------------------------");
            foreach (Employee e in emp)
            {
                if (salecondition(e))
                    Console.WriteLine($"{e.id} | {e.name} | {e.Gender} | {e.totalsales}");
            }
            Console.WriteLine("\n\n");
        }
        //older methods 
       
        public void totalsalesmorethan60k(Employee[] emp)
        {
            Console.WriteLine("report for employees sales more tha 60k");
            Console.WriteLine("----------------------------------------------");
            foreach (Employee e in emp)
            {
                if (e.totalsales >= 60000m)
                    Console.WriteLine($"{e.id} | {e.name} | {e.Gender} | {e.totalsales}");
            }
            Console.WriteLine("\n\n");
        }

        public void totalsalesbetween30kto59999k(Employee[] emp)
        {
            Console.WriteLine("report for employees sales more tha 60k");
            Console.WriteLine("----------------------------------------------");
            foreach (Employee e in emp)
            {
                if (30000m <= e.totalsales && e.totalsales<=59999m)
                    Console.WriteLine($"{e.id} | {e.name} | {e.Gender} | {e.totalsales}");
            }
            Console.WriteLine("\n\n");
        }

        public void totalsaleslessthan30k(Employee[] emp)
        {
            Console.WriteLine("report for employees sales more tha 60k");
            Console.WriteLine("----------------------------------------------");
            foreach (Employee e in emp)
            {
                if (e.totalsales < 60000m)
                    Console.WriteLine($"{e.id} | {e.name} | {e.Gender} | {e.totalsales}");
            }
            Console.WriteLine("\n\n");
        }
    }
}
