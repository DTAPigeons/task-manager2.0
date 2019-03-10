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
        readonly TimeSpan SCREEN_SHOT_INTERVAL = new TimeSpan(0, 0, 10);
        const string DEFAULT_SCREEN_SHOT_FOLDER = @"H:\Uni\TaskManager\ScreenShots";

        TimeSpan screenShotTimer;
        TimeSpan elapsedTime;
        DateTime lastTimeElapsed;
        DateTime lastTimeStarted;
        DateTime lastScreenShotTime;
        CompanyRepository companyRepository;
        ProjectLogRepository projectLogRepository;
        ProjectRepository projectRepository;
        ScreenShotRepository screenShotRepository;
        MainFormState state;
        Project currentProject;
        int loggedInUserId;
        List<Bitmap> screenShots= new List<Bitmap>();

        public MainForm(int loggedInUserId = 1)
        {
            this.loggedInUserId = loggedInUserId;
            companyRepository = new CompanyRepository();
            projectLogRepository = new ProjectLogRepository();
            projectRepository = new ProjectRepository();
            screenShotRepository = new ScreenShotRepository();
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
            elapsedTime += DateTime.Now - lastTimeElapsed;
            screenShotTimer += DateTime.Now - lastTimeElapsed;

            if (screenShotTimer.Seconds >= SCREEN_SHOT_INTERVAL.Seconds) {
                Bitmap screenShot = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
                Graphics graphics = Graphics.FromImage(screenShot as Image);
                graphics.CopyFromScreen(0, 0, 0, 0, screenShot.Size);
                screenShots.Add(screenShot);
                screenShotTimer = TimeSpan.Zero;
                lastScreenShotTime = DateTime.Now;
            }

            lastTimeElapsed = DateTime.Now;

            TIMER.Text = Convert.ToString(new TimeSpan(elapsedTime.Hours, elapsedTime.Minutes, elapsedTime.Seconds));
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
            else if(state == MainFormState.ProjectPausedState) {
                EnterWorkingOnProjectState();
            }
            else {
                throw new Exception("Start button shouldn't be active!");
            }

            SetEnabledForProjectButtons(false, true, true);
            lastTimeElapsed = DateTime.Now;
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
            ResetProjectsGrid();
        }

        private void EnterWorkingOnProjectState(string description="") {
            screenShots.Clear();
            if(currentProject == null) { throw new Exception("No project selected"); }
            SetEnabledForProjectButtons(false, true, true);
            descriptionTextBox.Text = description;
            state = MainFormState.WorkingOnProjectState;
            ResetTimer();
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
            elapsedTime = TimeSpan.Zero;
            screenShotTimer = TimeSpan.Zero;
            lastTimeStarted = DateTime.Now;
            lastScreenShotTime = DateTime.Now;
            TIMER.Text = ("00:00:00");
        }

        private void SetEnabledForProjectButtons(bool enableStartButton, bool enablePauseButton, bool enableStopButton) {
            StartButton.Enabled = enableStartButton;
            PauseButton.Enabled = enablePauseButton;
            StopButton.Enabled = enableStopButton;
        }

        private void CompaniesComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            ResetProjectsGrid();
        }

        private void ResetProjectsGrid() {
            Company selectedCompany = companyRepository.GetById(((Company)CompaniesComboBox.SelectedItem).CompanyId);
            companyRepository.Update(selectedCompany);
            projectBindingSource.DataSource = selectedCompany.Project;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
        e.RowIndex >= 0) {
                Project project = projectGridView.Rows[e.RowIndex].DataBoundItem as Project;
                if(state==MainFormState.WorkingOnProjectState) PauseWorkOnProject();
                SelectProjectForWork(project);
            }
        }

        private void PauseWorkOnProject(bool stopWorkOnProject = false) {
            if (currentProject == null) { throw new Exception("No project selected"); }
            if (state == MainFormState.WorkingOnProjectState) { 
            ProjectLog log = new ProjectLog();
            log.ProjectId = currentProject.ProjectId;
            log.StartDate = lastTimeStarted;
            log.EndDate = DateTime.Now;
            ResetTimer();
            log.UserId = loggedInUserId;
            log.Description = descriptionTextBox.Text;
            projectLogRepository.Save(log);
            currentProject.EndDate = log.EndDate;
            SaveScreenShots(log);
        }
            currentProject.IsInProgress = !stopWorkOnProject;
            projectRepository.Save(currentProject);
            state = MainFormState.ProjectPausedState;
            ResetProjectsGrid();
            ResetTimer();
            screenShots.Clear();
        }

        private void SaveScreenShots(ProjectLog log) {
            if(screenShots==null || screenShots.Count <= 0) { return; }
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.SelectedPath = DEFAULT_SCREEN_SHOT_FOLDER;
            dialog.Description = "Select where to save your screen shots";

            if(dialog.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(dialog.SelectedPath)) {
                foreach(Bitmap screenShot in screenShots) {
                    string path = dialog.SelectedPath + @"\" + "Screen Shot_" + Guid.NewGuid() + ".png";
                    screenShot.Save(path);
                    Screenshots screenShotdata = new Screenshots();
                    screenShotdata.Location = path;
                    screenShotdata.ProjectLogId = log.ProjectLogId;
                    screenShotRepository.Save(screenShotdata);
                }
            }
        }

        private void SelectProjectForWork(Project project) {
            currentProject = project;
            projectNameTextBox.Text = currentProject.Name;
            projectNameTextBox.ReadOnly = true;
            state = MainFormState.ProjectPausedState;
            SetEnabledForProjectButtons(true, false, true);
            ResetProjectsGrid();
        }

        private void addProjectButton_Click(object sender, EventArgs e) {
            if (state == MainFormState.WorkingOnProjectState) {
                PauseWorkOnProject();
            }
            EnterAddingNewProjectState();
        }
    }

    public enum MainFormState {
        CreatingProjectState,
        WorkingOnProjectState,
        ProjectPausedState,
        Count
    }
}
