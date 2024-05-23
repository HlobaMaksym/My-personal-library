using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            SetFieldsText();
        }
        private void SetFieldsText()
        {
            idNumericUpDown.Value = book.Id;
            nameTextBox.Text = book.Title;
            authorTextBox.Text = book.Author;
            dateOfPublishPicker.Value = book.DateOfPublish.ToDateTime(TimeOnly.MinValue);
            publishHouseTextBox.Text = book.PublishHouse;
        }

        private void UpdateBook()
        {
            book.Title = nameTextBox.Text;
            book.Author = authorTextBox.Text;
            book.DateOfPublish = DateOnly.FromDateTime(dateOfPublishPicker.Value);
            book.PublishHouse = publishHouseTextBox.Text;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            UpdateBook();
            if (!book.Validate())
            {
                return;
            }
            library.Edit(book);
            library.SaveData();
            Close();
        }
    }
}
