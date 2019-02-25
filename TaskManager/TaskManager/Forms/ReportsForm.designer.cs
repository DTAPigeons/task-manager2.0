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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateStartColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateEndColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeTakenColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SearchButton = new System.Windows.Forms.Button();
            this.DetailsButton = new System.Windows.Forms.Button();
            this.FromtextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ТоtextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.UsertextBox = new System.Windows.Forms.TextBox();
            this.TasktextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameColumn,
            this.DateStartColumn,
            this.DateEndColumn,
            this.TimeTakenColumn});
            this.dataGridView1.Location = new System.Drawing.Point(-1, 140);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(447, 311);
            this.dataGridView1.TabIndex = 0;
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
            // TimeTakenColumn
            // 
            this.TimeTakenColumn.HeaderText = "Време";
            this.TimeTakenColumn.Name = "TimeTakenColumn";
            this.TimeTakenColumn.ReadOnly = true;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(359, 43);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 5;
            this.SearchButton.Text = "Търси";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // DetailsButton
            // 
            this.DetailsButton.Enabled = false;
            this.DetailsButton.Location = new System.Drawing.Point(359, 76);
            this.DetailsButton.Name = "DetailsButton";
            this.DetailsButton.Size = new System.Drawing.Size(75, 23);
            this.DetailsButton.TabIndex = 6;
            this.DetailsButton.Text = "Детайли";
            this.DetailsButton.UseVisualStyleBackColor = true;
            this.DetailsButton.Click += new System.EventHandler(this.DetailsButton_Click);
            // 
            // FromtextBox
            // 
            this.FromtextBox.Location = new System.Drawing.Point(38, 45);
            this.FromtextBox.Name = "FromtextBox";
            this.FromtextBox.Size = new System.Drawing.Size(100, 20);
            this.FromtextBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "От";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "До";
            // 
            // ТоtextBox
            // 
            this.ТоtextBox.Location = new System.Drawing.Point(38, 78);
            this.ТоtextBox.Name = "ТоtextBox";
            this.ТоtextBox.Size = new System.Drawing.Size(100, 20);
            this.ТоtextBox.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(144, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Потребител";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(167, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Проект";
            // 
            // UsertextBox
            // 
            this.UsertextBox.Location = new System.Drawing.Point(215, 45);
            this.UsertextBox.Name = "UsertextBox";
            this.UsertextBox.Size = new System.Drawing.Size(100, 20);
            this.UsertextBox.TabIndex = 13;
            // 
            // TasktextBox
            // 
            this.TasktextBox.Location = new System.Drawing.Point(215, 78);
            this.TasktextBox.Name = "TasktextBox";
            this.TasktextBox.Size = new System.Drawing.Size(100, 20);
            this.TasktextBox.TabIndex = 14;
            // 
            // ReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 450);
            this.Controls.Add(this.TasktextBox);
            this.Controls.Add(this.UsertextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ТоtextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FromtextBox);
            this.Controls.Add(this.DetailsButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ReportsForm";
            this.Text = "Отчети";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button DetailsButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateStartColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateEndColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeTakenColumn;
        private System.Windows.Forms.TextBox FromtextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ТоtextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox UsertextBox;
        private System.Windows.Forms.TextBox TasktextBox;
    }
}