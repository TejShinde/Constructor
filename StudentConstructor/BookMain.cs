using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentConstructor
{
    internal class BookMain
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Book ID: ");
            int bid = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Book Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Book Price: ");
            double price = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Author Name: ");
            string author = Console.ReadLine();

            Book book = new Book(bid, name, price, author);

            book.DisplayBookDetails();
        }
    }
}
