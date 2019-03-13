using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskManager.DataAccess;

namespace TaskManager
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        //След проверка в базата прави запис на нов потребител(ако е валидна)
        private void RegisterButton_Click(object sender, EventArgs e) {
            UserRepository userRepository = null;
            User user = new User();
            user.Username = UsernameTextBox.Text;
            user.Password = PasswordTextBox.Text;
            user.FirstName = FirstnameTextBox.Text;
            user.LastName = LastnameTextBox.Text;
            user.Age = Convert.ToInt32(AgeTextBox.Text);
            user.Email = EmailTextBox.Text;

            /*->*/
            if (userRepository.UserNameIsTaken(user.Username) == true) {
                MessageBox.Show("Въведено поотребителско име вече е заето!");
            }
            else {
                try {
                    userRepository.Save(user);
                    MessageBox.Show("Успешна регистрация!");
                    Close();
                }
                catch (DbEntityValidationException ex) {
                    MessageBox.Show("Невалидни данни!");
                }
                catch (Exception ex) {
                    MessageBox.Show("Нещо гръмна: " + ex.Message);
                }
            }
        }
    }
}
