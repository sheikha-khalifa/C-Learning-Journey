using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day20_database.Models
{
    internal class Departments
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DpId { get; set; }
        [StringLength(50, MinimumLength = 15)]
        public string deptname { get; set; }
        [Range(1, 5)]
        public int depFloor { get; set; }
        //one to many relation (one dept has many employee)
        public  List<Employees> Employees { get; set; }
    }
}
