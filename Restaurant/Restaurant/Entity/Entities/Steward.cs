﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Restaurant.Entity.Entities
{
    [Table("Stewards")]
    public class Steward
    {
        public int ID { get; set; }
        public string Name { get; set; }


    }
}
