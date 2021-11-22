﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marshall_Banks_Inventory_System
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Preloaded data for Inventory.Part<BindingList>
            Inventory.addPart(new Inhouse(1, "seat", 6.27M, 1, 3, 15, 16));
            Inventory.addPart(new Inhouse(2, "pedal", 6.27M, 1, 3, 15, 16));
            Inventory.addPart(new Inhouse(3, "horn", 6.27M, 1, 3, 15, 16));
            Inventory.addPart(new Inhouse(4, "wheel", 6.27M, 1, 3, 15, 16));
            Inventory.addPart(new Outsourced(5, "handlebar", 6.27M, 1, 3, 15, "Redwing"));

            // Preloaded data for Inventory.Product<BindingList>
            Inventory.addProduct(new Product(1, "Bicycle", 3.45M, 50, 10, 30));
            Inventory.addProduct(new Product(2, "Tricycle", 5.66m, 20, 5, 25));
            Inventory.addProduct(new Product(3, "Scooter", 4.77m, 40, 10, 20));



            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
