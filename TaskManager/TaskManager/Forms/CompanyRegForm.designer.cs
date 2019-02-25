namespace TaskManager
{
    partial class CompanyRegForm
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
            this.RegisterButton = new System.Windows.Forms.Button();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.WebSiteTextBox = new System.Windows.Forms.TextBox();
            this.CompanyDescTextBox = new System.Windows.Forms.TextBox();
            this.CompanyNameTextBox = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.LastnameLabel = new System.Windows.Forms.Label();
            this.FirstnameLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.RegisterLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RegisterButton
            // 
            this.RegisterButton.Location = new System.Drawing.Point(125, 224);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(82, 23);
            this.RegisterButton.TabIndex = 31;
            this.RegisterButton.Text = "Регистрация";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(107, 187);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(187, 20);
            this.EmailTextBox.TabIndex = 30;
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Location = new System.Drawing.Point(107, 164);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(187, 20);
            this.AddressTextBox.TabIndex = 28;
            // 
            // WebSiteTextBox
            // 
            this.WebSiteTextBox.Location = new System.Drawing.Point(107, 138);
            this.WebSiteTextBox.Name = "WebSiteTextBox";
            this.WebSiteTextBox.Size = new System.Drawing.Size(187, 20);
            this.WebSiteTextBox.TabIndex = 27;
            // 
            // CompanyDescTextBox
            // 
            this.CompanyDescTextBox.Location = new System.Drawing.Point(107, 76);
            this.CompanyDescTextBox.Multiline = true;
            this.CompanyDescTextBox.Name = "CompanyDescTextBox";
            this.CompanyDescTextBox.Size = new System.Drawing.Size(187, 56);
            this.CompanyDescTextBox.TabIndex = 26;
            // 
            // CompanyNameTextBox
            // 
            this.CompanyNameTextBox.Location = new System.Drawing.Point(107, 49);
            this.CompanyNameTextBox.Name = "CompanyNameTextBox";
            this.CompanyNameTextBox.Size = new System.Drawing.Size(187, 20);
            this.CompanyNameTextBox.TabIndex = 25;
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(41, 190);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(36, 13);
            this.EmailLabel.TabIndex = 24;
            this.EmailLabel.Text = "E-Mail";
            // 
            // LastnameLabel
            // 
            this.LastnameLabel.AutoSize = true;
            this.LastnameLabel.Location = new System.Drawing.Point(41, 167);
            this.LastnameLabel.Name = "LastnameLabel";
            this.LastnameLabel.Size = new System.Drawing.Size(41, 13);
            this.LastnameLabel.TabIndex = 22;
            this.LastnameLabel.Text = "Адрес:";
            // 
            // FirstnameLabel
            // 
            this.FirstnameLabel.AutoSize = true;
            this.FirstnameLabel.Location = new System.Drawing.Point(41, 141);
            this.FirstnameLabel.Name = "FirstnameLabel";
            this.FirstnameLabel.Size = new System.Drawing.Size(57, 13);
            this.FirstnameLabel.TabIndex = 21;
            this.FirstnameLabel.Text = "Уеб Сайт:";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(41, 79);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(60, 13);
            this.PasswordLabel.TabIndex = 20;
            this.PasswordLabel.Text = "Описание:";
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Location = new System.Drawing.Point(41, 52);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(32, 13);
            this.UsernameLabel.TabIndex = 19;
            this.UsernameLabel.Text = "Име:";
            // 
            // RegisterLabel
            // 
            this.RegisterLabel.AutoSize = true;
            this.RegisterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterLabel.Location = new System.Drawing.Point(46, 9);
            this.RegisterLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RegisterLabel.Name = "RegisterLabel";
            this.RegisterLabel.Size = new System.Drawing.Size(248, 26);
            this.RegisterLabel.TabIndex = 18;
            this.RegisterLabel.Text = "Регистрация на Фирма";
            // 
            // CompanyRegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 284);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.AddressTextBox);
            this.Controls.Add(this.WebSiteTextBox);
            this.Controls.Add(this.CompanyDescTextBox);
            this.Controls.Add(this.CompanyNameTextBox);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.LastnameLabel);
            this.Controls.Add(this.FirstnameLabel);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.RegisterLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CompanyRegForm";
            this.Text = "Регистрация на фирма в Task Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.TextBox WebSiteTextBox;
        private System.Windows.Forms.TextBox CompanyDescTextBox;
        private System.Windows.Forms.TextBox CompanyNameTextBox;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label LastnameLabel;
        private System.Windows.Forms.Label FirstnameLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label RegisterLabel;
    }
}