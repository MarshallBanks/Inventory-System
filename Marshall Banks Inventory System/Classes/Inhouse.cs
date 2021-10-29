using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marshall_Banks_Inventory_System
{
    public class Inhouse : Part
    {
        public int MachineID { get; set; }

        public Inhouse(int partID, string name, decimal price, int inStock, int min, int max, int machineID) 
            : base(partID, name, price, inStock, min, max) 
        {
            MachineID = machineID;
        }


    }
}
