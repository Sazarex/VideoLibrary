namespace WinFormsVideoLibrary
{
    partial class SubscriptionControlForm
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
            userTextBox = new TextBox();
            validUserButton = new Button();
            isValidUser = new Label();
            createMonthlySubscription = new Button();
            label2 = new Label();
            startDateTimePicker = new DateTimePicker();
            createSubscription = new Button();
            monthCounter = new NumericUpDown();
            label3 = new Label();
            groupBox1 = new GroupBox();
            label5 = new Label();
            subscriptionStartDateLabel = new Label();
            label7 = new Label();
            subscriptionEndDateLabel = new Label();
            label9 = new Label();
            subscriptionState = new Label();
            cancelSubscription = new Button();
            ((System.ComponentModel.ISupportInitialize)monthCounter).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 35);
            label1.Name = "label1";
            label1.Size = new Size(121, 15);
            label1.TabIndex = 0;
            label1.Text = "Ф.И.О. пользователя";
            // 
            // userTextBox
            // 
            userTextBox.Location = new Point(191, 32);
            userTextBox.Name = "userTextBox";
            userTextBox.Size = new Size(272, 23);
            userTextBox.TabIndex = 1;
            // 
            // validUserButton
            // 
            validUserButton.Location = new Point(479, 32);
            validUserButton.Name = "validUserButton";
            validUserButton.Size = new Size(137, 23);
            validUserButton.TabIndex = 2;
            validUserButton.Text = "Выбрать пользователя";
            validUserButton.UseVisualStyleBackColor = true;
            validUserButton.Click += validUserButton_Click;
            // 
            // isValidUser
            // 
            isValidUser.AutoSize = true;
            isValidUser.Location = new Point(197, 9);
            isValidUser.Name = "isValidUser";
            isValidUser.Size = new Size(0, 15);
            isValidUser.TabIndex = 3;
            // 
            // createMonthlySubscription
            // 
            createMonthlySubscription.Enabled = false;
            createMonthlySubscription.Location = new Point(479, 162);
            createMonthlySubscription.Name = "createMonthlySubscription";
            createMonthlySubscription.Size = new Size(137, 57);
            createMonthlySubscription.TabIndex = 4;
            createMonthlySubscription.Text = "Оформить месячную подписку с сегодняшнего дня";
            createMonthlySubscription.UseVisualStyleBackColor = true;
            createMonthlySubscription.Click += createMonthlySubscription_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 28);
            label2.Name = "label2";
            label2.Size = new Size(130, 15);
            label2.TabIndex = 5;
            label2.Text = "Дата начала подписки";
            // 
            // startDateTimePicker
            // 
            startDateTimePicker.Enabled = false;
            startDateTimePicker.Location = new Point(191, 83);
            startDateTimePicker.Name = "startDateTimePicker";
            startDateTimePicker.Size = new Size(272, 23);
            startDateTimePicker.TabIndex = 6;
            // 
            // createSubscription
            // 
            createSubscription.Enabled = false;
            createSubscription.Location = new Point(479, 85);
            createSubscription.Name = "createSubscription";
            createSubscription.Size = new Size(137, 54);
            createSubscription.TabIndex = 7;
            createSubscription.Text = "Оформить подписку";
            createSubscription.UseVisualStyleBackColor = true;
            createSubscription.Click += createSubscription_Click;
            // 
            // monthCounter
            // 
            monthCounter.Enabled = false;
            monthCounter.Location = new Point(178, 61);
            monthCounter.Name = "monthCounter";
            monthCounter.Size = new Size(80, 23);
            monthCounter.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 63);
            label3.Name = "label3";
            label3.Size = new Size(151, 15);
            label3.TabIndex = 9;
            label3.Text = "Кол-во месяцев подписки";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(monthCounter);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(13, 61);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(617, 172);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Подписка";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 286);
            label5.Name = "label5";
            label5.Size = new Size(133, 15);
            label5.TabIndex = 12;
            label5.Text = "Дата начала подписки:";
            // 
            // subscriptionStartDateLabel
            // 
            subscriptionStartDateLabel.AutoSize = true;
            subscriptionStartDateLabel.Location = new Point(175, 286);
            subscriptionStartDateLabel.Name = "subscriptionStartDateLabel";
            subscriptionStartDateLabel.Size = new Size(38, 15);
            subscriptionStartDateLabel.TabIndex = 13;
            subscriptionStartDateLabel.Text = "label6";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(29, 327);
            label7.Name = "label7";
            label7.Size = new Size(127, 15);
            label7.TabIndex = 14;
            label7.Text = "Дата конца подписки:";
            // 
            // subscriptionEndDateLabel
            // 
            subscriptionEndDateLabel.AutoSize = true;
            subscriptionEndDateLabel.Location = new Point(175, 327);
            subscriptionEndDateLabel.Name = "subscriptionEndDateLabel";
            subscriptionEndDateLabel.Size = new Size(38, 15);
            subscriptionEndDateLabel.TabIndex = 15;
            subscriptionEndDateLabel.Text = "label8";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(30, 259);
            label9.Name = "label9";
            label9.Size = new Size(122, 15);
            label9.TabIndex = 16;
            label9.Text = "Состояние подписки";
            // 
            // subscriptionState
            // 
            subscriptionState.AutoSize = true;
            subscriptionState.Location = new Point(207, 259);
            subscriptionState.Name = "subscriptionState";
            subscriptionState.Size = new Size(122, 15);
            subscriptionState.TabIndex = 17;
            subscriptionState.Text = "Состояние подписки";
            // 
            // cancelSubscription
            // 
            cancelSubscription.BackColor = Color.FromArgb(255, 192, 192);
            cancelSubscription.Enabled = false;
            cancelSubscription.ForeColor = Color.Black;
            cancelSubscription.Location = new Point(30, 356);
            cancelSubscription.Name = "cancelSubscription";
            cancelSubscription.Size = new Size(183, 30);
            cancelSubscription.TabIndex = 18;
            cancelSubscription.Text = "Отменить подписку";
            cancelSubscription.UseVisualStyleBackColor = false;
            cancelSubscription.Click += cancelSubscription_Click;
            // 
            // SubscriptionControlForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(639, 450);
            Controls.Add(cancelSubscription);
            Controls.Add(subscriptionState);
            Controls.Add(label9);
            Controls.Add(subscriptionEndDateLabel);
            Controls.Add(label7);
            Controls.Add(subscriptionStartDateLabel);
            Controls.Add(label5);
            Controls.Add(createSubscription);
            Controls.Add(startDateTimePicker);
            Controls.Add(createMonthlySubscription);
            Controls.Add(isValidUser);
            Controls.Add(validUserButton);
            Controls.Add(userTextBox);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "SubscriptionControlForm";
            Text = "Контроль подписок";
            ((System.ComponentModel.ISupportInitialize)monthCounter).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox userTextBox;
        private Button validUserButton;
        private Label isValidUser;
        private Button createMonthlySubscription;
        private Label label2;
        private DateTimePicker startDateTimePicker;
        private Button createSubscription;
        private NumericUpDown monthCounter;
        private Label label3;
        private GroupBox groupBox1;
        private Label label4;
        private Label label5;
        private Label subscriptionStartDateLabel;
        private Label label7;
        private Label subscriptionEndDateLabel;
        private Label label9;
        private Label subscriptionState;
        private Button cancelSubscription;
    }
}