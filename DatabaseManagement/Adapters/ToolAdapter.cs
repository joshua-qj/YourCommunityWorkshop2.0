using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace DatabaseManagement {
   public class ToolAdapter : IDataAdapter <Tools> {
        public void AddNewData(Tools tool) {
            string sql = "INSERT INTO tblTools " +
    "( productName, toolSerialNO, statusId, brandId, onRental, condition) " +
    "VALUES (@productName, @toolSerialNO, @statusId, @brandId, @onRental, @condition)";
            using (var connection = Helper.CreateDatabaseConnection()) {
                connection.Execute(sql, tool);
            }
        }

        public void SaveExistingData(Tools updatedTool) {
            string sql = "UPDATE tblTools SET " + "productName=@productName, " +
                "toolSerialNO=@toolSerialNO, statusId=@statusId, brandId=@brandId,condition=@condition " +
             $"WHERE toolID={updatedTool.toolId}";
            using (var connection = Helper.CreateDatabaseConnection()) {
                connection.Execute(sql, updatedTool);
            }
        }
    }
}
