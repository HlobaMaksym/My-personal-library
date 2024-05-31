namespace MyFirstLibrary
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label3 = new Label();
            label2 = new Label();
            userNameTextBox = new TextBox();
            loginButton = new Button();
            registrationButton = new Button();
            passwordTextBox = new TextBox();
            SuspendLayout();
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(51, 91);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 17;
            label3.Text = "Пароль";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(52, 39);
            label2.Name = "label2";
            label2.Size = new Size(100, 15);
            label2.TabIndex = 15;
            label2.Text = "Ім'я користувача";
            // 
            // userNameTextBox
            // 
            userNameTextBox.Anchor = AnchorStyles.None;
            userNameTextBox.Location = new Point(48, 57);
            userNameTextBox.MaxLength = 50;
            userNameTextBox.Name = "userNameTextBox";
            userNameTextBox.Size = new Size(132, 23);
            userNameTextBox.TabIndex = 0;
            userNameTextBox.TextChanged += textBox_TextChanged;
            // 
            // loginButton
            // 
            loginButton.Anchor = AnchorStyles.None;
            loginButton.Enabled = false;
            loginButton.Location = new Point(48, 152);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(132, 23);
            loginButton.TabIndex = 2;
            loginButton.Text = "Увійти";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // registrationButton
            // 
            registrationButton.Anchor = AnchorStyles.None;
            registrationButton.Enabled = false;
            registrationButton.Location = new Point(48, 181);
            registrationButton.Name = "registrationButton";
            registrationButton.Size = new Size(132, 23);
            registrationButton.TabIndex = 3;
            registrationButton.Text = "Зареєструватися";
            registrationButton.UseVisualStyleBackColor = true;
            registrationButton.Click += registrationButton_Click;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Anchor = AnchorStyles.None;
            passwordTextBox.Location = new Point(48, 110);
            passwordTextBox.MaxLength = 15;
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(132, 23);
            passwordTextBox.TabIndex = 1;
            passwordTextBox.UseSystemPasswordChar = true;
            passwordTextBox.TextChanged += textBox_TextChanged;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(228, 242);
            Controls.Add(passwordTextBox);
            Controls.Add(registrationButton);
            Controls.Add(loginButton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(userNameTextBox);
            MinimumSize = new Size(244, 281);
            Name = "LoginForm";
            Text = "Вхід до бібліотеки";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown yearNumericUpDown;
        private Label label5;
        private Label label4;
        private TextBox publishHouseTextBox;
        private Label label3;
        private Label label2;
        private TextBox authorTextBox;
        private TextBox userNameTextBox;
        private Button loginButton;
        private Button registrationButton;
        private TextBox passwordTextBox;
    }
}