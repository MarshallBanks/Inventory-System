﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Marshall_Banks_Inventory_System
{
    public class Product
    {
        public BindingList<Part> AssociatedParts { get; set; } 
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        // constructor
        public Product(int productID, string name , decimal price, int inStock, int min, int max)
        {
            ProductID = productID;
            Name = name;
            Price = price;
            InStock = inStock;
            Min = min;
            Max = max;
            AssociatedParts = new BindingList<Part>();
        }
    }
}
