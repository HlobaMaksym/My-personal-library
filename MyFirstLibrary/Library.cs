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

        public List<Book> Search(int? id = null, string title = null, string author = null, int? yearOfPublish = null, string publishHouse = null)
        {
            return Books.Where(book =>
                (!id.HasValue || book.Id == id.Value) &&
                (string.IsNullOrEmpty(title) || book.Title.Contains(title, StringComparison.OrdinalIgnoreCase)) &&
                (string.IsNullOrEmpty(author) || book.Author.Contains(author, StringComparison.OrdinalIgnoreCase)) &&
                (!yearOfPublish.HasValue || book.DateOfPublish.Year == yearOfPublish.Value) &&
                (string.IsNullOrEmpty(publishHouse) || book.PublishHouse.Contains(publishHouse, StringComparison.OrdinalIgnoreCase))
            ).ToList();
        }
    }
}
