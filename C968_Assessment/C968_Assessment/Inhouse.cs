using System;
using System.Collections.Generic;
using System.Text;

namespace C968_Assessment
{
    public class Inhouse : Part
    {
        public int MachineID { get; set; }

        public Inhouse(int machineID, int partID, string name, decimal price, int inStock, int min, int max)
            : base(partID, name, price, inStock, min, max) 
        {
            MachineID = machineID;
        }
    }
}
