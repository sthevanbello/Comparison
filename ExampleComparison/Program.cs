﻿using ExampleComparison.Entities;
using System;
using System.Collections.Generic;

namespace ExampleComparison
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Product> list = new List<Product>();

            list.Add(new Product("Television", 900.00));
            list.Add(new Product("Notebook", 1200.00));
            list.Add(new Product("Tablet", 450.00));
            list.Add(new Product("SmartPhone", 1000.00));

            list.Sort(CompareProducts);

            foreach (Product item in list)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }

        static int CompareProducts(Product p1, Product p2)
        {
            return p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
        }
    }
}
