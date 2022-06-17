using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DatabaseManagement;
using System.Configuration;

namespace DatabaseManagement {
    public static class Helper {
        private static string GetConnectionString(string name) {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
        public static SqlConnection CreateDatabaseConnection() {
            return new SqlConnection(GetConnectionString("YourCommunityWorkshopDatabase"));
        }
   
    }
}
