using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CartWeb.Models
{
    public class ModelGadgets
    {
        public int IdGadgets  { get; set; }
        public String Name { get; set; }
        public String Type { get; set; }
        public String Descriptions { get; set; }
        public float Prise { get; set; }     
    }
}