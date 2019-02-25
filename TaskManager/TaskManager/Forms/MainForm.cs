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

namespace TaskManager
{
    public partial class MainForm : Form
    {
        TimeSpan ElapsedTime;
        DateTime LastElapsed;

        public MainForm()
        {
            InitializeComponent();
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
            PauseButton.Enabled = true;
            StopButton.Enabled = true;
            timer1.Enabled = true;
            LastElapsed = DateTime.Now;
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
            StartButton.Enabled = true;
            PauseButton.Enabled = false;
            StopButton.Enabled = false;

            //спира таймера,  и го занулява
            timer1.Enabled = false;
            ElapsedTime = TimeSpan.Zero; 
            TIMER.Text=("00:00:00");
        }
    }
}
