using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseManagement {
   public class Rental {
        public int rentalId { get; set; }
        public int customerId { get; set; }
        public int toolId { get; set; }
        public string fullName { get { return $"{lastName},{firstName}"; } }
        public string productName { get; set; }
        public DateTime dateRented { get; set; }
        public Nullable<DateTime> dateReturned { get; set; }       
        public string firstName { get; set; }
        public string lastName { get; set; }

    }
}
