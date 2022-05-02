using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.ProductShop
{
    class Product
    { 
        public String Name { get; set; }
        public double Price { get; set; }
        public Product(string name,double price)
        {
            Name = name;
            Price = price;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
           SortedDictionary<string,List<Product> > stores = new SortedDictionary<string,List<Product>>();
            string command;
            while((command=Console.ReadLine())!= "Revision")
            {
                string[] inputData=command.Split(", ",StringSplitOptions.RemoveEmptyEntries);
                string storeName=inputData[0];
                string productName=inputData[1];
                double productPrice=double.Parse(inputData[2]);

                if (!stores.ContainsKey(storeName))
                {
                    Product newProduct = new Product(productName, productPrice);
                    stores.Add(storeName, new List<Product>() { newProduct});
                }
                else
                {
                    stores[storeName].Add(new Product(productName, productPrice));
                }
            }
           
            foreach (var store in stores)
            {
                Console.WriteLine($"{store.Key}->");
                foreach (var product in store.Value)
                {
                    Console.WriteLine($"Product: {product.Name}, Price: {product.Price}");
                }
            }
        }
    }
}
