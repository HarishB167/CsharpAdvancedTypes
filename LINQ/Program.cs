using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();

            var pagedBooks = books.Skip(2).Take(3);

            foreach (var book in pagedBooks)
            {
                Console.WriteLine(book.Title);
            }

            Console.WriteLine(books.Max(b => b.Price));
        }
    }
}
