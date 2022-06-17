using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace DatabaseManagement {
    public class RentalAdapter : IDataAdapter <Rental> {

        public void AddNewData(Rental newLoan) {
            string sql = "INSERT INTO tblRentals " +
                "(customerId, toolId, dateRented) " +
                "VALUES (@customerId,@toolId,@dateRented)";
            using (var connection = Helper.CreateDatabaseConnection()) {
                connection.Execute(sql, newLoan);
            }
        }
        public void SaveExistingData(Rental rentalDetail) {
            string sql = "UPDATE tblRentals SET " +
       "customerId = @customerId, toolId = @toolId, dateRented = @dateRented,dateReturned = @dateReturned " +
       $"WHERE rentalId={rentalDetail.rentalId}";
            using (var connection = Helper.CreateDatabaseConnection()) {
                connection.Execute(sql, rentalDetail);
            }
        }
    }
}
