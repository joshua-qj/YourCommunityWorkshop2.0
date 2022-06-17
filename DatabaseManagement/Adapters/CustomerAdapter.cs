using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;


namespace DatabaseManagement {
   public class CustomerAdapter : IDataAdapter<Customer> {
        public void AddNewData(Customer newCustomer) {
            string sql = "INSERT INTO tblCustomers " + "(firstName,lastName,phoneNumber,email) " + "VALUES(@firstName,@lastName,@phoneNumber,@email)";
            using (var connection = Helper.CreateDatabaseConnection()) {
                connection.Execute(sql, newCustomer);
            }
        }
        public void SaveExistingData(Customer updatedCustomer) {
            string sql = "UPDATE tblCustomers SET " + "firstName=@firstName,lastName=@lastName, " +
                "phoneNumber=@phoneNumber,email=@email " + $"WHERE customerID={updatedCustomer.customerId}";
            using (var connection = Helper.CreateDatabaseConnection()) {
                connection.Execute(sql, updatedCustomer);
            }
        }
    }
}
