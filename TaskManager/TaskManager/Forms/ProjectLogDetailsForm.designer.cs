namespace TaskManager.Forms
{
    partial class ProjectLogDetailsForm
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
            this.UserName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ProjectName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.StartDate = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.EndDate = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.screenshotPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Потребител:";
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Location = new System.Drawing.Point(113, 70);
            this.UserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(46, 17);
            this.UserName.TabIndex = 1;
            this.UserName.Text = "label2";
            this.UserName.Click += new System.EventHandler(this.UserName_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(223, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Проект:";
            // 
            // ProjectName
            // 
            this.ProjectName.AutoSize = true;
            this.ProjectName.Location = new System.Drawing.Point(291, 70);
            this.ProjectName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ProjectName.Name = "ProjectName";
            this.ProjectName.Size = new System.Drawing.Size(46, 17);
            this.ProjectName.TabIndex = 3;
            this.ProjectName.Text = "label3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(378, 70);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Започнат:";
            // 
            // StartDate
            // 
            this.StartDate.AutoSize = true;
            this.StartDate.Location = new System.Drawing.Point(462, 70);
            this.StartDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StartDate.Name = "StartDate";
            this.StartDate.Size = new System.Drawing.Size(46, 17);
            this.StartDate.TabIndex = 5;
            this.StartDate.Text = "label4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(541, 70);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Завършен:";
            // 
            // EndDate
            // 
            this.EndDate.AutoSize = true;
            this.EndDate.Location = new System.Drawing.Point(629, 70);
            this.EndDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EndDate.Name = "EndDate";
            this.EndDate.Size = new System.Drawing.Size(46, 17);
            this.EndDate.TabIndex = 7;
            this.EndDate.Text = "label5";
            // 
            // Description
            // 
            this.Description.Location = new System.Drawing.Point(116, 113);
            this.Description.Margin = new System.Windows.Forms.Padding(4);
            this.Description.Multiline = true;
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(559, 61);
            this.Description.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 113);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Описание:";
            // 
            // screenshotPanel
            // 
            this.screenshotPanel.Location = new System.Drawing.Point(9, 192);
            this.screenshotPanel.Name = "screenshotPanel";
            this.screenshotPanel.Size = new System.Drawing.Size(706, 350);
            this.screenshotPanel.TabIndex = 11;
            // 
            // ProjectLogDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 554);
            this.Controls.Add(this.screenshotPanel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.EndDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.StartDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ProjectName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ProjectLogDetailsForm";
            this.Text = "ProjectLogDetailsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ProjectName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label StartDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label EndDate;
        private System.Windows.Forms.TextBox Description;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel screenshotPanel;
    }
}