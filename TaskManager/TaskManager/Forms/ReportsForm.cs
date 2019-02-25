using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManager
{
    public partial class ReportsForm : Form
    {
        public ReportsForm()
        {
            InitializeComponent();
        }

        //маркира задача отговаряща на критериите в таблицата
        private void SearchButton_Click(object sender, EventArgs e)
        {

        }

        //става активен при селектиране на задача от таблицата, отваря отделна форма за избрания проект
        private void DetailsButton_Click(object sender, EventArgs e)
        {
            DetailsReportForm DetRepForm = new DetailsReportForm();
            DetRepForm.Show();
        }

    }
}
