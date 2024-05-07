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
        public string Autor { get; set; }
        public string DataOfPublic { get; set; }

        public Book(int id, string title, string autor, string dataOfPublic)
        {
            Id = id;
            Title = title;
            Autor = autor;
            DataOfPublic = dataOfPublic;
        }
    }
}
