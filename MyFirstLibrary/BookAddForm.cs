using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstLibrary
{
    public partial class BookAddForm : Form
    {
        private Library library;
        public BookAddForm(Library library)
        {
            this.library = library;
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Book book = CreateBook();
            if (countNumericUpDown.Text.Length == 0)
            {
                MessageBox.Show("Кількість не введено", "Сталася помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!book.Validate())
            {
                return;
            }
            if (!library.IsUniqueBook(book))
            {
                MessageBox.Show("Така книга вже існує", "Сталася помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            library.AddBook(book);
            library.SaveData();
            Close();
        }

        private Book CreateBook()
        {
            int id = library.Books.MaxBy(book => book.Id)?.Id ?? 0;
            return new Book(id + 1, nameTextBox.Text, authorTextBox.Text, DateOnly.FromDateTime(dateOfPublishPicker.Value), publishHouseTextBox.Text, (int)countNumericUpDown.Value);
        }
    }
}
