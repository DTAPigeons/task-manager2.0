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
        DateTime LastElapsed;
        CompanyRepository companyRepository;
        ProjectLogRepository projectLogRepository;
        ProjectRepository projectRepository;
        MainFormState state;


        public MainForm()
        {
            companyRepository = new CompanyRepository();
            projectLogRepository = new ProjectLogRepository();
            projectRepository = new ProjectRepository();
            InitializeComponent();
            foreach(Company company in companyRepository.GetAll()) {
                CompaniesComboBox.Items.Add(company);
            }
        }

        private void EnterAddingNewProjectState() {
            state = MainFormState.CreatingProjectState;
            projectNameTextBox.Text = "";
            projectNameTextBox.ReadOnly = false;
            descriptionTextBox.Text = "";
            SetEnabledForProjectButtons(true, false, false);

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
            ElapsedTime += DateTime.Now - LastElapsed;
            LastElapsed = DateTime.Now;

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
            }

            SetEnabledForProjectButtons(false, true, true);
            LastElapsed = DateTime.Now;
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
            projectRepository.Save(project);
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
            timer1.Enabled = false;
        }

        /*
          - В базата се отбелязва че проекта е завършен
          - В горната част се показва форма за добавяне на нов проект към дадената фирма 
          - Спира брояча
        */
        private void StopButton_Click(object sender, EventArgs e)
        {
            SetEnabledForProjectButtons(true, false, false);

            ResetTimer();
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
    }

    public enum MainFormState {
        CreatingProjectState,
        WorkingOnProjectState,
        ProjectPausedState,
        Count
    }
}
