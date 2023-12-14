using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models
{
    public partial class Project2
    {
        public Project2()
        {
            Employees = new HashSet<Employee2>();
        }

        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int? EmpId { get; set; }

        public virtual ICollection<Employee2> Employees { get; set; }
    }
}
