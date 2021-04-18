using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EvoWebsite.Models
{
    public class Vehicles
    {
        public string name { get; set; }
        [Key]
        public string model { get; set; }
        public double price { get; set; }
        public string category { get; set; }
        public string inshop { get; set; }
    }
}
