using System;
using System.Collections.Generic;

namespace ConsoleApplication41
{
    public class BookReposotory
    {

        public IEnumerable<Book> getBooks()
        {
            return new List<Book>
            {
                new Book() {Title = "Long road", Price = 4},
                new Book() {Title = "Short Road", Price = 4.99f},
                new Book() {Title = "My Road", Price = 13},
                new Book() {Title = "Endless Road", Price = 4}
                


            };

     
        }

    }
}