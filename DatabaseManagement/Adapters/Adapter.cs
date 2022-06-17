//---------------------------------
//<This is Qiang Ding's ICTPRG527 Assignment.>
//-------------------------------------------


using System.Data;
using System.Drawing;
using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using DatabaseManagement;
using Dapper;
using System.ComponentModel;

namespace DatabaseManagement {
    public class Adapter {
        /// <summary>
        /// /
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="tableName"></param>
        /// <returns>
        /// This is a generic type method, get all different Database table data.
        /// </returns>
        public List<T> GetAllDataFromTable<T>(string tableName) {
            string sql = $"Select * from {tableName}";
            using (var connection = Helper.CreateDatabaseConnection()) {
                return connection.Query<T>(sql).ToList();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="id"></param>
        /// <param name="tableName"></param>
        /// <param name="idColumnName"></param>
        /// <returns>
        /// This is a generic type method, get single data from different table.
        /// </returns>
        public T GetSingleDataFromTable<T>(int id, string tableName, string idColumnName) {
            string sql = $"Select * from {tableName} WHERE {idColumnName}={id}";
            using (var connection = Helper.CreateDatabaseConnection()) {
                return connection.QuerySingle<T>(sql);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="tableName"></param>
        /// <param name="columnId"></param>
        /// <param name="id"></param>
        /// <returns>
        /// This is a generic type method, get single data from different table, by define where column data 
        /// </returns>
        public List<T> GetAllFilterDataFromTable<T>(string tableName, string columnId, int id) {
            string sql = $"Select * from {tableName} WHERE {columnId}={id}";
            using (var connection = Helper.CreateDatabaseConnection()) {
                return connection.Query<T>(sql).ToList();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="id"></param>
        /// <param name="tableName"></param>
        /// <param name="idColumnName"></param>
        ///      /// <returns>
        /// This is a generic type method, delete single data from different table, by define where column data 
        /// </returns>
        public void DeleteSingleData<T>(int id, string tableName, string idColumnName) {
            string sql = $"Delete from {tableName} WHERE {idColumnName}={id}";
            using (var connection = Helper.CreateDatabaseConnection()) {
                connection.Execute(sql);
            }
        }

        /// <summary>
        /// /
        /// </summary>
        /// <returns> Get a joined tool data with brand data and status data</returns>
        public List<Tools> GetJoinedToolsData() {
            string sql = "SELECT  tblTools.toolId, tblTools.productName, " +
                          "tblTools.toolSerialNO, tblStatus.statusType,tblTools.condition,  " +
                          "tblBrands.brandName, CASE WHEN onRental = CAST(0 AS BIT) " +
                          "THEN 'Not hired' ELSE 'Hired' END AS onRental " +
                          "FROM tblBrands INNER JOIN " +
           "tblTools ON tblBrands.brandId = tblTools.brandId INNER JOIN " +
           "tblStatus ON tblTools.statusId = tblStatus.statusId ";
            using (var connection = Helper.CreateDatabaseConnection()) {
                return connection.Query<Tools>(sql).ToList();
            }
        }
        public List<Tools> GetJoinedToolsData(bool hireStatus) {
            int isHire;
            if (hireStatus==true) {
                isHire = 1;
            }
            else {
                isHire = 0;
            }
            string sql = "SELECT  tblTools.toolId, tblTools.productName, " +
                          "tblTools.toolSerialNO, tblStatus.statusType,tblTools.condition,  " +
                          "tblBrands.brandName, CASE WHEN onRental = CAST(0 AS BIT) " +
                          "THEN 'Not hired' ELSE 'Hired' END AS onRental " +
                          "FROM tblBrands INNER JOIN " +
           "tblTools ON tblBrands.brandId = tblTools.brandId INNER JOIN " +
           $"tblStatus ON tblTools.statusId = tblStatus.statusId Where tblTools.onRental= {isHire} ";
            using (var connection = Helper.CreateDatabaseConnection()) {
                return connection.Query<Tools>(sql).ToList();
            }
        }
        public List<Tools> GetJoinedToolsData(int activeStatus) { 
            string sql = "SELECT  tblTools.toolId, tblTools.productName, " +
                          "tblTools.toolSerialNO, tblStatus.statusType,tblTools.condition,  " +
                          "tblBrands.brandName, CASE WHEN onRental = CAST(0 AS BIT) " +
                          "THEN 'Not hired' ELSE 'Hired' END AS onRental " +
                          "FROM tblBrands INNER JOIN " +
           "tblTools ON tblBrands.brandId = tblTools.brandId INNER JOIN " +
           $"tblStatus ON tblTools.statusId = tblStatus.statusId Where tblTools.statusId = {activeStatus} ";
            using (var connection = Helper.CreateDatabaseConnection()) {
                return connection.Query<Tools>(sql).ToList();
            }
        }
        public List<Rental> GetJoinedRentalData() {
            string sql = "SELECT tblRentals.*, tblCustomers.lastName, tblCustomers.firstName, tblTools.productName " +
                  "FROM  tblRentals INNER JOIN " +
                  "tblCustomers ON tblRentals.customerId = tblCustomers.customerId INNER JOIN " +
                  "tblTools ON tblRentals.toolId = tblTools.toolId INNER JOIN " +
                  "tblBrands ON tblTools.brandId = tblBrands.brandId INNER JOIN " +
                  "tblStatus ON tblTools.statusId = tblStatus.statusId ";
            using (var connection = Helper.CreateDatabaseConnection()) {
                Console.WriteLine();
                return connection.Query<Rental>(sql).ToList();

            }
        }
        public void AddNewStatus(Status newStatus) {
            string sql = "INSERT INTO tblStatus " + "(statusType) " + "VALUES(@statusType)";
            using (var connection = Helper.CreateDatabaseConnection()) {
                connection.Execute(sql, newStatus);
            }
        }
        public void UpdateToolRentalStatus(Tools updatedTool) {
            string sql = "UPDATE tblTools SET " +
                         "onRental=@onRental,condition=@condition " +
 $"WHERE toolID={updatedTool.toolId}";
            using (var connection = Helper.CreateDatabaseConnection()) {
                connection.Execute(sql, updatedTool);
            }
        }
        public void UpdateToolStatus(int id, int status, string condition) {
            string sql = "Update tblTools SET " +
                 $"onRental ={status},condition= {condition} " +
                 $"WHERE toolId={id}";
            using (var connection = Helper.CreateDatabaseConnection()) {
                connection.Execute(sql);
            }

        }

        public static DataTable ToDataTable(List<Tools> data) {
            PropertyDescriptorCollection properties =
                TypeDescriptor.GetProperties(typeof(Tools));
            DataTable table = new DataTable();
            foreach (PropertyDescriptor prop in properties)
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);

            foreach (var item in data) {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                table.Rows.Add(row);
            }
            return table;
        }


    }
}

