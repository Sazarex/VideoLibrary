namespace WinFormsVideoLibrary
{
    partial class ProducerForm
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
            deleteButton = new Button();
            button1 = new Button();
            nameTextBox = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(203, 76);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(75, 23);
            deleteButton.TabIndex = 40;
            deleteButton.Text = "Удалить";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Visible = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // button1
            // 
            button1.Location = new Point(284, 76);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 39;
            button1.Text = "Сохранить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(88, 6);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(271, 23);
            nameTextBox.TabIndex = 37;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 36;
            label1.Text = "Ф.И.О.";
            // 
            // ProducerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(386, 126);
            Controls.Add(deleteButton);
            Controls.Add(button1);
            Controls.Add(nameTextBox);
            Controls.Add(label1);
            Name = "ProducerForm";
            Text = "Редактирование\\добавление режиссера";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button deleteButton;
        private Button button1;
        public TextBox nameTextBox;
        private Label label1;
    }
}