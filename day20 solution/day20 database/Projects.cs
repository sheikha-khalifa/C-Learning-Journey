using day20_database.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day20_database
{
    internal class Projects
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        [ForeignKey("Employees")]
        public  int? EmpId { get; set; }

        public List<Employees> Employees { get; set; } = new List<Employees>();

    }
}
