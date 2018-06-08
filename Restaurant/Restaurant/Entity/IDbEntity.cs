using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Entity
{
    interface IDbEntity
    {
        [Key]
        Guid Id { get; set; }
    }
}
