using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models
{
    public partial class Employee2
    {
        public Employee2()
        {
            Projects = new HashSet<Project2>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }
        public decimal? Salary { get; set; }
        public int? DepId { get; set; }
        public int? ProjId { get; set; }

        public virtual Department2? Dep { get; set; }

        public virtual ICollection<Project2> Projects { get; set; }
    }
}
