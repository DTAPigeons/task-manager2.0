namespace TaskManager
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ReportstoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.CompaniesComboBox = new System.Windows.Forms.ComboBox();
            this.CompanyLabel = new System.Windows.Forms.Label();
            this.TaskLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StopButton = new System.Windows.Forms.Button();
            this.PauseButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.TIMER = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.CompanyAddbutton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.projectNameTextBox = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ReportstoolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(671, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // ReportstoolStripButton
            // 
            this.ReportstoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ReportstoolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("ReportstoolStripButton.Image")));
            this.ReportstoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ReportstoolStripButton.Name = "ReportstoolStripButton";
            this.ReportstoolStripButton.Size = new System.Drawing.Size(61, 24);
            this.ReportstoolStripButton.Text = "Отчети";
            this.ReportstoolStripButton.Click += new System.EventHandler(this.ReportstoolStripButton_Click);
            // 
            // CompaniesComboBox
            // 
            this.CompaniesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CompaniesComboBox.FormattingEnabled = true;
            this.CompaniesComboBox.Location = new System.Drawing.Point(103, 16);
            this.CompaniesComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CompaniesComboBox.Name = "CompaniesComboBox";
            this.CompaniesComboBox.Size = new System.Drawing.Size(381, 24);
            this.CompaniesComboBox.TabIndex = 1;
            // 
            // CompanyLabel
            // 
            this.CompanyLabel.AutoSize = true;
            this.CompanyLabel.Location = new System.Drawing.Point(20, 20);
            this.CompanyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CompanyLabel.Name = "CompanyLabel";
            this.CompanyLabel.Size = new System.Drawing.Size(54, 17);
            this.CompanyLabel.TabIndex = 2;
            this.CompanyLabel.Text = "Фирма";
            // 
            // TaskLabel
            // 
            this.TaskLabel.AutoSize = true;
            this.TaskLabel.Location = new System.Drawing.Point(20, 57);
            this.TaskLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TaskLabel.Name = "TaskLabel";
            this.TaskLabel.Size = new System.Drawing.Size(56, 17);
            this.TaskLabel.TabIndex = 3;
            this.TaskLabel.Text = "Проект";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.projectNameTextBox);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.StopButton);
            this.panel1.Controls.Add(this.PauseButton);
            this.panel1.Controls.Add(this.StartButton);
            this.panel1.Controls.Add(this.TIMER);
            this.panel1.Controls.Add(this.TimeLabel);
            this.panel1.Controls.Add(this.DescriptionLabel);
            this.panel1.Controls.Add(this.descriptionTextBox);
            this.panel1.Controls.Add(this.CompanyAddbutton);
            this.panel1.Controls.Add(this.TaskLabel);
            this.panel1.Controls.Add(this.CompanyLabel);
            this.panel1.Controls.Add(this.CompaniesComboBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(671, 638);
            this.panel1.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameColumn,
            this.TimeColumn,
            this.StatusColumn});
            this.dataGridView1.Location = new System.Drawing.Point(0, 320);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(671, 314);
            this.dataGridView1.TabIndex = 13;
            // 
            // NameColumn
            // 
            this.NameColumn.HeaderText = "Име";
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.ReadOnly = true;
            this.NameColumn.Width = 209;
            // 
            // TimeColumn
            // 
            this.TimeColumn.HeaderText = "Време";
            this.TimeColumn.Name = "TimeColumn";
            this.TimeColumn.ReadOnly = true;
            this.TimeColumn.Width = 125;
            // 
            // StatusColumn
            // 
            this.StatusColumn.HeaderText = "Статус";
            this.StatusColumn.Name = "StatusColumn";
            this.StatusColumn.ReadOnly = true;
            this.StatusColumn.Width = 125;
            // 
            // StopButton
            // 
            this.StopButton.Enabled = false;
            this.StopButton.Location = new System.Drawing.Point(533, 208);
            this.StopButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(100, 28);
            this.StopButton.TabIndex = 12;
            this.StopButton.Text = "Стоп";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // PauseButton
            // 
            this.PauseButton.Enabled = false;
            this.PauseButton.Location = new System.Drawing.Point(533, 160);
            this.PauseButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PauseButton.Name = "PauseButton";
            this.PauseButton.Size = new System.Drawing.Size(100, 28);
            this.PauseButton.TabIndex = 11;
            this.PauseButton.Text = "Пауза";
            this.PauseButton.UseVisualStyleBackColor = true;
            this.PauseButton.Click += new System.EventHandler(this.PauseButton_Click);
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(533, 113);
            this.StartButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(100, 28);
            this.StartButton.TabIndex = 10;
            this.StartButton.Text = "Старт";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // TIMER
            // 
            this.TIMER.AutoSize = true;
            this.TIMER.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TIMER.Location = new System.Drawing.Point(104, 276);
            this.TIMER.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TIMER.Name = "TIMER";
            this.TIMER.Size = new System.Drawing.Size(164, 42);
            this.TIMER.TabIndex = 9;
            this.TIMER.Text = "00:00:00";
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Location = new System.Drawing.Point(43, 284);
            this.TimeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(50, 17);
            this.TimeLabel.TabIndex = 8;
            this.TimeLabel.Text = "Време";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(16, 101);
            this.DescriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(78, 17);
            this.DescriptionLabel.TabIndex = 7;
            this.DescriptionLabel.Text = "Описание:";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(103, 97);
            this.descriptionTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(381, 166);
            this.descriptionTextBox.TabIndex = 6;
            // 
            // CompanyAddbutton
            // 
            this.CompanyAddbutton.Location = new System.Drawing.Point(507, 14);
            this.CompanyAddbutton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CompanyAddbutton.Name = "CompanyAddbutton";
            this.CompanyAddbutton.Size = new System.Drawing.Size(161, 28);
            this.CompanyAddbutton.TabIndex = 4;
            this.CompanyAddbutton.Text = "Добавяне на фирма";
            this.CompanyAddbutton.UseVisualStyleBackColor = true;
            this.CompanyAddbutton.Click += new System.EventHandler(this.CompanyAddbutton_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.TimerTick);
            // 
            // projectNameTextBox
            // 
            this.projectNameTextBox.Location = new System.Drawing.Point(103, 51);
            this.projectNameTextBox.Name = "projectNameTextBox";
            this.projectNameTextBox.Size = new System.Drawing.Size(381, 22);
            this.projectNameTextBox.TabIndex = 14;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 665);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Task Manager";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ComboBox CompaniesComboBox;
        private System.Windows.Forms.Label CompanyLabel;
        private System.Windows.Forms.Label TaskLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CompanyAddbutton;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Button PauseButton;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label TIMER;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusColumn;
        private System.Windows.Forms.ToolStripButton ReportstoolStripButton;
        private System.Windows.Forms.TextBox projectNameTextBox;
    }
}