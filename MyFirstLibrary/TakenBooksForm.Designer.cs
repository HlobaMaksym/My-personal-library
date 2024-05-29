namespace MyFirstLibrary
{
    partial class TakenBooksForm
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
            components = new System.ComponentModel.Container();
            booksListBox = new ListBox();
            bookBindingSource = new BindingSource(components);
            returnBookButton = new Button();
            ((System.ComponentModel.ISupportInitialize)bookBindingSource).BeginInit();
            SuspendLayout();
            // 
            // booksListBox
            // 
            booksListBox.Anchor = AnchorStyles.None;
            booksListBox.DataSource = bookBindingSource;
            booksListBox.DisplayMember = "Title";
            booksListBox.FormattingEnabled = true;
            booksListBox.ItemHeight = 15;
            booksListBox.Location = new Point(10, 62);
            booksListBox.Name = "booksListBox";
            booksListBox.Size = new Size(237, 304);
            booksListBox.TabIndex = 2;
            booksListBox.ValueMember = "Id";
            // 
            // bookBindingSource
            // 
            bookBindingSource.DataSource = typeof(Book);
            // 
            // returnBookButton
            // 
            returnBookButton.Anchor = AnchorStyles.None;
            returnBookButton.Location = new Point(72, 372);
            returnBookButton.Name = "returnBookButton";
            returnBookButton.Size = new Size(113, 33);
            returnBookButton.TabIndex = 0;
            returnBookButton.Text = "Повернути книгу";
            returnBookButton.UseVisualStyleBackColor = true;
            returnBookButton.Click += returnBookButton_Click;
            // 
            // TakenBooksForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(256, 467);
            Controls.Add(returnBookButton);
            Controls.Add(booksListBox);
            MinimumSize = new Size(272, 506);
            Name = "TakenBooksForm";
            Text = "Мої книги";
            ((System.ComponentModel.ISupportInitialize)bookBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ListBox booksListBox;
        private Button returnBookButton;
        private BindingSource bookBindingSource;
    }
}