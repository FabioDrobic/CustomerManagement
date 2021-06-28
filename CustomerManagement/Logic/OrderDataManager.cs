using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;
using CustomerManagement.Global;

namespace CustomerManagement.Logic
{
    public class OrderDataManager
    {
        private SqlDataAdapter orderDataAdapter;

        private SqlConnection sqlConnection;

        public OrderDataManager()
        {
            sqlConnection = new SqlConnection(DataBaseConnectionData.ConnectionString);
            orderDataAdapter = new SqlDataAdapter(new SqlCommand(@"USE CustomerDB
SELECT * FROM Orders", sqlConnection));
        }

        public DataTable GetCustomerOrderData(int customerID)
        {
            // Alle Daten in den DataTable laden
            var sqlCommand = new SqlCommand(@"USE CustomerDB
SELECT orders.OrderID, orders.Date AS 'Kaufdatum', status.Title, orders.PaymentTerm AS 'Zahlungsbedingung', positions.ProductPrice AS 'Kaufpreis', productTypes.Title AS 'Kauf-Produkttyp',
positions.Amount AS 'Menge', billing.Street AS 'Rechnungs-Straße', billing.StreetNumber AS 'Rechnungs-Straßennummer',
billing.DoorNumber AS 'Rechnungs-Türnummer', billing.Zip AS 'Rechnungs-PLZ', billing.City AS 'Rechnungs-Stadt', billing.Country AS 'Rechnungs-Land',
delivery.Street AS 'Lieferungs-Straße', delivery.StreetNumber AS 'Lieferungs-Straßennummer', delivery.DoorNumber AS 'Lieferungs-Türnummer', 
delivery.Zip AS 'Lieferungs-PLZ', delivery.City AS 'Lieferungs-Stadt', delivery.Country AS 'Lieferungs-Land', products.Title AS 'Produkttitel',
products.Price AS 'Aktueller Produktpreis', products.Economy AS 'Währung', products.Stock AS 'Produkt-Lagermenge',
Products.Tax AS 'Ust.', Products.Type AS 'Aktueller Produkttyp'
FROM Orders orders
INNER JOIN OrderPositions positions ON positions.OrderID = orders.OrderID
INNER JOIN Products products ON products.ProductID = positions.ProductID
INNER JOIN ProductTypes productTypes ON productTypes.Title = products.Type
INNER JOIN Status status ON status.Title = orders.Status
INNER JOIN Addresses billing ON billing.AddressID = positions.BillingAddressID
INNER JOIN Addresses delivery ON delivery.AddressID = positions.DeliveryAddressID
WHERE orders.CustomerID = @customerID",
                sqlConnection);
            sqlCommand.Parameters.AddWithValue("@customerID", customerID);

            var sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlConnection.Open();
            var dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }

        public DataTable GetOrderPositions()
        {
            var command = new SqlCommand("SELECT * FROM OrderPositions", sqlConnection);
            var dataTable = new DataTable();
            var sqlDataAdapter = new SqlDataAdapter(command);
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }

        public DataTable GetProducts()
        {
            var command = new SqlCommand("SELECT * FROM Products", sqlConnection);
            var dataTable = new DataTable();
            var sqlDataAdapter = new SqlDataAdapter(command);
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }

        public DataTable GetPaymentTerms()
        {
            var command = new SqlCommand("SELECT * FROM PaymentTerms", sqlConnection);
            var dataTable = new DataTable();
            var sqlDataAdapter = new SqlDataAdapter(command);
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }

        public void InsertProductInOrderPosition(int orderID, int productID, decimal productPrice, string productType, int billingAddressID, int deliveryAddressID, int productAmount)
        {
            var getOrderPositionProcedure = new SqlCommand("GetOrderPosition", sqlConnection)
            {
                CommandType = CommandType.StoredProcedure
            };

            getOrderPositionProcedure.Parameters.AddWithValue("@orderID", orderID);

            sqlConnection.Open();

            var orderPosition = (int)getOrderPositionProcedure.ExecuteScalar();

            var insertCommand = new SqlCommand(
                @"INSERT INTO OrderPositions(OrderID, Position, ProductID, ProductPrice, ProductType, BillingAddressID, DeliveryAddressID, Amount)
VALUES
(@orderID, @orderPosition, @productID, @productPrice, @productType, @billingAddressID, @deliveryAddressID, @productAmount)", sqlConnection);
            insertCommand.Parameters.AddWithValue("@orderID", orderID);
            insertCommand.Parameters.AddWithValue("@orderPosition", orderPosition);
            insertCommand.Parameters.AddWithValue("@productID", productID);
            insertCommand.Parameters.AddWithValue("@productPrice", productPrice);
            insertCommand.Parameters.AddWithValue("@productType", productType);
            insertCommand.Parameters.AddWithValue("@billingAddressID", billingAddressID);
            insertCommand.Parameters.AddWithValue("@deliveryAddressID", deliveryAddressID);
            insertCommand.Parameters.AddWithValue("@productAmount", productAmount);

            var x = insertCommand.ExecuteScalar();

            sqlConnection.Close();
        }

        public int InsertOrder(int customerID, DateTime date, string status, string paymentTerm)
        {
            InsertStatus(status);

            var insertCommand = new SqlCommand(@"INSERT INTO Orders(CustomerID, Date, Status, PaymentTerm)
OUTPUT inserted.OrderID
VALUES
(@customerID, @date, @status, @paymentTerm)", sqlConnection);

            insertCommand.Parameters.AddWithValue("@customerID", customerID);
            insertCommand.Parameters.AddWithValue("@date", date);
            insertCommand.Parameters.AddWithValue("@status", status);
            insertCommand.Parameters.AddWithValue("@paymentTerm", paymentTerm);
            sqlConnection.Open();
            var x = (int)insertCommand.ExecuteScalar();
            sqlConnection.Close();
            return x;
        }

        public void InsertStatus(string status)
        {
            var selectCommand = new SqlCommand(@"USE CustomerDB 
SELECT * FROM Status WHERE Title = @status", sqlConnection);
            selectCommand.Parameters.AddWithValue("@status", status);

            var sqlDataAdapter = new SqlDataAdapter(selectCommand);
            var dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            if (dataTable.Rows.Count < 1)
            {
                var insertCommand = new SqlCommand(@"USE CustomerDB 
INSERT INTO Status(Title)
OUTPUT inserted.Title
VALUES
(@title)", sqlConnection);
                insertCommand.Parameters.AddWithValue("@title", status);
                sqlConnection.Open();
                insertCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
        }
    }
}
