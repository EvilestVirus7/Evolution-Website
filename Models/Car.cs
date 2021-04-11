using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EvoWebsite.Models
{
    public class Car
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int CarId { get; set; }
        public string Name { get; set; }
        public string ImgPath { get; set; }
        public double Price { get; set; }
        public double MSRP { get; set; }
        public string Type { get; set; }
    }
}
