using System;
using System.Collections.Generic;
using Wintellect.PowerCollections;

namespace _2.Products
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderedBag<Product> productsList = new OrderedBag<Product>();
            GenerateProducts(productsList, 500000);
            
            Console.WriteLine("Get start price: ");
            int start = int.Parse(Console.ReadLine());
            Product startProduct = new Product("Start", start);
            
            Console.WriteLine("Get end price: ");
            int end = int.Parse(Console.ReadLine());
            Product endProduct = new Product("End", end);
            for (int i = 0; i < 10000; i++)
            {
                var extract = productsList.Range(startProduct, true, endProduct, true);

                //Run this only one time to see the results
                //for (int j = 0; j < 20 && j < extract.Count; j++)
                //{
                //    Console.WriteLine(extract[j]);
                //}
            }
        }

        static void GenerateProducts(OrderedBag<Product> productsList, int count)
        {   
            Random randomGenerator = new Random();
            Console.WriteLine("Generating random " + count + " products");
            for (int i = 0; i < count; i++)
            {
                productsList.Add(new Product("Random Name: ", randomGenerator.Next(500000)));
            }
            Console.WriteLine("Done");
        }

    }
}
