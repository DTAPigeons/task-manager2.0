using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskManager.DataAccess;
using TaskManager.Forms;

namespace TaskManager
{
    public partial class DetailsReportForm : Form
    {
        private readonly DateTime DEFAULT_DATE_VALUE = new DateTime(1990, 1, 1);
        private ProjectLogRepository projectLogRepository = null;

        public DetailsReportForm(Project project)
        {
            InitializeComponent();
            projectLogRepository = new ProjectLogRepository();
            List<ProjectLog> projectlogs = project.ProjectLog.ToList();
            PopulateProjectLogList(projectlogs);
            if (project.IsInProgress == true)
            {
                Statuslabel.Text = "Is in progress";
            }
            else
            {
                Statuslabel.Text = "Is not in progress";
            }
            Namelabel.Text = project.Name;
            Companylabel.Text = project.Company.Name;
        }


        private void PopulateProjectLogList(List<ProjectLog> projectlogs)
        {
            ProjectLogSource.DataSource = projectlogs; 
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
        e.RowIndex >= 0)
            {
                ProjectLog projectLog = ProjectLogView.Rows[e.RowIndex].DataBoundItem as ProjectLog;
                ProjectLogDetailsForm projectLogDetailsForm = new ProjectLogDetailsForm(projectLog);
                projectLogDetailsForm.Show();
            }
        }
    }
}
