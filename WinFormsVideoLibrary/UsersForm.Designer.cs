namespace WinFormsVideoLibrary
{
    partial class UsersForm
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
            label1 = new Label();
            nameTextBox = new TextBox();
            isActive = new CheckBox();
            isNotActive = new CheckBox();
            search = new Button();
            usersDataGrid = new DataGridView();
            refresh = new Button();
            createUser = new Button();
            ((System.ComponentModel.ISupportInitialize)usersDataGrid).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 14);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 0;
            label1.Text = "Ф.И.О.";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(118, 11);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(181, 23);
            nameTextBox.TabIndex = 1;
            // 
            // isActive
            // 
            isActive.AutoSize = true;
            isActive.Location = new Point(14, 52);
            isActive.Name = "isActive";
            isActive.Size = new Size(126, 19);
            isActive.TabIndex = 5;
            isActive.Text = "Подписка активна";
            isActive.UseVisualStyleBackColor = true;
            isActive.CheckedChanged += isActive_CheckedChanged;
            // 
            // isNotActive
            // 
            isNotActive.AutoSize = true;
            isNotActive.Location = new Point(160, 52);
            isNotActive.Name = "isNotActive";
            isNotActive.Size = new Size(139, 19);
            isNotActive.TabIndex = 6;
            isNotActive.Text = "Подписка неактивна";
            isNotActive.UseVisualStyleBackColor = true;
            isNotActive.CheckedChanged += isNotActive_CheckedChanged;
            // 
            // search
            // 
            search.Location = new Point(694, 15);
            search.Name = "search";
            search.Size = new Size(75, 23);
            search.TabIndex = 7;
            search.Text = "Поиск";
            search.UseVisualStyleBackColor = true;
            search.Click += search_Click;
            // 
            // usersDataGrid
            // 
            usersDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            usersDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            usersDataGrid.Location = new Point(14, 115);
            usersDataGrid.Name = "usersDataGrid";
            usersDataGrid.ReadOnly = true;
            usersDataGrid.RowTemplate.Height = 25;
            usersDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            usersDataGrid.Size = new Size(774, 323);
            usersDataGrid.TabIndex = 8;
            usersDataGrid.CellDoubleClick += usersDataGrid_CellDoubleClick;
            // 
            // refresh
            // 
            refresh.Location = new Point(713, 444);
            refresh.Name = "refresh";
            refresh.Size = new Size(75, 23);
            refresh.TabIndex = 9;
            refresh.Text = "Обновить";
            refresh.UseVisualStyleBackColor = true;
            refresh.Click += refresh_Click;
            // 
            // createUser
            // 
            createUser.Location = new Point(14, 444);
            createUser.Name = "createUser";
            createUser.Size = new Size(75, 23);
            createUser.TabIndex = 16;
            createUser.Text = "Создать";
            createUser.UseVisualStyleBackColor = true;
            createUser.Click += createUser_Click;
            // 
            // UsersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 478);
            Controls.Add(createUser);
            Controls.Add(refresh);
            Controls.Add(usersDataGrid);
            Controls.Add(search);
            Controls.Add(isNotActive);
            Controls.Add(isActive);
            Controls.Add(nameTextBox);
            Controls.Add(label1);
            Name = "UsersForm";
            Text = "Перечень пользователей";
            Load += UsersForm_Load;
            ((System.ComponentModel.ISupportInitialize)usersDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private CheckBox checkBox1;
        private Button search;
        public TextBox nameTextBox;
        public CheckBox isActive;
        public CheckBox isNotActive;
        public DataGridView usersDataGrid;
        private Button refresh;
        private Button createUser;
    }
}