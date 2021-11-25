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
        public static int HistoricalPartCount = 0;

        public static void addPart(Part newPart)
        {
            HistoricalPartCount += 1;
            newPart.PartID = HistoricalPartCount;

            PartList.Add(newPart);
        }

        public static void updatePart(Part modifiedPart)
        {
            PartList.RemoveAt(modifiedPart.PartID - 1);
            PartList.Insert((modifiedPart.PartID - 1), modifiedPart);
        }

        public static bool deletePart(Part partObject)
        {
            try
            {
               PartList.Remove(partObject);
               return true;
            }
            catch
            {
                return false;
            }
        }

        public static void addProduct(Product productObject)
        {
            productObject.ProductID = ProductList.Count + 1;
            ProductList.Add(productObject);
        }
        
    }
}
