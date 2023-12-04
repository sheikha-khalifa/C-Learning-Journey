using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cashier_example_using_interface
{
    interface Ipayment
    {
        void Pay(decimal amount);
    }

    internal class Cash : Ipayment
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"you have paid {amount} using cash");
        }
    }

    internal class VisaCard : Ipayment
    {

        public void Pay(decimal amount)
        {
            Console.WriteLine($"you have paid {amount} using VisaCard");
        }
    }

    internal class Debit  : Ipayment
    {

        public void Pay(decimal amount)
        {
            Console.WriteLine($"you have paid {amount} using Debit ");
        }
    }

    internal class MasterCard : Ipayment
    {

        public void Pay(decimal amount)
        {
            Console.WriteLine($"you have paid {amount} using MasterCard  ");
        }
    }
}

