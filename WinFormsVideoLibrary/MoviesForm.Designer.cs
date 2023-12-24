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
            genreTextBox = new TextBox();
            label4 = new Label();
            searchButton = new Button();
            Refresh = new Button();
            ((System.ComponentModel.ISupportInitialize)moviesDataGrid).BeginInit();
            SuspendLayout();
            // 
            // moviesDataGrid
            // 
            moviesDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            moviesDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            moviesDataGrid.Location = new Point(13, 82);
            moviesDataGrid.MultiSelect = false;
            moviesDataGrid.Name = "moviesDataGrid";
            moviesDataGrid.ReadOnly = true;
            moviesDataGrid.RowTemplate.Height = 25;
            moviesDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            moviesDataGrid.Size = new Size(652, 356);
            moviesDataGrid.TabIndex = 0;
            moviesDataGrid.CellDoubleClick += moviesDataGrid_CellDoubleClick;
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
            // searchButton
            // 
            searchButton.Location = new Point(588, 38);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(75, 23);
            searchButton.TabIndex = 13;
            searchButton.Text = "Поиск";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // Refresh
            // 
            Refresh.Location = new Point(590, 442);
            Refresh.Name = "Refresh";
            Refresh.Size = new Size(75, 23);
            Refresh.TabIndex = 14;
            Refresh.Text = "Обновить";
            Refresh.UseVisualStyleBackColor = true;
            Refresh.Click += Refresh_Click;
            // 
            // MoviesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(675, 477);
            Controls.Add(Refresh);
            Controls.Add(searchButton);
            Controls.Add(genreTextBox);
            Controls.Add(label4);
            Controls.Add(producerTextBox);
            Controls.Add(label2);
            Controls.Add(nameTextBox);
            Controls.Add(label1);
            Controls.Add(moviesDataGrid);
            Name = "MoviesForm";
            Text = "MoviesForm";
            ((System.ComponentModel.ISupportInitialize)moviesDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox nameTextBox;
        private TextBox producerTextBox;
        private Label label2;
        private TextBox genreTextBox;
        private Label label4;
        private Button searchButton;
        public DataGridView moviesDataGrid;
        private Button Refresh;
    }
}