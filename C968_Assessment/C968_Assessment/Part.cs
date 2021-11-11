using System;
using System.Collections.Generic;
using System.Text;

namespace C968_Assessment
{
    public abstract class Part
    {
        public static int currentID = 0;
        public int PartID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        public Part(int partID, string name, decimal price, int inStock, int min, int max)
        {
            PartID = partID;
            Name = name;
            Price = price;
            InStock = inStock;
            Min = min;
            Max = max;
        }

        public static int GetNewPartID()
        {
            return ++currentID;
        }
    }
}
