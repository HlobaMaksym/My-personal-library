namespace MyFirstLibrary
{
    partial class BookAddForm
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
            groupBox1 = new GroupBox();
            countNumericUpDown = new NumericUpDown();
            label6 = new Label();
            dateOfPublishPicker = new DateTimePicker();
            addButton = new Button();
            label5 = new Label();
            label4 = new Label();
            publishHouseTextBox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            authorTextBox = new TextBox();
            nameTextBox = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)countNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.None;
            groupBox1.Controls.Add(countNumericUpDown);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(dateOfPublishPicker);
            groupBox1.Controls.Add(addButton);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(publishHouseTextBox);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(authorTextBox);
            groupBox1.Controls.Add(nameTextBox);
            groupBox1.Location = new Point(14, 2);
            groupBox1.MinimumSize = new Size(295, 258);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(295, 258);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // countNumericUpDown
            // 
            countNumericUpDown.Location = new Point(94, 150);
            countNumericUpDown.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            countNumericUpDown.Name = "countNumericUpDown";
            countNumericUpDown.Size = new Size(162, 23);
            countNumericUpDown.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(35, 154);
            label6.Name = "label6";
            label6.Size = new Size(56, 15);
            label6.TabIndex = 12;
            label6.Text = "Кількість";
            // 
            // dateOfPublishPicker
            // 
            dateOfPublishPicker.Location = new Point(94, 92);
            dateOfPublishPicker.Name = "dateOfPublishPicker";
            dateOfPublishPicker.Size = new Size(162, 23);
            dateOfPublishPicker.TabIndex = 11;
            // 
            // addButton
            // 
            addButton.Location = new Point(181, 179);
            addButton.Name = "addButton";
            addButton.Size = new Size(75, 23);
            addButton.TabIndex = 10;
            addButton.Text = "Додати";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 125);
            label5.Name = "label5";
            label5.Size = new Size(78, 15);
            label5.TabIndex = 9;
            label5.Text = "Видавництво";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 96);
            label4.Name = "label4";
            label4.Size = new Size(80, 15);
            label4.TabIndex = 8;
            label4.Text = "Дата видання";
            // 
            // publishHouseTextBox
            // 
            publishHouseTextBox.Location = new Point(94, 121);
            publishHouseTextBox.MaxLength = 50;
            publishHouseTextBox.Name = "publishHouseTextBox";
            publishHouseTextBox.Size = new Size(162, 23);
            publishHouseTextBox.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 68);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 5;
            label3.Text = "Автор";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 38);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 4;
            label2.Text = "Назва";
            // 
            // authorTextBox
            // 
            authorTextBox.Location = new Point(94, 63);
            authorTextBox.MaxLength = 50;
            authorTextBox.Name = "authorTextBox";
            authorTextBox.Size = new Size(162, 23);
            authorTextBox.TabIndex = 2;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(94, 34);
            nameTextBox.MaxLength = 50;
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(162, 23);
            nameTextBox.TabIndex = 1;
            // 
            // BookAddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(323, 263);
            Controls.Add(groupBox1);
            Name = "BookAddForm";
            Text = "Додавання книги";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)countNumericUpDown).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private NumericUpDown countNumericUpDown;
        private Label label6;
        private DateTimePicker dateOfPublishPicker;
        private Button addButton;
        private Label label5;
        private Label label4;
        private TextBox publishHouseTextBox;
        private Label label3;
        private Label label2;
        private TextBox authorTextBox;
        private TextBox nameTextBox;
    }
}