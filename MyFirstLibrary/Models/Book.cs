using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MyFirstLibrary.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public DateOnly DateOfPublish { get; set; }
        public string PublishHouse { get; set; }
        public int Count { get; set; }
        private const int FIRST_BOOK_PUBLISH_YEAR = 1574;
        public static readonly Regex REGEX = new Regex(@"[\d!@#$%^&*()_+=\[{\]};:<>|./?,]");

        [JsonConstructor]
        public Book(int id, string title, string author, 
            DateOnly dateOfPublish, string publishHouse, int count)
        {
            Id = id;
            Title = title;
            Author = author;
            DateOfPublish = dateOfPublish;
            PublishHouse = publishHouse;
            Count = count;
        }

        public void Update(Book book)
        {
            Title = book.Title;
            Author = book.Author;
            DateOfPublish = book.DateOfPublish;
            PublishHouse = book.PublishHouse;
            Count = book.Count;
        }

        public bool Validate()
        {
            if (DateOfPublish > DateOnly.FromDateTime(DateTime.Now) 
                || DateOfPublish.Year < FIRST_BOOK_PUBLISH_YEAR)
            {
                MessageBox.Show("Дату публікації введено не вірно",
                    "Сталася помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public Book(Book book)
        {
            Id = book.Id;
            Title = book.Title;
            Author = book.Author;
            DateOfPublish = book.DateOfPublish;
            PublishHouse = book.PublishHouse;
            Count = book.Count;
        }

    }
}
