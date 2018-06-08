using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Restaurant.Entity.Entities
{
    [Table("Employees")]
    public class Employee
    {
        public int ID { get; set; }
        public string Profession { get; set; }
    }
}
