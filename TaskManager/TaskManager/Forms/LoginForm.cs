using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace TaskManager
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        //След проверка в базата отваря MainForm
        private void LoginButton_Click(object sender, EventArgs e)
        {
            MainForm MF = new MainForm();
            MF.Show();
        }

        //Отваря формата за регистрация
        private void RegisterButton_Click(object sender, EventArgs e)
        {
            RegisterForm RegForm = new RegisterForm();
            RegForm.Show();
        }
    }
}
