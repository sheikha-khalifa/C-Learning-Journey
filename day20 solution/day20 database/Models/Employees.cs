using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day20_database.Models
{
    internal class Employees
    {
        
        public int ID { get; set; }
        [MaxLength(50)]
        public string? name { get; set; }
        [Range(18, 50)]
        public int Age { get; set; }
        [DataType(DataType.Currency)]
        public decimal? salary { get; set; }
        //many to one relation
        [ForeignKey("Departments")]
        public int? depId { get; set; }

        public  Departments Departments { get; set; }
        //many to many
        [ForeignKey("Projects")]
        public  int? projId { get; set; }

        public List<Projects> Projects { get; set; }
    }
}
