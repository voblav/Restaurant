using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Restaurant.Repositories
{
    [Table("Dishes")]
    public class Dish
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public virtual List<Product> Products { get; set; }
    }
}
