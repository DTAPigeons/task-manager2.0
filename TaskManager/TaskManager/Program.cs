using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskManager.DataAccess;

namespace TaskManager {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            UserRepository users = new UserRepository();
            ProjectRepository projects = new ProjectRepository();

            List<Project> all = projects.GetAll();

            List<Project> killers = projects.GetAllWithFilters(null, null, null, null, 2, "геноцид");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ReportsForm());
        }
    }
}
