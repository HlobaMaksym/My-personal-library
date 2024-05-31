using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyFirstLibrary.Models;

namespace MyFirstLibrary
{
    public partial class BookEditForm : Form
    {
        private Book book;
        private Library library;

        public BookEditForm(int bookId, Library library)
        {
            book = new Book(library.Search(bookId)[0]);
            this.library = library;
            InitializeComponent();
            countNumericUpDown.TextChanged += textBox_TextChanged;
            SetFieldsText();
        }
        private void SetFieldsText()
        {
            idNumericUpDown.Value = book.Id;
            nameTextBox.Text = book.Title;
            authorTextBox.Text = book.Author;
            dateOfPublishPicker.Value = book.DateOfPublish.ToDateTime(TimeOnly.MinValue);
            publishHouseTextBox.Text = book.PublishHouse;
            countNumericUpDown.Value = book.Count;
        }

        private void UpdateBook()
        {
            book.Title = nameTextBox.Text;
            book.Author = authorTextBox.Text;
            book.DateOfPublish = DateOnly.FromDateTime(dateOfPublishPicker.Value);
            book.PublishHouse = publishHouseTextBox.Text;
            book.Count = (int)countNumericUpDown.Value;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            UpdateBook();
            if (!book.Validate())
            {
                return;
            }
            if (!library.IsUniqueBook(book))
            {
                MessageBox.Show("Книга вже існує", "Сталася помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            library.Edit(book);
            library.SaveData();
            Close();
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
            saveButton.Enabled = nameTextBox.Text.Length != 0 
                && authorTextBox.Text.Length != 0 
                && publishHouseTextBox.Text.Length != 0 
                && countNumericUpDown.Text.Length != 0;
        }
    }
}
