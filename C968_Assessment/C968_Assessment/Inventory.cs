using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace C968_Assessment
{
    public class Inventory
    {
        public static BindingList<Product> Products = new BindingList<Product>();
        public static BindingList<Part> AllParts = new BindingList<Part>();

        public static void AddProduct(Product productToAdd)
        {
            Products.Add(productToAdd);
        }
        public static bool RemoveProduct(int productToRemove)
        {
            bool productRemoved = false;            
            for (int i = 0; i < Products.Count; i++)
            {
                if(Products[i].ProductID == productToRemove)
                {
                    Products.RemoveAt(i);
                    productRemoved = true;
                }
            }
            
            return productRemoved;
        }
        public static Product LookupProduct(int productToLookup)
        {
            Product product = Products.SingleOrDefault(p => p.ProductID == productToLookup);
            return product;
        }
        public static void UpdateProduct(int productToUpdate, Product newProduct)
        {            
            
            RemoveProduct(productToUpdate);
            Products.Add(newProduct);
        }
        public static void AddPart(Part partToAdd)
        {
            AllParts.Add(partToAdd);
        }
        public static bool DeletePart(Part partToDelete)
        {
            bool partDeleted = false;
            
            for(int i = 0; i < AllParts.Count; i++)
            {
                if(AllParts[i].PartID == partToDelete.PartID)
                {
                    AllParts.RemoveAt(i);
                    partDeleted = true;
                }
            }
            return partDeleted;
        }
        public static Part LookupPart(int partToLookup)
        {
            Part part = AllParts.SingleOrDefault(p => p.PartID == partToLookup);
            return part;
        }
        public static void UpdatePart(int partToUpdate, Part newPart)
        {
            Part oldPartRemoval = LookupPart(partToUpdate);
            DeletePart(oldPartRemoval);
            AllParts.Add(newPart);
        }
    }
}
