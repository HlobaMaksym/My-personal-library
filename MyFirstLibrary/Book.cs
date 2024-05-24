using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
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
        public int Count { get; set; }
        private const int FIRST_BOOK_PUBLISH_YEAR = 1574;
        public Color TitleColor => Count == 0 ? Color.DarkGray : Color.Black;

        [JsonConstructor]
        public Book(int id, string title, string author, DateOnly dateOfPublish, string publishHouse, int count)
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
            if (Title.Length == 0)
            {
                MessageBox.Show("Назву книги не введено", "Сталася помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (Author.Length == 0)
            {
                MessageBox.Show("Ім'я автора книги не введено", "Сталася помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (DateOfPublish > DateOnly.FromDateTime(DateTime.Now) || DateOfPublish.Year < FIRST_BOOK_PUBLISH_YEAR)
            {
                MessageBox.Show("Дату публікації введено не вірно", "Сталася помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (PublishHouse.Length == 0)
            {
                MessageBox.Show("Видавництво не введено", "Сталася помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
