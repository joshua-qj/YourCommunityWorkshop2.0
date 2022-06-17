using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using Dapper;

namespace DatabaseManagement{
    public class Initialiser : Adapter, IDataInitialiser {
        DatabaseManagement.IDataAdapter<Brand> brandAdapter = new BrandAdapter();
        DatabaseManagement.IDataAdapter<Tools> toolAdapter = new ToolAdapter();
        DatabaseManagement.IDataAdapter<Customer> customerAdapter = new CustomerAdapter();
        public void BuildDatabase() {            
                CreateDatabase();
                if (DoTablesExists() == false) {
                    CreateTables();
                    SeedDatabase();
                }            
        }
        private void CreateTables() {
            CreateBrandsTable();
            CreateCustomersTable();           
            CreateStatusTable();
            CreateToolsTable();
            CreateRentalsTable();
        }
        private void CreateBrandsTable() {
            string tableName = "tblBrands";
            string structure = "brandId decimal (18,0) IDENTITY(1,1) NOT NULL PRIMARY KEY, " +
                               "brandName VARCHAR(20) NOT NULL " ;
            CreateNewTable(tableName, structure);
        }
        private void CreateCustomersTable() {
            string tableName = "tblCustomers";
            string structure = "customerId decimal (18,0) IDENTITY(1,1) NOT NULL PRIMARY KEY, " +
                               "firstName VARCHAR(20) NOT NULL, " +
                               "lastName VARCHAR(20) NOT NULL, " +
                               "phoneNumber VARCHAR(20) NOT NULL, " +
                               "email VARCHAR(30) NOT NULL ";
            CreateNewTable(tableName, structure);
        }
        private void CreateRentalsTable() {
            string tableName = "tblRentals";
            string structure = "rentalId decimal (18,0) IDENTITY(1,1) NOT NULL PRIMARY KEY, " +
                               "customerId decimal (18,0) NOT NULL, " +
                               "toolId decimal (18,0) NOT NULL, " +
                               "dateRented datetime NOT NULL, " +
                               "dateReturned datetime  NULL, " +
                               "FOREIGN KEY(customerId) REFERENCES tblCustomers(customerId), " +
                               "FOREIGN KEY(toolId) REFERENCES tblTools(toolId) ";
             CreateNewTable(tableName, structure);
        }

