namespace worlddomination
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.CreateCrew = new System.Windows.Forms.Button();
            this.PlayersList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PlayerName = new System.Windows.Forms.TextBox();
            this.City1Name = new System.Windows.Forms.TextBox();
            this.City2Name = new System.Windows.Forms.TextBox();
            this.City3Name = new System.Windows.Forms.TextBox();
            this.City4Name = new System.Windows.Forms.TextBox();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.StartGameButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CreateCrew
            // 
            this.CreateCrew.Location = new System.Drawing.Point(312, 263);
            this.CreateCrew.Name = "CreateCrew";
            this.CreateCrew.Size = new System.Drawing.Size(168, 23);
            this.CreateCrew.TabIndex = 0;
            this.CreateCrew.Text = "Добавить команду";
            this.CreateCrew.UseVisualStyleBackColor = true;
            this.CreateCrew.Click += new System.EventHandler(this.CreateCrew_Click);
            // 
            // PlayersList
            // 
            this.PlayersList.FormattingEnabled = true;
            this.PlayersList.ItemHeight = 16;
            this.PlayersList.Location = new System.Drawing.Point(12, 106);
            this.PlayersList.Name = "PlayersList";
            this.PlayersList.Size = new System.Drawing.Size(120, 180);
            this.PlayersList.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(330, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Регистрация игры";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(260, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Укажите название команды и 4 городов";
            // 
            // PlayerName
            // 
            this.PlayerName.Location = new System.Drawing.Point(312, 125);
            this.PlayerName.Name = "PlayerName";
            this.PlayerName.Size = new System.Drawing.Size(168, 22);
            this.PlayerName.TabIndex = 4;
            // 
            // City1Name
            // 
            this.City1Name.Location = new System.Drawing.Point(164, 194);
            this.City1Name.Name = "City1Name";
            this.City1Name.Size = new System.Drawing.Size(100, 22);
            this.City1Name.TabIndex = 5;
            // 
            // City2Name
            // 
            this.City2Name.Location = new System.Drawing.Point(312, 193);
            this.City2Name.Name = "City2Name";
            this.City2Name.Size = new System.Drawing.Size(100, 22);
            this.City2Name.TabIndex = 6;
            // 
            // City3Name
            // 
            this.City3Name.Location = new System.Drawing.Point(445, 193);
            this.City3Name.Name = "City3Name";
            this.City3Name.Size = new System.Drawing.Size(100, 22);
            this.City3Name.TabIndex = 7;
            // 
            // City4Name
            // 
            this.City4Name.Location = new System.Drawing.Point(592, 195);
            this.City4Name.Name = "City4Name";
            this.City4Name.Size = new System.Drawing.Size(100, 22);
            this.City4Name.TabIndex = 8;
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(12, 293);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(120, 23);
            this.UpdateButton.TabIndex = 9;
            this.UpdateButton.Text = "Обновить";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(312, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Название команды";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(164, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Название города";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(315, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Название города";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(445, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Название города";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(592, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Название города";
            // 
            // StartGameButton
            // 
            this.StartGameButton.Location = new System.Drawing.Point(312, 382);
            this.StartGameButton.Name = "StartGameButton";
            this.StartGameButton.Size = new System.Drawing.Size(168, 23);
            this.StartGameButton.TabIndex = 15;
            this.StartGameButton.Text = "Начать игру";
            this.StartGameButton.UseVisualStyleBackColor = true;
            this.StartGameButton.Click += new System.EventHandler(this.StartGameButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.StartGameButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.City4Name);
            this.Controls.Add(this.City3Name);
            this.Controls.Add(this.City2Name);
            this.Controls.Add(this.City1Name);
            this.Controls.Add(this.PlayerName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PlayersList);
            this.Controls.Add(this.CreateCrew);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateCrew;
        private System.Windows.Forms.ListBox PlayersList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PlayerName;
        private System.Windows.Forms.TextBox City1Name;
        private System.Windows.Forms.TextBox City2Name;
        private System.Windows.Forms.TextBox City3Name;
        private System.Windows.Forms.TextBox City4Name;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button StartGameButton;
    }
}

