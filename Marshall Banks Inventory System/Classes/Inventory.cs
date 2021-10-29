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
        //public static BindingList<Part> Part { get; set; } // ask mark kinkead why this fails?

        public static BindingList<Part> PartList = new BindingList<Part>();
        public static void AddPart(Inhouse partObject)
        {
            PartList.Add(partObject);
        }
    }
}
