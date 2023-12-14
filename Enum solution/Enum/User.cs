using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    internal class User
    {
        public string Name{ get;set;}
        public int age {  get;set;}
        public double money {  get;set;}

        public User(string Name ,int age, double money) 
        {
            this.Name = Name;
            this.age = age;
            this.money = money;
        }
        public static double operator + (User a, User b)
        {
            double sum =a .money + b.money;
            return sum;
        }
        public static double operator - (User a, User b)
        {
            double result = a.money - b.money;
            return result;
        }
        public static double operator * (User a, User b)
        {
            double multi = a.money * b.money;
            return multi;
        }
    }
}
