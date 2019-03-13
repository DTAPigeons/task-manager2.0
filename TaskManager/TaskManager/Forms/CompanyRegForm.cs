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
    public partial class CompanyRegForm : Form
    {
        public CompanyRegForm()
        {
            InitializeComponent();
        }

        private void RegisterButton_Click(object sender, EventArgs e) {
            CompanyRepository companyRepository = null;
            companyRepository = new CompanyRepository();
            Company company = new Company();
            company.Name = CompanyNameTextBox.Text;
            company.Description = CompanyDescTextBox.Text;
            company.Website = WebSiteTextBox.Text;
            company.Address = AddressTextBox.Text;
            company.Email = EmailTextBox.Text;

            if (companyRepository.CompanyNameIsTaken(company.Name) == true) {
                MessageBox.Show("Въведено име на фирма вече е заето!");
            }
            else {
                companyRepository.Save(company);
                MessageBox.Show("Успешна регистрация!");
                Close();
            }
        }
    }
}
