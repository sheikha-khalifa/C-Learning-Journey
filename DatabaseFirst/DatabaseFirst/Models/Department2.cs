using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models
{
    public partial class Department2
    {
        public Department2()
        {
            Employee2s = new HashSet<Employee2>();
        }

        public int DpId { get; set; }
        public string Deptname { get; set; } = null!;
        public int DepFloor { get; set; }

        public virtual ICollection<Employee2> Employee2s { get; set; }
    }
}
