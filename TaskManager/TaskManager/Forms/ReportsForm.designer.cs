namespace TaskManager
{
    partial class ReportsForm
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
            this.projectsListView = new System.Windows.Forms.DataGridView();
            this.searchButton = new System.Windows.Forms.Button();
            this.clearSearchButton = new System.Windows.Forms.Button();
            this.startedBeforeLable = new System.Windows.Forms.Label();
            this.endedBeforeLable = new System.Windows.Forms.Label();
            this.userLable = new System.Windows.Forms.Label();
            this.projectNameLable = new System.Windows.Forms.Label();
            this.projectNameTextBox = new System.Windows.Forms.TextBox();
            this.startedAfterLable = new System.Windows.Forms.Label();
            this.endedAfterLable = new System.Windows.Forms.Label();
            this.startedBeforeDatePicker = new System.Windows.Forms.DateTimePicker();
            this.startedAfterDatePicker = new System.Windows.Forms.DateTimePicker();
            this.endedBeforeDatePicker = new System.Windows.Forms.DateTimePicker();
            this.endedAfterDatePicker = new System.Windows.Forms.DateTimePicker();
            this.userComboBox = new System.Windows.Forms.ComboBox();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateStartColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateEndColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectDetailsButton = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.projectsListView)).BeginInit();
            this.SuspendLayout();
            // 
            // projectsListView
            // 
            this.projectsListView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.projectsListView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameColumn,
            this.DateStartColumn,
            this.DateEndColumn,
            this.projectDetailsButton});
            this.projectsListView.Location = new System.Drawing.Point(-1, 176);
            this.projectsListView.Margin = new System.Windows.Forms.Padding(4);
            this.projectsListView.Name = "projectsListView";
            this.projectsListView.Size = new System.Drawing.Size(718, 383);
            this.projectsListView.TabIndex = 0;
            this.projectsListView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(617, 43);
            this.searchButton.Margin = new System.Windows.Forms.Padding(4);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(100, 28);
            this.searchButton.TabIndex = 5;
            this.searchButton.Text = "Търси";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // clearSearchButton
            // 
            this.clearSearchButton.Location = new System.Drawing.Point(617, 92);
            this.clearSearchButton.Margin = new System.Windows.Forms.Padding(4);
            this.clearSearchButton.Name = "clearSearchButton";
            this.clearSearchButton.Size = new System.Drawing.Size(100, 28);
            this.clearSearchButton.TabIndex = 6;
            this.clearSearchButton.Text = "Clear Search";
            this.clearSearchButton.UseVisualStyleBackColor = true;
            this.clearSearchButton.Click += new System.EventHandler(this.ClearSearchButton_Click);
            // 
            // startedBeforeLable
            // 
            this.startedBeforeLable.AutoSize = true;
            this.startedBeforeLable.Location = new System.Drawing.Point(17, 27);
            this.startedBeforeLable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.startedBeforeLable.Name = "startedBeforeLable";
            this.startedBeforeLable.Size = new System.Drawing.Size(118, 17);
            this.startedBeforeLable.TabIndex = 8;
            this.startedBeforeLable.Text = "Започнат Преди";
            // 
            // endedBeforeLable
            // 
            this.endedBeforeLable.AutoSize = true;
            this.endedBeforeLable.Location = new System.Drawing.Point(17, 77);
            this.endedBeforeLable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.endedBeforeLable.Name = "endedBeforeLable";
            this.endedBeforeLable.Size = new System.Drawing.Size(114, 17);
            this.endedBeforeLable.TabIndex = 9;
            this.endedBeforeLable.Text = "Завъшил Преди";
            // 
            // userLable
            // 
            this.userLable.AutoSize = true;
            this.userLable.Location = new System.Drawing.Point(293, 128);
            this.userLable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userLable.Name = "userLable";
            this.userLable.Size = new System.Drawing.Size(88, 17);
            this.userLable.TabIndex = 11;
            this.userLable.Text = "Потребител";
            // 
            // projectNameLable
            // 
            this.projectNameLable.AutoSize = true;
            this.projectNameLable.Location = new System.Drawing.Point(17, 128);
            this.projectNameLable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.projectNameLable.Name = "projectNameLable";
            this.projectNameLable.Size = new System.Drawing.Size(56, 17);
            this.projectNameLable.TabIndex = 12;
            this.projectNameLable.Text = "Проект";
            // 
            // projectNameTextBox
            // 
            this.projectNameTextBox.Location = new System.Drawing.Point(143, 125);
            this.projectNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.projectNameTextBox.Name = "projectNameTextBox";
            this.projectNameTextBox.Size = new System.Drawing.Size(132, 22);
            this.projectNameTextBox.TabIndex = 14;
            // 
            // startedAfterLable
            // 
            this.startedAfterLable.AutoSize = true;
            this.startedAfterLable.Location = new System.Drawing.Point(293, 27);
            this.startedAfterLable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.startedAfterLable.Name = "startedAfterLable";
            this.startedAfterLable.Size = new System.Drawing.Size(109, 17);
            this.startedAfterLable.TabIndex = 16;
            this.startedAfterLable.Text = "Започнат След";
            // 
            // endedAfterLable
            // 
            this.endedAfterLable.AutoSize = true;
            this.endedAfterLable.Location = new System.Drawing.Point(293, 80);
            this.endedAfterLable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.endedAfterLable.Name = "endedAfterLable";
            this.endedAfterLable.Size = new System.Drawing.Size(105, 17);
            this.endedAfterLable.TabIndex = 17;
            this.endedAfterLable.Text = "Завъшил След";
            // 
            // startedBeforeDatePicker
            // 
            this.startedBeforeDatePicker.CustomFormat = "";
            this.startedBeforeDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startedBeforeDatePicker.Location = new System.Drawing.Point(143, 27);
            this.startedBeforeDatePicker.Name = "startedBeforeDatePicker";
            this.startedBeforeDatePicker.Size = new System.Drawing.Size(132, 22);
            this.startedBeforeDatePicker.TabIndex = 19;
            this.startedBeforeDatePicker.Value = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            // 
            // startedAfterDatePicker
            // 
            this.startedAfterDatePicker.CustomFormat = "";
            this.startedAfterDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startedAfterDatePicker.Location = new System.Drawing.Point(419, 27);
            this.startedAfterDatePicker.Name = "startedAfterDatePicker";
            this.startedAfterDatePicker.Size = new System.Drawing.Size(132, 22);
            this.startedAfterDatePicker.TabIndex = 20;
            this.startedAfterDatePicker.Value = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            // 
            // endedBeforeDatePicker
            // 
            this.endedBeforeDatePicker.CustomFormat = "";
            this.endedBeforeDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.endedBeforeDatePicker.Location = new System.Drawing.Point(143, 77);
            this.endedBeforeDatePicker.Name = "endedBeforeDatePicker";
            this.endedBeforeDatePicker.Size = new System.Drawing.Size(132, 22);
            this.endedBeforeDatePicker.TabIndex = 21;
            this.endedBeforeDatePicker.Value = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            // 
            // endedAfterDatePicker
            // 
            this.endedAfterDatePicker.CustomFormat = "";
            this.endedAfterDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.endedAfterDatePicker.Location = new System.Drawing.Point(419, 80);
            this.endedAfterDatePicker.Name = "endedAfterDatePicker";
            this.endedAfterDatePicker.Size = new System.Drawing.Size(132, 22);
            this.endedAfterDatePicker.TabIndex = 22;
            this.endedAfterDatePicker.Value = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            // 
            // userComboBox
            // 
            this.userComboBox.FormattingEnabled = true;
            this.userComboBox.Location = new System.Drawing.Point(419, 125);
            this.userComboBox.Name = "userComboBox";
            this.userComboBox.Size = new System.Drawing.Size(132, 24);
            this.userComboBox.TabIndex = 23;
            // 
            // NameColumn
            // 
            this.NameColumn.HeaderText = "Име";
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.ReadOnly = true;
            // 
            // DateStartColumn
            // 
            this.DateStartColumn.HeaderText = "От";
            this.DateStartColumn.Name = "DateStartColumn";
            this.DateStartColumn.ReadOnly = true;
            // 
            // DateEndColumn
            // 
            this.DateEndColumn.HeaderText = "До";
            this.DateEndColumn.Name = "DateEndColumn";
            this.DateEndColumn.ReadOnly = true;
            // 
            // projectDetailsButton
            // 
            this.projectDetailsButton.HeaderText = "Детайли";
            this.projectDetailsButton.Name = "projectDetailsButton";
            this.projectDetailsButton.Text = "Детайли";
            // 
            // ReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 554);
            this.Controls.Add(this.userComboBox);
            this.Controls.Add(this.endedAfterDatePicker);
            this.Controls.Add(this.endedBeforeDatePicker);
            this.Controls.Add(this.startedAfterDatePicker);
            this.Controls.Add(this.startedBeforeDatePicker);
            this.Controls.Add(this.endedAfterLable);
            this.Controls.Add(this.startedAfterLable);
            this.Controls.Add(this.projectNameTextBox);
            this.Controls.Add(this.projectNameLable);
            this.Controls.Add(this.userLable);
            this.Controls.Add(this.endedBeforeLable);
            this.Controls.Add(this.startedBeforeLable);
            this.Controls.Add(this.clearSearchButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.projectsListView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "ReportsForm";
            this.Text = "Отчети";
            ((System.ComponentModel.ISupportInitialize)(this.projectsListView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView projectsListView;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button clearSearchButton;
        private System.Windows.Forms.Label startedBeforeLable;
        private System.Windows.Forms.Label endedBeforeLable;
        private System.Windows.Forms.Label userLable;
        private System.Windows.Forms.Label projectNameLable;
        private System.Windows.Forms.TextBox projectNameTextBox;
        private System.Windows.Forms.Label startedAfterLable;
        private System.Windows.Forms.Label endedAfterLable;
        private System.Windows.Forms.DateTimePicker startedBeforeDatePicker;
        private System.Windows.Forms.DateTimePicker startedAfterDatePicker;
        private System.Windows.Forms.DateTimePicker endedBeforeDatePicker;
        private System.Windows.Forms.DateTimePicker endedAfterDatePicker;
        private System.Windows.Forms.ComboBox userComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateStartColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateEndColumn;
        private System.Windows.Forms.DataGridViewButtonColumn projectDetailsButton;
    }
}