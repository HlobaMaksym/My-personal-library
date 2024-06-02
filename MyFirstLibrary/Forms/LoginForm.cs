using Microsoft.VisualBasic.ApplicationServices;
using MyFirstLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using User = MyFirstLibrary.Models.User;

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

        private void registrationButton_Click(object sender, EventArgs e)
        {
            User? user = library.Register(userNameTextBox.Text.Trim(), passwordTextBox.Text.Trim());
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

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            loginButton.Enabled = registrationButton.Enabled = 
                userNameTextBox.Text.Trim().Length != 0 && passwordTextBox.Text.Trim().Length != 0;
        }
    }
}
