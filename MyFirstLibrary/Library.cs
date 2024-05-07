using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstLibrary
{
    public class Library
    {
        public List<Book> Books;
        public Library(List<Book> books)
        {
            Books = books;
        }
    }
}
