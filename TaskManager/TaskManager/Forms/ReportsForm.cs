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

namespace TaskManager
{
    public partial class ReportsForm : Form
    {
        private readonly DateTime DEFAULT_DATE_VALUE = new DateTime(1990, 1, 1);
        private ProjectRepository projectRepository = null;

        public ReportsForm()
        {
            InitializeComponent();
            projectRepository = new ProjectRepository();
            List<Project> projects = projectRepository.GetAll();
            PopulateProjectList(projects);

            UserRepository userRepository = new UserRepository();
            List<User> users = userRepository.GetAll();
            foreach(User user in users) {
                userComboBox.Items.Add(user);
            }

            startedBeforeDatePicker.Value = DateTime.Now;
            endedBeforeDatePicker.Value = DateTime.Now;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            DateTime? startBeforeDate = startedBeforeDatePicker.Value;
            DateTime? startAfterDate = startAfterDate = startedAfterDatePicker.Value;
            DateTime? endedBeforeDate = endedBeforeDate = endedBeforeDatePicker.Value;
            DateTime? endedAfterDate = endedAfterDate = endedAfterDatePicker.Value;
            int? userId = null;
            if (userComboBox.SelectedItem != null) userId = ((User)userComboBox.SelectedItem).UserId;
            string projectName = projectNameTextBox.Text;

            List<Project> projects = projectRepository.GetAllWithFilters(startBeforeDate, startAfterDate, endedBeforeDate, endedAfterDate, userId, projectName);

            PopulateProjectList(projects);

        }

        private void PopulateProjectList(List<Project> projects) {
            projectBindingSource.DataSource = projects;


            //projectsListView.Rows.Clear();
            //foreach (Project project in projects) {
            //    projectsListView.Rows.Add(project.Name, project.StartDate, project.EndDate, project.ProjectId);
            //}
        }

        private void ClearSearchButton_Click(object sender, EventArgs e){
            startedBeforeDatePicker.Value = DateTime.Now;
            endedBeforeDatePicker.Value = DateTime.Now;
            startedAfterDatePicker.Value = DEFAULT_DATE_VALUE;
            endedAfterDatePicker.Value = DEFAULT_DATE_VALUE;
            projectNameTextBox.Text = "";
            userComboBox.SelectedIndex = -1;
        }

        private void DetailsButtonClicked(int projectId) {
            int id = projectId;
            return;
        }

        private void FromtextBox_TextChanged(object sender, EventArgs e) {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
        e.RowIndex >= 0) {

                Project proj = projectsListView.Rows[e.RowIndex].DataBoundItem as Project;

                MessageBox.Show(proj.Name);
                //DetailsButtonClicked((int)senderGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
            }
        }
    }
}
