using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstLibrary
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public List<int> TakenBookIds { get; set; }
        public bool IsAdmin {  get; set; }
        public User(int id, string name, string password, List<int> takenBookIds, bool isAdmin) 
        {
            Id = id;
            Name = name;
            Password = password;
            TakenBookIds = takenBookIds;
            IsAdmin = isAdmin;
        }
        public void TakeBook(int id)
        {
            TakenBookIds.Add(id);
        }

        public bool IsBookTaken(int id)
        {
            return TakenBookIds.Contains(id);
        }

        public void ReturnBook(int id)
        {
            TakenBookIds.Remove(id);
        }
    }
}
