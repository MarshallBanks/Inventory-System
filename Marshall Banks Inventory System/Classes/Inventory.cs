using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Marshall_Banks_Inventory_System
{
    public static class Inventory
    {
        public static BindingList<Product> Product {get; set;} 
        public static BindingList<Part> Part { get; set; }

        public static void addPart(Part part)
        {
            Part.Add(part);
        }
    }
}
