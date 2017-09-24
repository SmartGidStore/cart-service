using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Gadget
    {
        public int IdGadgets { get; set; }
        public String Name { get; set; }
        public String Type { get; set; }
        public String Descriptions { get; set; }
        public String Count { get; set; }
        public decimal Price { get; set; }
    }
}
