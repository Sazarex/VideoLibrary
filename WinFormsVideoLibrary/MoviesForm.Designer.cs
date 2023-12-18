namespace WinFormsVideoLibrary
{
    partial class MoviesForm
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
            moviesDataGrid = new DataGridView();
            label1 = new Label();
            nameTextBox = new TextBox();
            producerTextBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            ageLimitNumericUpDown = new NumericUpDown();
            genreTextBox = new TextBox();
            label4 = new Label();
            label5 = new Label();
            creationDateDateTimePicker = new DateTimePicker();
            searchButton = new Button();
            ((System.ComponentModel.ISupportInitialize)moviesDataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ageLimitNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // moviesDataGrid
            // 
            moviesDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            moviesDataGrid.Location = new Point(13, 119);
            moviesDataGrid.Name = "moviesDataGrid";
            moviesDataGrid.RowTemplate.Height = 25;
            moviesDataGrid.Size = new Size(652, 319);
            moviesDataGrid.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 9);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 1;
            label1.Text = "Название";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(170, 6);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(185, 23);
            nameTextBox.TabIndex = 2;
            // 
            // producerTextBox
            // 
            producerTextBox.Location = new Point(170, 35);
            producerTextBox.Name = "producerTextBox";
            producerTextBox.Size = new Size(185, 23);
            producerTextBox.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 38);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 3;
            label2.Text = "Режиссер";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 67);
            label3.Name = "label3";
            label3.Size = new Size(151, 15);
            label3.TabIndex = 5;
            label3.Text = "Возврастное ограничение";
            // 
            // ageLimitNumericUpDown
            // 
            ageLimitNumericUpDown.Location = new Point(170, 65);
            ageLimitNumericUpDown.Name = "ageLimitNumericUpDown";
            ageLimitNumericUpDown.Size = new Size(185, 23);
            ageLimitNumericUpDown.TabIndex = 7;
            // 
            // genreTextBox
            // 
            genreTextBox.Location = new Point(480, 6);
            genreTextBox.Name = "genreTextBox";
            genreTextBox.Size = new Size(185, 23);
            genreTextBox.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(373, 9);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 8;
            label4.Text = "Жанр";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(373, 38);
            label5.Name = "label5";
            label5.Size = new Size(81, 15);
            label5.TabIndex = 10;
            label5.Text = "Дата выпуска";
            // 
            // creationDateDateTimePicker
            // 
            creationDateDateTimePicker.Location = new Point(480, 35);
            creationDateDateTimePicker.Name = "creationDateDateTimePicker";
            creationDateDateTimePicker.Size = new Size(185, 23);
            creationDateDateTimePicker.TabIndex = 12;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(590, 67);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(75, 23);
            searchButton.TabIndex = 13;
            searchButton.Text = "Поиск";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // MoviesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(675, 450);
            Controls.Add(searchButton);
            Controls.Add(creationDateDateTimePicker);
            Controls.Add(label5);
            Controls.Add(genreTextBox);
            Controls.Add(label4);
            Controls.Add(ageLimitNumericUpDown);
            Controls.Add(label3);
            Controls.Add(producerTextBox);
            Controls.Add(label2);
            Controls.Add(nameTextBox);
            Controls.Add(label1);
            Controls.Add(moviesDataGrid);
            Name = "MoviesForm";
            Text = "MoviesForm";
            ((System.ComponentModel.ISupportInitialize)moviesDataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)ageLimitNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox nameTextBox;
        private TextBox producerTextBox;
        private Label label2;
        private Label label3;
        private NumericUpDown ageLimitNumericUpDown;
        private TextBox genreTextBox;
        private Label label4;
        private Label label5;
        private DateTimePicker creationDateDateTimePicker;
        private Button searchButton;
        private DataGridView moviesDataGrid;
    }
}