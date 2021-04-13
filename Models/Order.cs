using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EvoWebsite.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime Date { get; set; }
        public string ClientName { get; set; }
        public string Telephone { get; set; }
        public string CarName { get; set; }
    }
}
