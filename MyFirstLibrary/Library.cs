using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MyFirstLibrary
{
    public class Library
    {
        [JsonInclude]
        public List<Book> Books;

        private const string PATH = "Library.txt";
        public Library(List<Book> books)
        {
            Books = books;
        }

        public List<Book> Search(int? id = null, string title = null, string author = null, int? yearOfPublish = null, string publishHouse = null)
        {
            return Books.Where(book =>
                (!id.HasValue || book.Id == id.Value) &&
                (string.IsNullOrEmpty(title) || book.Title.Contains(title, StringComparison.OrdinalIgnoreCase)) 
                && (string.IsNullOrEmpty(author) || book.Author.Contains(author, StringComparison.OrdinalIgnoreCase)) &&
                (!yearOfPublish.HasValue || book.DateOfPublish.Year == yearOfPublish.Value) &&
                (string.IsNullOrEmpty(publishHouse) || book.PublishHouse.Contains(publishHouse, StringComparison.OrdinalIgnoreCase))
            ).ToList();
        }

        public void SaveData()
        {
            var jsonString = JsonSerializer.Serialize(this);
            File.WriteAllText(PATH, jsonString);
        }

        public static Library LoadData()
        {
            var jsonString = File.ReadAllText(PATH);
            return JsonSerializer.Deserialize<Library>(jsonString) ?? new Library([]);
        }
    }
}
