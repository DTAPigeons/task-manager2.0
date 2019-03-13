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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Statuslabel = new System.Windows.Forms.Label();
            this.Namelabel = new System.Windows.Forms.Label();
            this.Companylabel = new System.Windows.Forms.Label();
            this.ProjectLogView = new System.Windows.Forms.DataGridView();
            this.ProjectLogSource = new System.Windows.Forms.BindingSource(this.components);
            this.startDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeTakenColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Details = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectLogView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectLogSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Статус:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(227, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Проект:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(548, 50);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Фирма:";
            // 
            // Statuslabel
            // 
            this.Statuslabel.AutoSize = true;
            this.Statuslabel.Location = new System.Drawing.Point(103, 50);
            this.Statuslabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Statuslabel.Name = "Statuslabel";
            this.Statuslabel.Size = new System.Drawing.Size(46, 17);
            this.Statuslabel.TabIndex = 3;
            this.Statuslabel.Text = "label4";
            // 
            // Namelabel
            // 
            this.Namelabel.AutoSize = true;
            this.Namelabel.Location = new System.Drawing.Point(297, 50);
            this.Namelabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Namelabel.Name = "Namelabel";
            this.Namelabel.Size = new System.Drawing.Size(46, 17);
            this.Namelabel.TabIndex = 4;
            this.Namelabel.Text = "label5";
            // 
            // Companylabel
            // 
            this.Companylabel.AutoSize = true;
            this.Companylabel.Location = new System.Drawing.Point(619, 50);
            this.Companylabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Companylabel.Name = "Companylabel";
            this.Companylabel.Size = new System.Drawing.Size(46, 17);
            this.Companylabel.TabIndex = 5;
            this.Companylabel.Text = "label6";
            // 
            // ProjectLogView
            // 
            this.ProjectLogView.AutoGenerateColumns = false;
            this.ProjectLogView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProjectLogView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.startDateDataGridViewTextBoxColumn,
            this.endDateDataGridViewTextBoxColumn,
            this.TimeTakenColumn,
            this.User,
            this.descriptionDataGridViewTextBoxColumn,
            this.Details});
            this.ProjectLogView.DataSource = this.ProjectLogSource;
            this.ProjectLogView.Location = new System.Drawing.Point(1, 278);
            this.ProjectLogView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ProjectLogView.Name = "ProjectLogView";
            this.ProjectLogView.Size = new System.Drawing.Size(860, 274);
            this.ProjectLogView.TabIndex = 6;
            this.ProjectLogView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ProjectLogSource
            // 
            this.ProjectLogSource.DataSource = typeof(TaskManager.ProjectLog);
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            this.startDateDataGridViewTextBoxColumn.DataPropertyName = "StartDate";
            this.startDateDataGridViewTextBoxColumn.HeaderText = "От";
            this.startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            // 
            // endDateDataGridViewTextBoxColumn
            // 
            this.endDateDataGridViewTextBoxColumn.DataPropertyName = "EndDate";
            this.endDateDataGridViewTextBoxColumn.HeaderText = "До";
            this.endDateDataGridViewTextBoxColumn.Name = "endDateDataGridViewTextBoxColumn";
            // 
            // TimeTakenColumn
            // 
            this.TimeTakenColumn.HeaderText = "Време";
            this.TimeTakenColumn.Name = "TimeTakenColumn";
            this.TimeTakenColumn.ReadOnly = true;
            // 
            // User
            // 
            this.User.DataPropertyName = "User";
            this.User.HeaderText = "Потребител";
            this.User.Name = "User";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Описание";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // Details
            // 
            this.Details.HeaderText = "Детайли";
            this.Details.Name = "Details";
            this.Details.UseColumnTextForButtonValue = true;
            // 
            // DetailsReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 554);
            this.Controls.Add(this.ProjectLogView);
            this.Controls.Add(this.Companylabel);
            this.Controls.Add(this.Namelabel);
            this.Controls.Add(this.Statuslabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DetailsReportForm";
            this.Text = "Подробен отчет за проект";
            ((System.ComponentModel.ISupportInitialize)(this.ProjectLogView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectLogSource)).EndInit();
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
        private System.Windows.Forms.DataGridView ProjectLogView;
        private System.Windows.Forms.BindingSource ProjectLogSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeTakenColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn User;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Details;
    }
}