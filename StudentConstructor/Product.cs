using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentConstructor
{
    internal class Product
    {
        private int code;
        private string name;
        private double price;

        public Product(int code,string name,double price)
        {
            this.code = code;
            this.name = name;
            this.price = price;
        }
        public double GetDiscountedPrice()
        {
            if (price > 1000)
            {
                return price * 0.9;  // Apply 10% discount
            }
            return price;  // No discount if price is <= 1000
        }

       
        public void DisplayProductDetails()
        {
            Console.WriteLine("Product Code: " + code);
            Console.WriteLine("Product Name: " + name);
            Console.WriteLine("Original Price: " + price);
            Console.WriteLine("Discounted Price: " + GetDiscountedPrice());
        }
    }
}
