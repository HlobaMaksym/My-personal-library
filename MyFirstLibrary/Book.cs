using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstLibrary
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public DateOnly DateOfPublish { get; set; }
        public string PublishHouse { get; set; }

        public Book(int id, string title, string author, DateOnly dateOfPublish, string publishHouse)
        {
            Id = id;
            Title = title;
            Author = author;
            DateOfPublish = dateOfPublish;
            PublishHouse = publishHouse;
        }

        
    }
}
