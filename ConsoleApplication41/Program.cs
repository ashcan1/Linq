using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace ConsoleApplication41
{
    internal class Program
    {





        public static void Main(string[] args)
        {
            var books  = new BookReposotory().getBooks();

            var cheapBooks = books.Where(b => b.Price > 10);
            foreach (var N in cheapBooks)
            {
                Console.WriteLine(N.Title);
            }











        }

    }
}
