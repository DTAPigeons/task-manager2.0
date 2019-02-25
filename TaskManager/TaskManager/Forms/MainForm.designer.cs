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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TasksComboBox = new System.Windows.Forms.ComboBox();
            this.CompanyAddbutton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ReportstoolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(503, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // ReportstoolStripButton
            // 
            this.ReportstoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ReportstoolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("ReportstoolStripButton.Image")));
            this.ReportstoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ReportstoolStripButton.Name = "ReportstoolStripButton";
            this.ReportstoolStripButton.Size = new System.Drawing.Size(50, 22);
            this.ReportstoolStripButton.Text = "Отчети";
            this.ReportstoolStripButton.Click += new System.EventHandler(this.ReportstoolStripButton_Click);
            // 
            // CompaniesComboBox
            // 
            this.CompaniesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CompaniesComboBox.FormattingEnabled = true;
            this.CompaniesComboBox.Location = new System.Drawing.Point(77, 13);
            this.CompaniesComboBox.Name = "CompaniesComboBox";
            this.CompaniesComboBox.Size = new System.Drawing.Size(287, 21);
            this.CompaniesComboBox.TabIndex = 1;
            // 
            // CompanyLabel
            // 
            this.CompanyLabel.AutoSize = true;
            this.CompanyLabel.Location = new System.Drawing.Point(15, 16);
            this.CompanyLabel.Name = "CompanyLabel";
            this.CompanyLabel.Size = new System.Drawing.Size(44, 13);
            this.CompanyLabel.TabIndex = 2;
            this.CompanyLabel.Text = "Фирма";
            // 
            // TaskLabel
            // 
            this.TaskLabel.AutoSize = true;
            this.TaskLabel.Location = new System.Drawing.Point(15, 46);
            this.TaskLabel.Name = "TaskLabel";
            this.TaskLabel.Size = new System.Drawing.Size(44, 13);
            this.TaskLabel.TabIndex = 3;
            this.TaskLabel.Text = "Проект";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.StopButton);
            this.panel1.Controls.Add(this.PauseButton);
            this.panel1.Controls.Add(this.StartButton);
            this.panel1.Controls.Add(this.TIMER);
            this.panel1.Controls.Add(this.TimeLabel);
            this.panel1.Controls.Add(this.DescriptionLabel);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.TasksComboBox);
            this.panel1.Controls.Add(this.CompanyAddbutton);
            this.panel1.Controls.Add(this.TaskLabel);
            this.panel1.Controls.Add(this.CompanyLabel);
            this.panel1.Controls.Add(this.CompaniesComboBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(503, 515);
            this.panel1.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameColumn,
            this.TimeColumn,
            this.StatusColumn});
            this.dataGridView1.Location = new System.Drawing.Point(0, 260);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(503, 255);
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
            this.StopButton.Location = new System.Drawing.Point(400, 169);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(75, 23);
            this.StopButton.TabIndex = 12;
            this.StopButton.Text = "Стоп";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // PauseButton
            // 
            this.PauseButton.Enabled = false;
            this.PauseButton.Location = new System.Drawing.Point(400, 130);
            this.PauseButton.Name = "PauseButton";
            this.PauseButton.Size = new System.Drawing.Size(75, 23);
            this.PauseButton.TabIndex = 11;
            this.PauseButton.Text = "Пауза";
            this.PauseButton.UseVisualStyleBackColor = true;
            this.PauseButton.Click += new System.EventHandler(this.PauseButton_Click);
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(400, 92);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 10;
            this.StartButton.Text = "Старт";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // TIMER
            // 
            this.TIMER.AutoSize = true;
            this.TIMER.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TIMER.Location = new System.Drawing.Point(78, 224);
            this.TIMER.Name = "TIMER";
            this.TIMER.Size = new System.Drawing.Size(127, 33);
            this.TIMER.TabIndex = 9;
            this.TIMER.Text = "00:00:00";
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Location = new System.Drawing.Point(32, 231);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(40, 13);
            this.TimeLabel.TabIndex = 8;
            this.TimeLabel.Text = "Време";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(12, 82);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(60, 13);
            this.DescriptionLabel.TabIndex = 7;
            this.DescriptionLabel.Text = "Описание:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(77, 79);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(287, 136);
            this.textBox1.TabIndex = 6;
            // 
            // TasksComboBox
            // 
            this.TasksComboBox.FormattingEnabled = true;
            this.TasksComboBox.Location = new System.Drawing.Point(77, 43);
            this.TasksComboBox.Name = "TasksComboBox";
            this.TasksComboBox.Size = new System.Drawing.Size(287, 21);
            this.TasksComboBox.TabIndex = 5;
            // 
            // CompanyAddbutton
            // 
            this.CompanyAddbutton.Location = new System.Drawing.Point(380, 11);
            this.CompanyAddbutton.Name = "CompanyAddbutton";
            this.CompanyAddbutton.Size = new System.Drawing.Size(121, 23);
            this.CompanyAddbutton.TabIndex = 4;
            this.CompanyAddbutton.Text = "Добавяне на фирма";
            this.CompanyAddbutton.UseVisualStyleBackColor = true;
            this.CompanyAddbutton.Click += new System.EventHandler(this.CompanyAddbutton_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.TimerTick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 540);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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
        private System.Windows.Forms.ComboBox TasksComboBox;
        private System.Windows.Forms.TextBox textBox1;
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
    }
}