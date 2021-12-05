using System;
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
            Inventory.addPart(new Inhouse(1, "seat", 24.00M, 15, 3, 35, 16));
            Inventory.addPart(new Inhouse(2, "pedal", 10.99M, 20, 23, 46, 16));
            Inventory.addPart(new Inhouse(3, "horn", 6.27M, 30, 1, 25, 60));
            Inventory.addPart(new Inhouse(4, "wheel", 35.99M, 28, 5, 20, 16));
            Inventory.addPart(new Outsourced(5, "handlebar", 15.87M, 20, 5, 10, "Redwing"));

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
