using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskManager.DataAccess;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace TaskManager
{
    public partial class LoginForm : Form
    {
        User user;

        public LoginForm()
        {
            InitializeComponent();
        }

        //„R„|„u„t „„‚„€„r„u„‚„{„p „r „q„p„x„p„„„p „€„„„r„p„‚„‘ MainForm
        private void LoginButton_Click(object sender, EventArgs e)
        {
            UserRepository userRepository = null;
            userRepository = new UserRepository();
            Thread MF;
            string userName = UsernameTextBox.Text;
            string password = PasswordTextBox.Text;

            if (userRepository.UserCanLogIn(userName, password) == true) {
                //„ƒ„Œ„x„t„p„r„p „~„€„r„p „~„y„Š„{„p „x„p „s„|„p„r„~„p„„„p „†„€„‚„}„p „y „x„p„„„r„p„‚„‘ „„„p„x„y „x„p „|„€„s„r„p„~„u
                user = userRepository.GetByUsername(userName);
                MF = new Thread(openMainForm);
                MF.SetApartmentState(ApartmentState.STA);
                MF.Start();
                this.Close();
            }
            else MessageBox.Show("„C„‚„u„Š„~„p „„p„‚„€„|„p „y„|„y „„€„„„u„q„‚„y„„„u„|„ƒ„{„€ „y„}„u!");
        }

        private void openMainForm(object ojb) {
            Application.Run(new MainForm(user.UserId));
        }

        //„O„„„r„p„‚„‘ „†„€„‚„}„p„„„p „x„p „‚„u„s„y„ƒ„„„‚„p„ˆ„y„‘
        private void RegisterButton_Click(object sender, EventArgs e)
        {
            RegisterForm RegForm = new RegisterForm();
            RegForm.Show();
        }
    }
}
