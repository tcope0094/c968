using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace C968_Assessment
{
   public class Product
    {
        public static int currentID = 0;
        public static BindingList<Part> AssociatedParts { get; set; }
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        public Product(BindingList<Part> associatedParts, int productId, string name, decimal price, int inStock, int min, int max)
        {
            AssociatedParts = associatedParts;
            ProductID = productId;
            Name = name;
            Price = price;
            InStock = inStock;
            Min = min;
            Max = max;
        }
        public static void AddAssociatedPart(Part partToAdd)
        {
            if (LookupAssociatedPart(partToAdd.PartID) != null)
            {
                MessageBox.Show("Product already contains part.");
            }
            else
            {
                AssociatedParts.Add(partToAdd);
            }
        }
        public static bool RemoveAssociatedPart(int partToRemove)
        {
            bool partRemoved = false;
            for (int i = 0; i < AssociatedParts.Count; i++)
            {
                if(AssociatedParts[i].PartID == partToRemove)
                {
                    AssociatedParts.RemoveAt(i);
                }
            }
            return partRemoved;
        }
        public static Part LookupAssociatedPart(int partToLookup)
        {
            Part lookedUpPart = AssociatedParts.SingleOrDefault(p => p.PartID == partToLookup);
            return lookedUpPart;
        }
        public static int GetNewProductId()
        {
            return ++currentID;
        }
    }
}
