using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentConstructor
{
    internal class Book
    {
        private int bid;
        private string name;
        private double price;
        private string author;

        public Book(int b, string n, double p, string a)
        {
            bid = b;
            name = n;
            price = p;
            author = a;
        }

        public void DisplayBookDetails()
        {
            Console.WriteLine("Book ID: " + bid);
            Console.WriteLine("Book Name: " + name);
            Console.WriteLine("Price: " + price);
            Console.WriteLine("Author: " + author);
        }
    }

}

