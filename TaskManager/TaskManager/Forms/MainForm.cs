using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using TaskManager.DataAccess;

namespace TaskManager
{
    public partial class MainForm : Form
    {
        TimeSpan ElapsedTime;
        DateTime LastTimeElapsed;
        DateTime LastTimeStarted;
        CompanyRepository companyRepository;
        ProjectLogRepository projectLogRepository;
        ProjectRepository projectRepository;
        MainFormState state;
        Project currentProject;
        int loggedInUserId;


        public MainForm(int loggedInUserId = 1)
        {
            this.loggedInUserId = loggedInUserId;
            companyRepository = new CompanyRepository();
            projectLogRepository = new ProjectLogRepository();
            projectRepository = new ProjectRepository();
            InitializeComponent();
            foreach(Company company in companyRepository.GetAll()) {
                CompaniesComboBox.Items.Add(company);
            }
            EnterAddingNewProjectState();
        }

        //Отваря формата за отчети
        private void ReportstoolStripButton_Click(object sender, EventArgs e)
        {
            //Отваря формата за отчети

            ReportsForm RepForm = new ReportsForm();
            RepForm.Show();
        }

            //Отваря формата за регистрация на фирма
            private void CompanyAddbutton_Click(object sender, EventArgs e)
        {
            CompanyRegForm CompRegForm = new CompanyRegForm();
            CompRegForm.Show();
        }

        //TIMER
        public void TimerTick(object sender, EventArgs e)
        {
            ElapsedTime += DateTime.Now - LastTimeElapsed;
            LastTimeElapsed = DateTime.Now;

            TIMER.Text = Convert.ToString(new TimeSpan(ElapsedTime.Hours, ElapsedTime.Minutes, ElapsedTime.Seconds));
        }

        /*
        - В кода се отбелязва че проекта е стартиран
        - В кода се запазва времето на стартиране
        */
        private void StartButton_Click(object sender, EventArgs e)
        {
            if (state == MainFormState.CreatingProjectState) {
                if (!ValidInputFields()) {
                    MessageBox.Show("Invalid Input!");
                    return;
                }
                AddNewProject();
                EnterWorkingOnProjectState(descriptionTextBox.Text);
            }
            if(state == MainFormState.ProjectPausedState) {
                EnterWorkingOnProjectState();
            }
            else {
                throw new Exception("Start button shouldn't be active!");
            }

            SetEnabledForProjectButtons(false, true, true);
            LastTimeElapsed = DateTime.Now;
        }

        private bool ValidInputFields() {
            if (CompaniesComboBox.SelectedIndex < 0) {
                return false;
            }
            if(projectNameTextBox.Text == null || projectNameTextBox.Text == "") {
                return false;
            }
            return true;
        }

        private void AddNewProject() {
            Project project = new Project();
            project.Name = projectNameTextBox.Text;
            project.CompanyId = ((Company)CompaniesComboBox.SelectedItem).CompanyId;
            project.IsInProgress = true;
            project.StartDate = DateTime.Now;
            project.EndDate = DateTime.Now;
            projectRepository.Save(project);
            SelectProjectForWork(project);
        }

        private void EnterWorkingOnProjectState(string description="") {
            if(currentProject == null) { throw new Exception("No project selected"); }
            SetEnabledForProjectButtons(false, true, true);
            descriptionTextBox.Text = description;
            state = MainFormState.WorkingOnProjectState;
            LastTimeStarted = DateTime.Now;
            timer1.Enabled = true;
            currentProject.IsInProgress = true;
        }

        /*
        - В кода се отбелязва че проект е паузиран
        - Създава се запис към избрания проект в базата данни с начало последното запазено време на 
          стартиране, край времето на паузиране, попълненото описание, регистрирания потребител
        - Всички за всяка снимка заснето от последното стартиране се прави запис в базата с адреса и, и id-то на последния запис към проекта 
 
         не съм измислил как при повторно кликане пак да включва таймера
        */
        private void PauseButton_Click(object sender, EventArgs e)
        {
            PauseWorkOnProject();
            SelectProjectForWork(currentProject);
            ResetTimer();
        }


        /*
          - В базата се отбелязва че проекта е завършен
          - В горната част се показва форма за добавяне на нов проект към дадената фирма 
          - Спира брояча
        */
        private void StopButton_Click(object sender, EventArgs e)
        {
            PauseWorkOnProject(true);
            EnterAddingNewProjectState();
            ResetTimer();
        }

        private void EnterAddingNewProjectState() {
            currentProject = null;
            state = MainFormState.CreatingProjectState;
            projectNameTextBox.Text = "";
            projectNameTextBox.ReadOnly = false;
            descriptionTextBox.Text = "";
            SetEnabledForProjectButtons(true, false, false);

        }

        private void ResetTimer() {
            timer1.Enabled = false;
            ElapsedTime = TimeSpan.Zero;
            TIMER.Text = ("00:00:00");
        }

        private void SetEnabledForProjectButtons(bool enableStartButton, bool enablePauseButton, bool enableStopButton) {
            StartButton.Enabled = enableStartButton;
            PauseButton.Enabled = enablePauseButton;
            StopButton.Enabled = enableStopButton;
        }

        private void CompaniesComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            Company selectedCompany = (Company)CompaniesComboBox.SelectedItem;
            projectBindingSource.DataSource = selectedCompany.Project;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
        e.RowIndex >= 0) {
                Project project = projectGridView.Rows[e.RowIndex].DataBoundItem as Project;
                PauseWorkOnProject();
                SelectProjectForWork(project);
            }
        }

        private void PauseWorkOnProject(bool stopWorkOnProject = false) {
            if (state != MainFormState.WorkingOnProjectState) { return; }
            if (currentProject == null) { throw new Exception("No project selected"); }
            ProjectLog log = new ProjectLog();
            log.ProjectId = currentProject.ProjectId;
            log.StartDate = LastTimeStarted;
            log.EndDate = DateTime.Now;
            log.UserId = loggedInUserId;
            log.Description = descriptionTextBox.Text;
            projectLogRepository.Save(log);
            currentProject.EndDate = log.EndDate;
            currentProject.IsInProgress = !stopWorkOnProject;
            projectRepository.Save(currentProject);
            state = MainFormState.ProjectPausedState;
        }

        private void SelectProjectForWork(Project project) {
            currentProject = project;
            projectNameTextBox.Text = currentProject.Name;
            projectNameTextBox.ReadOnly = true;
            state = MainFormState.ProjectPausedState;
            SetEnabledForProjectButtons(true, false, true);
        }
    }

    public enum MainFormState {
        CreatingProjectState,
        WorkingOnProjectState,
        ProjectPausedState,
        Count
    }
}
