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
            //List<Book> book = new List<Book>();
            //Book newBook1 = new Book(0, "test1", "author1", 
            //    DateOnly.Parse("01.01.2021"), "house1");
            //Book newBook2 = new Book(1, "test2", "author2", 
            //    DateOnly.Parse("01.01.2022"), "house2");
            //Book newBook3 = new Book(2, "test3", "author3", 
            //    DateOnly.Parse("01.01.2023"), "house3");
            //book.Add(newBook1);
            //book.Add(newBook2);
            //book.Add(newBook3);
            //library = new Library(book);
            //library.SaveData();
            library = Library.LoadData();
            idNumericUpDown.Text = "";
            yearNumericUpDown.Text = "";
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

        private void editButton_Click(object sender, EventArgs e)
        {
            Book? selectedBook = bookBindingSource.Current as Book;
            if (selectedBook == null) 
            {
                MessageBox.Show("Книга не обрана", "Сталася помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            BookEditForm form = new BookEditForm(selectedBook.Id, library);
            form.ShowDialog();
            searchButton_Click(null, null);
        }
    }
}
