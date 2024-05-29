using System.Windows.Forms;

namespace MyFirstLibrary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private Library library;
        public bool OpenLogin { get; private set; }

        private void Form1_Load(object sender, EventArgs e)
        {
            library = Library.LoadData();
            idNumericUpDown.Text = "";
            yearNumericUpDown.Text = "";
            searchButton_Click(null, null);
            if (library.GetLoggedUser()?.IsAdmin == false)
            {
                HideAdminButtons();
            }
            nameMenuItem.Text += $" {library.GetLoggedUser()?.Name}";
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
                MessageBox.Show("Книга не обрана", "Сталася помилка", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Не всі книги були повернені користувачами. Видалення неможливе", 
                    "Сталася помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult result = MessageBox.Show("Ви точно хочете видалити цю книгу?", 
                "Пітвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                MessageBox.Show("Наразі даної книги немає", 
                    "Сталася помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (library.GetLoggedUser()?.IsBookTaken(selectedBook.Id) == true)
            {
                MessageBox.Show("Ви не можете взяти більше одного примірника цієї книги", 
                    "Сталася помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult result = MessageBox.Show("Ви точно хочете взяти цю книгу?", 
                "Пітвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                library.TakeBook(selectedBook);
                library.SaveData();
                searchButton_Click(null, null);
                MessageBox.Show("Ви успішно взяли книгу", 
                    "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void takenBooksMenuItem_Click(object sender, EventArgs e)
        {
            TakenBooksForm takenBooksForm = new TakenBooksForm(library);
            takenBooksForm.ShowDialog();
            searchButton_Click(null, null);
        }

        private void logoutMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ви точно хочете вийти з акаунту?", 
                "Пітвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                library.LoggedUserId = null;
                library.SaveData();
                OpenLogin = true;
                Close();
            }
        }

        private void HideAdminButtons()
        {
            addButton.Visible = false;
            editButton.Visible = false;
            removeButton.Visible = false;
            resultsDataGridView.Left = (ClientSize.Width - resultsDataGridView.Width) / 2;
            takeButton.Left = (ClientSize.Width - takeButton.Width) / 2;
        }

        private void aboutProgramMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("   Розробник цієї програми Глоба Максим.\n   Програма являє собою зручний додаток для користування електронною бібліотекою. Дозволяє користувачеві шукати цікаві йому книжки за деякими критеріями та брати ці книжки з можливістю їх повертання. Для бібліотекаря (Адміна) доступні всі можливості, які доступні користувачеві, а також додаткові можливості, такі як: додавання, видалення та редагування книг.", "Про програму", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
