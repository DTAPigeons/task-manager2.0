using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManager.Forms
{
    public partial class ProjectLogDetailsForm : Form
    {
        public ProjectLogDetailsForm(ProjectLog projectLog)
        {
            InitializeComponent();
            UserName.Text = projectLog.User.Username;
            ProjectName.Text = projectLog.Project.Name;
            StartDate.Text = projectLog.StartDate.ToString();
            EndDate.Text = projectLog.EndDate.ToString();
            Description.Text = projectLog.Description;
            Description.ReadOnly = true;
            int x = screenshotPanel.Location.X + 10;
            int y = screenshotPanel.Location.Y + 10;
            foreach (var item in projectLog.Screenshots) {

            }
        }

        private void UserName_Click(object sender, EventArgs e) {

        }
    }
}
