using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager {
    public partial class User {
        public override string ToString() {
            return FirstName + " " + LastName;
        }
    }
}
