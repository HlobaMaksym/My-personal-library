using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class LoginForm : Form
    {
        private Library library;
        public bool OpenMainForm { get; private set; }
        public LoginForm()
        {
            InitializeComponent();
            library = Library.LoadData();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            if (library.GetLoggedUser() != null)
            {
                OpenMainForm = true;
                Close();

            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (!ValidateFields())
            {
                return;
            }
            User? user = library.Login(userNameTextBox.Text, passwordTextBox.Text);
            if (user == null)
            {
                MessageBox.Show("Введено неправильне ім'я користувача або пароль", "Сталася помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            library.LoggedUserId = user.Id;
            library.SaveData();
            OpenMainForm = true;
            Close();
        }

        private bool ValidateFields()
        {
            if (userNameTextBox.Text.Length == 0 || passwordTextBox.Text.Length == 0)
            {
                MessageBox.Show("Заповніть поля", "Сталася помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void registrationButton_Click(object sender, EventArgs e)
        {
            if (!ValidateFields())
            {
                return;
            }
            User? user = library.Register(userNameTextBox.Text, passwordTextBox.Text);
            if (user == null)
            {
                MessageBox.Show("Таке ім'я користувача вже існує", "Сталася помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            library.LoggedUserId = user.Id;
            library.SaveData();
            OpenMainForm = true;
            Close();
        }
    }
}
