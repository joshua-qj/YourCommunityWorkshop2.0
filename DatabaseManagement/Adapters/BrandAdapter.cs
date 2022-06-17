using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using DatabaseManagement;

namespace DatabaseManagement {
   public class BrandAdapter : IDataAdapter<Brand>  {
        public void AddNewData(Brand updatedBrand) {
            string sql = "INSERT INTO tblBrands " + "(brandName) " + "VALUES(@brandName)";
            using (var connection = Helper.CreateDatabaseConnection()) {
                connection.Execute(sql, updatedBrand);
            }
        }       
        public void SaveExistingData(Brand updatedBrand) {           
                string sql = "UPDATE tblBrands SET " + "brandName=@brandName " +
                   $"WHERE brandID={updatedBrand.brandId}";
                using (var connection = Helper.CreateDatabaseConnection()) {
                    connection.Execute(sql, updatedBrand);
                }
            }
    }
}
