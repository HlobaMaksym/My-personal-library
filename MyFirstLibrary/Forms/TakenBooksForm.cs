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
            bookBindingSource.DataSource = library.GetUserTakenBooks(library.GetLoggedUser()!);
        }

        private void returnBookButton_Click(object sender, EventArgs e)
        {
            Book? selectedBook = bookBindingSource.Current as Book;
            if (selectedBook == null)
            {
                MessageBox.Show("Книга не обрана", "Сталася помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            library.ReturnBook(selectedBook);
            library.SaveData();
            UpdateBooks();
            MessageBox.Show("Ви успішно повернули книгу", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
