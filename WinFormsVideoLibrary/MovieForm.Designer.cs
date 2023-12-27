namespace WinFormsVideoLibrary
{
    partial class MovieForm
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
            button1 = new Button();
            descriptionTextBox = new RichTextBox();
            label4 = new Label();
            producerTextBox = new TextBox();
            label3 = new Label();
            genreTextBox = new TextBox();
            label2 = new Label();
            nameTextBox = new TextBox();
            label1 = new Label();
            deleteButton = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(394, 364);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 18;
            button1.Text = "Сохранить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(146, 146);
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(323, 190);
            descriptionTextBox.TabIndex = 17;
            descriptionTextBox.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 146);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 16;
            label4.Text = "Описание";
            // 
            // producerTextBox
            // 
            producerTextBox.Location = new Point(146, 102);
            producerTextBox.Name = "producerTextBox";
            producerTextBox.Size = new Size(323, 23);
            producerTextBox.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 105);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 14;
            label3.Text = "Режиссер";
            // 
            // genreTextBox
            // 
            genreTextBox.Location = new Point(146, 60);
            genreTextBox.Name = "genreTextBox";
            genreTextBox.Size = new Size(323, 23);
            genreTextBox.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 63);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 12;
            label2.Text = "Жанр";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(146, 19);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(323, 23);
            nameTextBox.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 10;
            label1.Text = "Название";
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(313, 364);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(75, 23);
            deleteButton.TabIndex = 19;
            deleteButton.Text = "Удалить";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Visible = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // MovieForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(487, 403);
            Controls.Add(deleteButton);
            Controls.Add(button1);
            Controls.Add(descriptionTextBox);
            Controls.Add(label4);
            Controls.Add(producerTextBox);
            Controls.Add(label3);
            Controls.Add(genreTextBox);
            Controls.Add(label2);
            Controls.Add(nameTextBox);
            Controls.Add(label1);
            Name = "MovieForm";
            Text = "MovieForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        public RichTextBox descriptionTextBox;
        private Label label4;
        public TextBox producerTextBox;
        private Label label3;
        public TextBox genreTextBox;
        private Label label2;
        public TextBox nameTextBox;
        private Label label1;
        private Button deleteButton;
    }
}