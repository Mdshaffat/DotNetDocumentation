using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FirstCoreWeb.Models
{
    public class Item
    {
        [Key]
        public int Id { get; set; }
        public int ItemCategory { get; set; }
        public string Name { get; set; }
        public decimal UnitPrice { get; set; }
        public string UnitOfMeasure { get; set; }
        public bool IsActive { get; set; }
    }
}
