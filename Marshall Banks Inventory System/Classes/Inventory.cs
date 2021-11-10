using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Forms;

namespace Marshall_Banks_Inventory_System
{
    public static class Inventory
    {

        // ask mark kinkead why this fails? / how it should be written for get and set
        //public static BindingList<Product> Product {get; set;}
        //public static BindingList<Part> Part { get; set; } 

        public static BindingList<Product> ProductList = new BindingList<Product>();
        public static BindingList<Part> PartList = new BindingList<Part>();
  
        public static void addPart(Part partObject)
        {
            PartList.Add(partObject);
        }

        
    }
}
