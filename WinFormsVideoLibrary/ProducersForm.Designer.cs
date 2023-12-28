namespace WinFormsVideoLibrary
{
    partial class ProducersForm
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
            createMovie = new Button();
            Refresh = new Button();
            searchButton = new Button();
            nameTextBox = new TextBox();
            label1 = new Label();
            producersDataGrid = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)producersDataGrid).BeginInit();
            SuspendLayout();
            // 
            // createMovie
            // 
            createMovie.Location = new Point(12, 448);
            createMovie.Name = "createMovie";
            createMovie.Size = new Size(75, 23);
            createMovie.TabIndex = 25;
            createMovie.Text = "Создать";
            createMovie.UseVisualStyleBackColor = true;
            createMovie.Click += createMovie_Click;
            // 
            // Refresh
            // 
            Refresh.Location = new Point(402, 450);
            Refresh.Name = "Refresh";
            Refresh.Size = new Size(75, 23);
            Refresh.TabIndex = 24;
            Refresh.Text = "Обновить";
            Refresh.UseVisualStyleBackColor = true;
            Refresh.Click += Refresh_Click;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(400, 46);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(75, 23);
            searchButton.TabIndex = 23;
            searchButton.Text = "Поиск";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(169, 12);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(185, 23);
            nameTextBox.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(106, 15);
            label1.TabIndex = 17;
            label1.Text = "Ф.И.О. режиссера";
            // 
            // producersDataGrid
            // 
            producersDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            producersDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            producersDataGrid.Location = new Point(12, 88);
            producersDataGrid.MultiSelect = false;
            producersDataGrid.Name = "producersDataGrid";
            producersDataGrid.ReadOnly = true;
            producersDataGrid.RowTemplate.Height = 25;
            producersDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            producersDataGrid.Size = new Size(465, 356);
            producersDataGrid.TabIndex = 16;
            producersDataGrid.CellDoubleClick += producersDataGrid_CellDoubleClick;
            // 
            // ProducersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 490);
            Controls.Add(createMovie);
            Controls.Add(Refresh);
            Controls.Add(searchButton);
            Controls.Add(nameTextBox);
            Controls.Add(label1);
            Controls.Add(producersDataGrid);
            Name = "ProducersForm";
            Text = "Перечень режиссеров";
            ((System.ComponentModel.ISupportInitialize)producersDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button createMovie;
        private Button Refresh;
        private Button searchButton;
        private TextBox nameTextBox;
        private Label label1;
        public DataGridView producersDataGrid;
    }
}