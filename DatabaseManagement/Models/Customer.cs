//---------------------------------
//<This is Qiang Ding's ICTPRG527 Assignment.>
//-------------------------------------------
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseManagement {
    public class Customer {
        public int customerId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string fullName { get { return $"{firstName},{lastName}"; } }

        public string phoneNumber { get; set; }
        public string email { get; set; }


    }
}