        private void CreateStatusTable() {
            string tableName = "tblStatus";
            string structure = "statusId decimal (18,0) IDENTITY(1,1) NOT NULL  PRIMARY KEY, " +
                               "statusType VARCHAR(20) NOT NULL ";                               
            CreateNewTable(tableName, structure);
        }
        private void CreateToolsTable() {
            string tableName = "tblTools";
            string structure = "toolId decimal (18,0) IDENTITY(1,1) NOT NULL PRIMARY KEY, " +
                   "productName VARCHAR(20) NOT NULL, " +
                   "toolSerialNO VARCHAR (50) NOT NULL, " +
                   "onRental BIT NOT NULL, " +             
                   "statusId decimal (18,0) NOT NULL, "+
                   "brandId decimal (18,0) NOT NULL, " +
                   "condition VARCHAR (100)  NULL, " +
                   "FOREIGN KEY(statusId) REFERENCES tblStatus(statusId), " +
                   "FOREIGN KEY(brandId) REFERENCES tblBrands(brandId) ";
            CreateNewTable(tableName, structure);
        }
        public void SeedDatabase() {
            SeedBrandsTable();
            SeedCustomersTable();
            //SeedRentalsTable();
            SeedStatusTable();
            SeedToolsTable();
        }
        private void SeedBrandsTable() {
            List<Brand> newBrand = new List<Brand>();
            newBrand.Add(new Brand { brandName = "Stanley"});
            newBrand.Add(new Brand { brandName = "Makita" });
            newBrand.Add(new Brand { brandName = "Boche" });
            newBrand.Add(new Brand { brandName = "CAT" });
            newBrand.Add(new Brand { brandName = "BLACKDECK" });
            newBrand.Add(new Brand { brandName = "HITACHI" });
            newBrand.Add(new Brand { brandName = "Dewalt" });
            newBrand.Add(new Brand { brandName = "CRAFTMAN" });
            foreach (var item in newBrand) {
                brandAdapter.AddNewData(item);
            }
        }
        private void SeedCustomersTable() {
            List<Customer> newCustomers = new List<Customer>();
            newCustomers.Add(new Customer { lastName = "Van", firstName = "Roy", phoneNumber = "045258784755",email="123abc@456.com" });
            newCustomers.Add(new Customer { lastName = "Jones", firstName = "Bob", phoneNumber = "045258626355"  ,email="123789@456.com" }); ;
            newCustomers.Add(new Customer { lastName = "Smith", firstName = "Lucy", phoneNumber = "04575654655"  ,email="123poi@456.com" });
            foreach (var cust in newCustomers) {
                customerAdapter.AddNewData(cust);
            }
        }
        private void SeedStatusTable() {
            List<Status> newStatus = new List<Status>();
            newStatus.Add(new Status {statusType="Active" });
            newStatus.Add(new Status {statusType="Retired" });
            foreach (var item in newStatus) {
                AddNewStatus(item);
            }
        }
        private void SeedToolsTable() {
            List<Tools> newTools = new List<Tools>();
            newTools.Add(new Tools  { productName = "Impact driver", toolSerialNO = "ASDF", onRental = "False", statusId = 1 ,brandId=1,condition="brand new "}) ;
            newTools.Add(new Tools { productName = "Impact drill", toolSerialNO = "1234", onRental = "False", statusId = 1, brandId = 2, condition = "brand new " });
            newTools.Add(new Tools { productName = "Drop Saw", toolSerialNO = "ASD44445F", onRental = "False", statusId = 1, brandId = 3, condition = "no blade " });
            newTools.Add(new Tools { productName = "Generator", toolSerialNO = "ASDF", onRental = "False", statusId = 1, brandId = 4, condition = "brand new " });
            foreach (var item in newTools) {
                toolAdapter.AddNewData(item);
            }
        }

        #region Database Building


        public void CreateDatabase() {
            SqlConnection connection = Helper.CreateDatabaseConnection();
            SqlCommand command = new SqlCommand();
            try {
                string connectionString = $"Data Source = {connection.DataSource}; " +
                                          $"Integrated Security = True";
                string sql = $"IF NOT EXISTS (SELECT 1 FROM sys.databases WHERE " +
                             $"name = '{connection.Database}') " +
                             $"CREATE DATABASE {connection.Database}";
                using (SqlConnection connServer = new SqlConnection(connectionString)) {
                    using (command = new SqlCommand(sql, connServer)) {
                        if (connServer.State == ConnectionState.Closed) {
                            connServer.Open();
                        }
                        command.ExecuteNonQuery();
                        connServer.Close();
                    }
                }
            }
            catch (Exception e) {
                Console.WriteLine(e.ToString());
            }
        }

        private bool DoTablesExists() {
            var connection = Helper.CreateDatabaseConnection();
            string sql = $"SELECT COUNT(*) FROM " +
                         $"{connection.Database}.INFORMATION_SCHEMA.TABLES " +
                         $"WHERE TABLE_TYPE = 'BASE TABLE'";
            using (connection) {
                int num = connection.QuerySingle<int>(sql);
                if (num > 0) {
                    return true;
                }
                return false;
            }
        }
        private void CreateNewTable(string tableName, string structure) {
            string sql = $"CREATE TABLE {tableName} ({structure})";
            using (var connection = Helper.CreateDatabaseConnection()) {
                try {
                    connection.Execute(sql);
                }
                catch (Exception e) {
                    Console.WriteLine(e.ToString());
                }
            }
        }
        #endregion



    }
}
