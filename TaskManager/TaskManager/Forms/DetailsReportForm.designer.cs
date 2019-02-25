namespace TaskManager
{
    partial class DetailsReportForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Statuslabel = new System.Windows.Forms.Label();
            this.Namelabel = new System.Windows.Forms.Label();
            this.Companylabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.StartDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeTakenColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescriptionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScreenshotsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Статус:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Проект:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(411, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Фирма:";
            // 
            // Statuslabel
            // 
            this.Statuslabel.AutoSize = true;
            this.Statuslabel.Location = new System.Drawing.Point(77, 41);
            this.Statuslabel.Name = "Statuslabel";
            this.Statuslabel.Size = new System.Drawing.Size(35, 13);
            this.Statuslabel.TabIndex = 3;
            this.Statuslabel.Text = "label4";
            // 
            // Namelabel
            // 
            this.Namelabel.AutoSize = true;
            this.Namelabel.Location = new System.Drawing.Point(223, 41);
            this.Namelabel.Name = "Namelabel";
            this.Namelabel.Size = new System.Drawing.Size(35, 13);
            this.Namelabel.TabIndex = 4;
            this.Namelabel.Text = "label5";
            // 
            // Companylabel
            // 
            this.Companylabel.AutoSize = true;
            this.Companylabel.Location = new System.Drawing.Point(464, 41);
            this.Companylabel.Name = "Companylabel";
            this.Companylabel.Size = new System.Drawing.Size(35, 13);
            this.Companylabel.TabIndex = 5;
            this.Companylabel.Text = "label6";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StartDateColumn,
            this.EndDateColumn,
            this.TimeTakenColumn,
            this.UserColumn,
            this.DescriptionColumn,
            this.ScreenshotsColumn});
            this.dataGridView1.Location = new System.Drawing.Point(1, 226);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(645, 223);
            this.dataGridView1.TabIndex = 6;
            // 
            // StartDateColumn
            // 
            this.StartDateColumn.HeaderText = "От";
            this.StartDateColumn.Name = "StartDateColumn";
            this.StartDateColumn.ReadOnly = true;
            // 
            // EndDateColumn
            // 
            this.EndDateColumn.HeaderText = "До";
            this.EndDateColumn.Name = "EndDateColumn";
            this.EndDateColumn.ReadOnly = true;
            // 
            // TimeTakenColumn
            // 
            this.TimeTakenColumn.HeaderText = "Време";
            this.TimeTakenColumn.Name = "TimeTakenColumn";
            this.TimeTakenColumn.ReadOnly = true;
            // 
            // UserColumn
            // 
            this.UserColumn.HeaderText = "Потребител";
            this.UserColumn.Name = "UserColumn";
            this.UserColumn.ReadOnly = true;
            // 
            // DescriptionColumn
            // 
            this.DescriptionColumn.HeaderText = "Описание";
            this.DescriptionColumn.Name = "DescriptionColumn";
            this.DescriptionColumn.ReadOnly = true;
            // 
            // ScreenshotsColumn
            // 
            this.ScreenshotsColumn.HeaderText = "Снимки на екрана";
            this.ScreenshotsColumn.Name = "ScreenshotsColumn";
            this.ScreenshotsColumn.ReadOnly = true;
            // 
            // DetailsReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Companylabel);
            this.Controls.Add(this.Namelabel);
            this.Controls.Add(this.Statuslabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DetailsReportForm";
            this.Text = "Подробен отчет за проект";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Statuslabel;
        private System.Windows.Forms.Label Namelabel;
        private System.Windows.Forms.Label Companylabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeTakenColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescriptionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScreenshotsColumn;
    }
}