using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_day13
{
    internal class mylist<T>
    {
        private T[] Items;

        public mylist(Task items)
        {
            this.Items = new T[] { items };
        }
    }
}
