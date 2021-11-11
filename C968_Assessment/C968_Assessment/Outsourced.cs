using System;
using System.Collections.Generic;
using System.Text;

namespace C968_Assessment
{
    public class Outsourced : Part
    {
        public string CompanyName { get; set;  }

        public Outsourced(string companyName, int partID, string name, decimal price, int inStock, int min, int max) 
            : base (partID, name, price, inStock, min, max)
        {
            CompanyName = companyName;
        }
    }
}
