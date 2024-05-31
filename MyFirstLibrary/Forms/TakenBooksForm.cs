using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyFirstLibrary.Models;

namespace MyFirstLibrary
{
    public partial class TakenBooksForm : Form
    {
        private Library library;
        public TakenBooksForm(Library library)
        {
            InitializeComponent();
            this.library = library;
            UpdateBooks();
        }

        private void UpdateBooks()
        {
            List<Book> books = library.GetUserTakenBooks(library.GetLoggedUser()!);
            bookBindingSource.DataSource = books;
            returnBookButton.Enabled = books.Count != 0;
        }

        private void returnBookButton_Click(object sender, EventArgs e)
        {
            Book selectedBook = (Book)bookBindingSource.Current;
            DialogResult result = MessageBox.Show($"Ви точно хочете повернути книгу {selectedBook.Title}?",
                "Пітвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                library.ReturnBook(selectedBook);
                library.SaveData();
                UpdateBooks();
            }
        }
    }
}
