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
        public static BindingList<Product> ProductList = new BindingList<Product>();
        public static BindingList<Part> PartList = new BindingList<Part>();
        public static int HistoricalPartCount = 0;
        public static int HistoricalProductCount = 0;

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

        public static void addProduct(Product newProduct)
        {
            HistoricalPartCount += 1;
            newProduct.ProductID = HistoricalPartCount;

            ProductList.Add(newProduct);
        }

        public static bool deleteProduct(Product productObject)
        {
            try
            {
                ProductList.Remove(productObject);
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}
