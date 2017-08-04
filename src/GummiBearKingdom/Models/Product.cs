using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GummiBearKingdom.Models
{
    [Table("Products")]
    public class Product
    {
        public int id { get; set; }
        public string name { get; set; }
        public float cost { get; set; }
        public string origin { get; set; }
    }
}
