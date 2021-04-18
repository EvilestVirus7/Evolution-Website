using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EvoWebsite.ViewsModels
{
    public class EditCarVM
    {
        public int CarId { get; set; }
        public string Name { get; set; }
        public string ImgPath { get; set; }
        public double Price { get; set; }
        public double MSRP { get; set; }
        public string Type { get; set; }
    }
}
