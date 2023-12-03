using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LaptopShop
{
    internal class Cart
    {
        class CartItem
        {
            public string Name { get; set; }
            public double Price { get; set; }
            public string Brand { get; set; }

        }
        private ArrayList cartitems = new ArrayList();

        public void AddtoCartList(string name, double price, string brand)
        {
            CartItem existingProduct = null;
            foreach (CartItem item in cartitems)
            {
                if (item.Name == name)
                {
                    existingProduct = item;
                    break;
                }
            }

            CartItem newProduct = new CartItem
            {
                Name = name,
                Price = price,
                Brand = brand
            };

            cartitems.Add(newProduct);
            Console.WriteLine($"{brand} - {name} : {price} \n Added to Cart");
        }
        public void ShoppingCart()
        {
            Console.Clear();
            Console.WriteLine("-------------------");
            Console.WriteLine("<<<<<<Shopping Cart");
            Console.WriteLine("-------------------\n");

            foreach (var item in cartitems.OfType<CartItem>())
            {
                Console.WriteLine("----------------------------------------------------------");
                Console.WriteLine($"Name             |           {item.Name}");
                Console.WriteLine($"Unit Price       |         $ {item.Price}");
                Console.WriteLine($"Brand Name       |           {item.Brand}");
                Console.WriteLine("----------------------------------------------------------\n");
            }

            Console.WriteLine($"Total       |   $  {CalculateTotal()}");

            Console.WriteLine("DO you want to proceed the Order ? y/n");
            var choice = Console.ReadLine();
            Console.WriteLine(choice == "y" ? "---------------------\n Order Succeed ! \n---------------------" : "Thanks For Visiting"); 
        }

        private double CalculateTotal()
        {
            double total = 0;
            foreach (var item in cartitems.OfType<CartItem>())
            {
                total += item.Price;
            }
            return total;
        }


    }
}

