using System.Windows.Forms;

namespace MyFirstLibrary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Library library;

        private void Form1_Load(object sender, EventArgs e)
        {
            library = Library.LoadData();
            idNumericUpDown.Text = "";
            yearNumericUpDown.Text = "";
            resultsListBox.DrawMode = DrawMode.OwnerDrawFixed;
            searchButton_Click(null, null);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            int? id = null;
            int? year = null;
            if (idNumericUpDown.Text != "")
            {
                id = (int)idNumericUpDown.Value;
            }
            if (yearNumericUpDown.Text != "")
            {
                year = (int)yearNumericUpDown.Value;
            }
            bookBindingSource.DataSource = library.Search(id,
                nameTextBox.Text, authorTextBox.Text,
                year, publishHouseTextBox.Text);
        }

        private Book? GetSelectedBook()
        {
            Book? selectedBook = bookBindingSource.Current as Book;
            if (selectedBook == null)
            {
                MessageBox.Show("Книга не обрана", "Сталася помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            return selectedBook;
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            Book? selectedBook = GetSelectedBook();
            if (selectedBook == null)
            {
                return;
            }
            BookEditForm form = new BookEditForm(selectedBook.Id, library);
            form.ShowDialog();
            searchButton_Click(null, null);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            BookAddForm form = new BookAddForm(library);
            form.ShowDialog();
            searchButton_Click(null, null);
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            Book? selectedBook = GetSelectedBook();
            if (selectedBook == null)
            {
                return;
            }
            if (library.IsBookTaken(selectedBook))
            {
                MessageBox.Show("Не всі книги були повернені користувачами. Видалення неможливе", "Сталася помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult result = MessageBox.Show("Ви точно хочете видалити цю книгу?", "Пітвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                library.DeleteBook(selectedBook.Id);
                library.SaveData();
                searchButton_Click(null, null);
            }
        }

        private void takeButton_Click(object sender, EventArgs e)
        {
            Book? selectedBook = GetSelectedBook();
            if (selectedBook == null)
            {
                return;
            }
            if (selectedBook.Count == 0)
            {
                MessageBox.Show("Наразі даної книги немає", "Сталася помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult result = MessageBox.Show("Ви точно хочете взяти цю книгу?", "Пітвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                library.TakeBook(selectedBook);
                library.SaveData();
                MessageBox.Show("Ви успішно взяли книгу", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void resultsListBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            e.DrawFocusRectangle();
            int selectedIndex = resultsListBox.SelectedIndex;
            Color color = Color.White;
            if (e.Index == -1)
            {
                return;
            }
            Book? item = resultsListBox.Items[e.Index] as Book;
            if (item != null)
            {
                if (selectedIndex != e.Index)
                {
                    color = item.TitleColor;
                }
                e.Graphics.DrawString(item.Title, resultsListBox.Font, new SolidBrush(color), 0, e.Index * resultsListBox.ItemHeight);
            }
        }

        private void resultsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            resultsListBox.Invalidate();
        }
    }
}
