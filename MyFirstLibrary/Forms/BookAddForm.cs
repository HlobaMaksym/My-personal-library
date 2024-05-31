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
    public partial class BookAddForm : Form
    {
        private Library library;
        public BookAddForm(Library library)
        {
            this.library = library;
            InitializeComponent();
            countNumericUpDown.TextChanged += textBox_TextChanged;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Book book = CreateBook();
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

        private void authorTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Delete || Book.REGEX.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }

        private void textBox_TextChanged(object? sender, EventArgs? e)
        {
            addButton.Enabled = nameTextBox.Text.Length != 0
                && authorTextBox.Text.Length != 0
                && publishHouseTextBox.Text.Length != 0
                && countNumericUpDown.Text.Length != 0;
        }
    }
}
