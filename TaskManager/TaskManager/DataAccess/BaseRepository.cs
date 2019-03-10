using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.DataAccess {
    class BaseRepository {
        private static TaskManagerEntities context = null;

        public BaseRepository() {
            if (context == null) {
                context = new TaskManagerEntities();
            }
        }

        public TaskManagerEntities Context { get { return context; } }
    }
}
