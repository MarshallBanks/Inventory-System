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

        public static void updatePart(int partIndex, Part modifiedPart)
        {
            PartList.RemoveAt(partIndex);
            PartList.Insert(partIndex, modifiedPart);
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
            HistoricalProductCount += 1;
            newProduct.ProductID = HistoricalProductCount;

            ProductList.Add(newProduct);
        }

        public static void updateProduct(int productIndex, Product modifiedProduct)
        {
            ProductList.RemoveAt(productIndex);
            ProductList.Insert(productIndex, modifiedProduct);
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
