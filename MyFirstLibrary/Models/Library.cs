using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MyFirstLibrary.Models
{
    public class Library
    {
        [JsonInclude]
        public List<Book> Books;
        [JsonInclude]
        public List<User> Users;
        [JsonInclude]
        public int? LoggedUserId;

        private const string PATH = "Library.txt";
        public Library(List<Book> books, List<User> users, int? loggedUserId)
        {
            Books = books;
            Users = users;
            LoggedUserId = loggedUserId;
        }

        public List<Book> Search(int? id = null, string? title = null, string? author = null, int? yearOfPublish = null, string? publishHouse = null)
        {
            return Books.Where(book =>
                (!id.HasValue || book.Id == id.Value) &&
                (string.IsNullOrEmpty(title) || book.Title.Contains(title, StringComparison.OrdinalIgnoreCase))
                && (string.IsNullOrEmpty(author) || book.Author.Contains(author, StringComparison.OrdinalIgnoreCase)) &&
                (!yearOfPublish.HasValue || book.DateOfPublish.Year == yearOfPublish.Value) &&
                (string.IsNullOrEmpty(publishHouse) || book.PublishHouse.Contains(publishHouse, StringComparison.OrdinalIgnoreCase))
            ).OrderBy(book => book.Title).ToList();
        }

        public void Edit(Book book)
        {
            Book? originalBook = Search(book.Id).FirstOrDefault();
            if (originalBook == null)
            {
                return;
            }
            originalBook.Update(book);
        }

        public void AddBook(Book book)
        {
            Books.Add(book);
        }

        public void SaveData()
        {
            var jsonString = JsonSerializer.Serialize(this);
            File.WriteAllText(PATH, jsonString);
        }

        public static Library LoadData()
        {
            var jsonString = "";
            try
            {
                jsonString = File.ReadAllText(PATH);
            }
            catch (FileNotFoundException)
            {

            }
            User defoltUser = new User(1, "Admin", "Nimda", [], true);
            Library emptyLibrary = new Library([], [defoltUser], defoltUser.Id);
            if (jsonString == "")
            {
                return emptyLibrary;
            }
            return JsonSerializer.Deserialize<Library>(jsonString) ?? emptyLibrary;
        }

        public bool IsUniqueBook(Book book)
        {
            return Books.Where(b => b.Title == book.Title && b.Author == book.Author && b.Id != book.Id).Count() == 0;
        }

        public void DeleteBook(int id)
        {
            Books.RemoveAll(book => book.Id == id);
        }

        public User? GetLoggedUser()
        {
            return Users.FirstOrDefault(user => user.Id == LoggedUserId);
        }

        public void TakeBook(Book book)
        {
            User? user = GetLoggedUser();
            if (user == null || book.Count == 0)
            {
                return;
            }
            book.Count--;
            user.TakeBook(book.Id);
        }

        public bool IsBookTaken(Book book)
        {
            return Users.Any(user => user.TakenBookIds.Contains(book.Id));
        }

        public List<Book> GetUserTakenBooks(User user)
        {
            return user.TakenBookIds.Select(id => Books.Find(Book => Book.Id == id)!).ToList();
        }

        public void ReturnBook(Book book)
        {
            User? user = GetLoggedUser();
            if (user == null)
            {
                return;
            }
            user.ReturnBook(book.Id);
            book.Count++;
        }

        public User? Login(string userName, string password)
        {
            return Users.Find(user => user.Name == userName && user.Password == password);
        }

        public User? Register(string userName, string password)
        {
            if (Users.Any(user => user.Name == userName))
            {
                return null;
            }
            int id = Users.Max(user => user.Id) + 1;
            User user = new User(id, userName, password, [], false);
            Users.Add(user);
            return user;
        }
    }
}
