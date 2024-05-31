using MyFirstLibrary.Models;

namespace MyFirstLibrary
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            yearNumericUpDown = new NumericUpDown();
            idNumericUpDown = new NumericUpDown();
            searchButton = new Button();
            label5 = new Label();
            label4 = new Label();
            publishHouseTextBox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            authorTextBox = new TextBox();
            nameTextBox = new TextBox();
            bookBindingSource = new BindingSource(components);
            addButton = new Button();
            removeButton = new Button();
            editButton = new Button();
            takeButton = new Button();
            menuStrip1 = new MenuStrip();
            nameMenuItem = new ToolStripMenuItem();
            аккаунтToolStripMenuItem = new ToolStripMenuItem();
            вийтиЗToolStripMenuItem = new ToolStripMenuItem();
            книгаToolStripMenuItem = new ToolStripMenuItem();
            addBookMenuItem = new ToolStripMenuItem();
            deleteBookMenuItem = new ToolStripMenuItem();
            editBookMenuItem = new ToolStripMenuItem();
            takeBookMenuItem = new ToolStripMenuItem();
            myBooksMenuItem = new ToolStripMenuItem();
            допомогаToolStripMenuItem = new ToolStripMenuItem();
            аToolStripMenuItem = new ToolStripMenuItem();
            countDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            publishHouseDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dateOfPublishDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            authorDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            titleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            resultsDataGridView = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)yearNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)idNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bookBindingSource).BeginInit();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)resultsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.None;
            groupBox1.Controls.Add(yearNumericUpDown);
            groupBox1.Controls.Add(idNumericUpDown);
            groupBox1.Controls.Add(searchButton);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(publishHouseTextBox);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(authorTextBox);
            groupBox1.Controls.Add(nameTextBox);
            groupBox1.Location = new Point(136, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(426, 214);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // yearNumericUpDown
            // 
            yearNumericUpDown.Location = new Point(94, 110);
            yearNumericUpDown.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            yearNumericUpDown.Name = "yearNumericUpDown";
            yearNumericUpDown.Size = new Size(310, 23);
            yearNumericUpDown.TabIndex = 3;
            // 
            // idNumericUpDown
            // 
            idNumericUpDown.Location = new Point(94, 25);
            idNumericUpDown.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            idNumericUpDown.Name = "idNumericUpDown";
            idNumericUpDown.Size = new Size(310, 23);
            idNumericUpDown.TabIndex = 0;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(329, 181);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(75, 23);
            searchButton.TabIndex = 5;
            searchButton.Text = "Пошук";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 141);
            label5.Name = "label5";
            label5.Size = new Size(78, 15);
            label5.TabIndex = 9;
            label5.Text = "Видавництво";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 112);
            label4.Name = "label4";
            label4.Size = new Size(71, 15);
            label4.TabIndex = 8;
            label4.Text = "Рік видання";
            // 
            // publishHouseTextBox
            // 
            publishHouseTextBox.Location = new Point(94, 138);
            publishHouseTextBox.MaxLength = 50;
            publishHouseTextBox.Name = "publishHouseTextBox";
            publishHouseTextBox.Size = new Size(310, 23);
            publishHouseTextBox.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 83);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 5;
            label3.Text = "Автор";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 54);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 4;
            label2.Text = "Назва";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 25);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 3;
            label1.Text = "ID";
            // 
            // authorTextBox
            // 
            authorTextBox.Location = new Point(94, 80);
            authorTextBox.MaxLength = 50;
            authorTextBox.Name = "authorTextBox";
            authorTextBox.Size = new Size(310, 23);
            authorTextBox.TabIndex = 2;
            authorTextBox.KeyPress += authorTextBox_KeyPress;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(94, 51);
            nameTextBox.MaxLength = 50;
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(310, 23);
            nameTextBox.TabIndex = 1;
            // 
            // bookBindingSource
            // 
            bookBindingSource.DataSource = typeof(Book);
            // 
            // addButton
            // 
            addButton.Anchor = AnchorStyles.None;
            addButton.Location = new Point(159, 380);
            addButton.Name = "addButton";
            addButton.Size = new Size(90, 23);
            addButton.TabIndex = 6;
            addButton.Text = "Додати";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // removeButton
            // 
            removeButton.Anchor = AnchorStyles.None;
            removeButton.Location = new Point(255, 380);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(90, 23);
            removeButton.TabIndex = 7;
            removeButton.Text = "Видалити";
            removeButton.UseVisualStyleBackColor = true;
            removeButton.Click += removeButton_Click;
            // 
            // editButton
            // 
            editButton.Anchor = AnchorStyles.None;
            editButton.Location = new Point(351, 380);
            editButton.Name = "editButton";
            editButton.Size = new Size(90, 23);
            editButton.TabIndex = 8;
            editButton.Text = "Редагувати";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // takeButton
            // 
            takeButton.Anchor = AnchorStyles.None;
            takeButton.Location = new Point(447, 380);
            takeButton.Name = "takeButton";
            takeButton.Size = new Size(90, 23);
            takeButton.TabIndex = 9;
            takeButton.Text = "Взяти книгу";
            takeButton.UseVisualStyleBackColor = true;
            takeButton.Click += takeButton_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.White;
            menuStrip1.Items.AddRange(new ToolStripItem[] { nameMenuItem, аккаунтToolStripMenuItem, книгаToolStripMenuItem, допомогаToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(696, 24);
            menuStrip1.TabIndex = 13;
            menuStrip1.Text = "menuStrip1";
            // 
            // nameMenuItem
            // 
            nameMenuItem.Enabled = false;
            nameMenuItem.Name = "nameMenuItem";
            nameMenuItem.Size = new Size(60, 20);
            nameMenuItem.Text = "Акаунт:";
            // 
            // аккаунтToolStripMenuItem
            // 
            аккаунтToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { вийтиЗToolStripMenuItem });
            аккаунтToolStripMenuItem.Name = "аккаунтToolStripMenuItem";
            аккаунтToolStripMenuItem.Size = new Size(57, 20);
            аккаунтToolStripMenuItem.Text = "Акаунт";
            // 
            // вийтиЗToolStripMenuItem
            // 
            вийтиЗToolStripMenuItem.Name = "вийтиЗToolStripMenuItem";
            вийтиЗToolStripMenuItem.Size = new Size(107, 22);
            вийтиЗToolStripMenuItem.Text = "Вийти";
            вийтиЗToolStripMenuItem.Click += logoutMenuItem_Click;
            // 
            // книгаToolStripMenuItem
            // 
            книгаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addBookMenuItem, deleteBookMenuItem, editBookMenuItem, takeBookMenuItem, myBooksMenuItem });
            книгаToolStripMenuItem.Name = "книгаToolStripMenuItem";
            книгаToolStripMenuItem.Size = new Size(52, 20);
            книгаToolStripMenuItem.Text = "Книги";
            // 
            // addBookMenuItem
            // 
            addBookMenuItem.Name = "addBookMenuItem";
            addBookMenuItem.Size = new Size(180, 22);
            addBookMenuItem.Text = "Додати";
            addBookMenuItem.Click += addButton_Click;
            // 
            // deleteBookMenuItem
            // 
            deleteBookMenuItem.Name = "deleteBookMenuItem";
            deleteBookMenuItem.Size = new Size(180, 22);
            deleteBookMenuItem.Text = "Видалити";
            deleteBookMenuItem.Click += removeButton_Click;
            // 
            // editBookMenuItem
            // 
            editBookMenuItem.Name = "editBookMenuItem";
            editBookMenuItem.Size = new Size(180, 22);
            editBookMenuItem.Text = "Редагувати";
            editBookMenuItem.Click += editButton_Click;
            // 
            // takeBookMenuItem
            // 
            takeBookMenuItem.Name = "takeBookMenuItem";
            takeBookMenuItem.Size = new Size(180, 22);
            takeBookMenuItem.Text = "Взяти книгу";
            takeBookMenuItem.Click += takeButton_Click;
            // 
            // myBooksMenuItem
            // 
            myBooksMenuItem.Name = "myBooksMenuItem";
            myBooksMenuItem.Size = new Size(180, 22);
            myBooksMenuItem.Text = "Мої книги";
            myBooksMenuItem.Click += takenBooksMenuItem_Click;
            // 
            // допомогаToolStripMenuItem
            // 
            допомогаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { аToolStripMenuItem });
            допомогаToolStripMenuItem.Name = "допомогаToolStripMenuItem";
            допомогаToolStripMenuItem.Size = new Size(75, 20);
            допомогаToolStripMenuItem.Text = "Допомога";
            // 
            // аToolStripMenuItem
            // 
            аToolStripMenuItem.Name = "аToolStripMenuItem";
            аToolStripMenuItem.Size = new Size(154, 22);
            аToolStripMenuItem.Text = "Про програму";
            аToolStripMenuItem.Click += aboutProgramMenuItem_Click;
            // 
            // countDataGridViewTextBoxColumn
            // 
            countDataGridViewTextBoxColumn.DataPropertyName = "Count";
            countDataGridViewTextBoxColumn.HeaderText = "Кількість";
            countDataGridViewTextBoxColumn.Name = "countDataGridViewTextBoxColumn";
            countDataGridViewTextBoxColumn.ReadOnly = true;
            countDataGridViewTextBoxColumn.Width = 81;
            // 
            // publishHouseDataGridViewTextBoxColumn
            // 
            publishHouseDataGridViewTextBoxColumn.DataPropertyName = "PublishHouse";
            publishHouseDataGridViewTextBoxColumn.HeaderText = "Видавництво";
            publishHouseDataGridViewTextBoxColumn.Name = "publishHouseDataGridViewTextBoxColumn";
            publishHouseDataGridViewTextBoxColumn.ReadOnly = true;
            publishHouseDataGridViewTextBoxColumn.Width = 103;
            // 
            // dateOfPublishDataGridViewTextBoxColumn
            // 
            dateOfPublishDataGridViewTextBoxColumn.DataPropertyName = "DateOfPublish";
            dateOfPublishDataGridViewTextBoxColumn.HeaderText = "Дата видання";
            dateOfPublishDataGridViewTextBoxColumn.Name = "dateOfPublishDataGridViewTextBoxColumn";
            dateOfPublishDataGridViewTextBoxColumn.ReadOnly = true;
            dateOfPublishDataGridViewTextBoxColumn.Width = 105;
            // 
            // authorDataGridViewTextBoxColumn
            // 
            authorDataGridViewTextBoxColumn.DataPropertyName = "Author";
            authorDataGridViewTextBoxColumn.HeaderText = "Автор";
            authorDataGridViewTextBoxColumn.Name = "authorDataGridViewTextBoxColumn";
            authorDataGridViewTextBoxColumn.ReadOnly = true;
            authorDataGridViewTextBoxColumn.Width = 65;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            titleDataGridViewTextBoxColumn.HeaderText = "Назва";
            titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            titleDataGridViewTextBoxColumn.ReadOnly = true;
            titleDataGridViewTextBoxColumn.Width = 64;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "ID";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Width = 43;
            // 
            // resultsDataGridView
            // 
            resultsDataGridView.AllowUserToAddRows = false;
            resultsDataGridView.AllowUserToDeleteRows = false;
            resultsDataGridView.Anchor = AnchorStyles.None;
            resultsDataGridView.AutoGenerateColumns = false;
            resultsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            resultsDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            resultsDataGridView.BackgroundColor = Color.White;
            resultsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resultsDataGridView.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, titleDataGridViewTextBoxColumn, authorDataGridViewTextBoxColumn, dateOfPublishDataGridViewTextBoxColumn, publishHouseDataGridViewTextBoxColumn, countDataGridViewTextBoxColumn });
            resultsDataGridView.DataSource = bookBindingSource;
            resultsDataGridView.Location = new Point(22, 247);
            resultsDataGridView.MultiSelect = false;
            resultsDataGridView.Name = "resultsDataGridView";
            resultsDataGridView.ReadOnly = true;
            resultsDataGridView.RowHeadersVisible = false;
            resultsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            resultsDataGridView.Size = new Size(652, 127);
            resultsDataGridView.TabIndex = 14;
            // 
            // Form1
            // 
            AcceptButton = searchButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(696, 450);
            Controls.Add(resultsDataGridView);
            Controls.Add(takeButton);
            Controls.Add(editButton);
            Controls.Add(removeButton);
            Controls.Add(addButton);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(712, 489);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)yearNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)idNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)bookBindingSource).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)resultsDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox authorTextBox;
        private TextBox nameTextBox;
        private Label label5;
        private Label label4;
        private TextBox publishHouseTextBox;
        private TextBox publishYearTextBox;
        private Button searchButton;
        private Button addButton;
        private Button removeButton;
        private Button editButton;
        private BindingSource bookBindingSource;
        private NumericUpDown idNumericUpDown;
        private NumericUpDown yearNumericUpDown;
        private Button takeButton;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem nameMenuItem;
        private DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn publishHouseDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateOfPublishDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridView resultsDataGridView;
        private ToolStripMenuItem книгаToolStripMenuItem;
        private ToolStripMenuItem addBookMenuItem;
        private ToolStripMenuItem deleteBookMenuItem;
        private ToolStripMenuItem editBookMenuItem;
        private ToolStripMenuItem takeBookMenuItem;
        private ToolStripMenuItem myBooksMenuItem;
        private ToolStripMenuItem допомогаToolStripMenuItem;
        private ToolStripMenuItem аToolStripMenuItem;
        private ToolStripMenuItem аккаунтToolStripMenuItem;
        private ToolStripMenuItem вийтиЗToolStripMenuItem;
    }
}
