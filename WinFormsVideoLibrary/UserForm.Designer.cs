namespace WinFormsVideoLibrary
{
    partial class UserForm
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
            label3 = new Label();
            nameTextBox = new TextBox();
            label1 = new Label();
            subscriptionState = new Label();
            label9 = new Label();
            subscriptionEndDateLabel = new Label();
            label7 = new Label();
            subscriptionStartDateLabel = new Label();
            label5 = new Label();
            numericUpDown1 = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(207, 303);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(75, 23);
            deleteButton.TabIndex = 28;
            deleteButton.Text = "Удалить";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Visible = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // button1
            // 
            button1.Location = new Point(288, 303);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 27;
            button1.Text = "Сохранить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 56);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 23;
            label3.Text = "Возраст";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(92, 12);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(271, 23);
            nameTextBox.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 15);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 20;
            label1.Text = "Ф.И.О.";
            // 
            // subscriptionState
            // 
            subscriptionState.AutoSize = true;
            subscriptionState.Location = new Point(194, 114);
            subscriptionState.Name = "subscriptionState";
            subscriptionState.Size = new Size(122, 15);
            subscriptionState.TabIndex = 34;
            subscriptionState.Text = "Состояние подписки";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(17, 114);
            label9.Name = "label9";
            label9.Size = new Size(122, 15);
            label9.TabIndex = 33;
            label9.Text = "Состояние подписки";
            // 
            // subscriptionEndDateLabel
            // 
            subscriptionEndDateLabel.AutoSize = true;
            subscriptionEndDateLabel.Location = new Point(162, 182);
            subscriptionEndDateLabel.Name = "subscriptionEndDateLabel";
            subscriptionEndDateLabel.Size = new Size(38, 15);
            subscriptionEndDateLabel.TabIndex = 32;
            subscriptionEndDateLabel.Text = "label8";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(16, 182);
            label7.Name = "label7";
            label7.Size = new Size(127, 15);
            label7.TabIndex = 31;
            label7.Text = "Дата конца подписки:";
            // 
            // subscriptionStartDateLabel
            // 
            subscriptionStartDateLabel.AutoSize = true;
            subscriptionStartDateLabel.Location = new Point(162, 141);
            subscriptionStartDateLabel.Name = "subscriptionStartDateLabel";
            subscriptionStartDateLabel.Size = new Size(38, 15);
            subscriptionStartDateLabel.TabIndex = 30;
            subscriptionStartDateLabel.Text = "label6";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 141);
            label5.Name = "label5";
            label5.Size = new Size(133, 15);
            label5.TabIndex = 29;
            label5.Text = "Дата начала подписки:";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(92, 54);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 35;
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(380, 338);
            Controls.Add(numericUpDown1);
            Controls.Add(subscriptionState);
            Controls.Add(label9);
            Controls.Add(subscriptionEndDateLabel);
            Controls.Add(label7);
            Controls.Add(subscriptionStartDateLabel);
            Controls.Add(label5);
            Controls.Add(deleteButton);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(nameTextBox);
            Controls.Add(label1);
            Name = "UserForm";
            Text = "UserForm";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button deleteButton;
        private Button button1;
        private Label label3;
        public TextBox nameTextBox;
        private Label label1;
        private Label subscriptionState;
        private Label label9;
        private Label subscriptionEndDateLabel;
        private Label label7;
        private Label subscriptionStartDateLabel;
        private Label label5;
        private NumericUpDown numericUpDown1;
    }
}