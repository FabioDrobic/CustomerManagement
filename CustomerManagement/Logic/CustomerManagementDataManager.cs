using System.Data;
using System.Data.SqlClient;
using CustomerManagement.Global;

namespace CustomerManagement.Logic
{
    public class CustomerManagementDataManager
    {
        /// <summary>
        /// Die Kunden-Tabelle aus der lokalen CustomersDB laden
        /// </summary>
        /// <returns>Kundendaten in form eines DataTables</returns>
        public DataTable GetCustomerData()
        {
            using var sqlDataAdapter = new SqlDataAdapter(@"USE CustomerDB
SELECT cus.CustomerID, Addresses.AddressID, cus.Salutation AS 'Anrede', cus.Title AS 'Titel', cus.FirstName AS 'Vorname', cus.LastName AS 'Nachname',
Addresses.Street AS 'Straße', Addresses.StreetNumber AS 'Straßennummer', Addresses.DoorNumber AS 'Türnummer', Cities.Zip AS 'Postleitzahl', 
Cities.Title AS 'Stadt', Countries.LocalTitle AS 'Land', cus.BirthDate AS 'Geburtsdatum', Genders.Title AS 'Geschlecht',
cus.AtuNumber AS 'ATU-Nummer', cus.PaymentTerm AS 'Zahlungsbedingung', cus.Discount AS 'Rabatt', BankAccounts.BankName AS 'Bankname',
BankAccounts.Iban AS 'IBAN', BankAccounts.Bic AS 'BIC'
FROM Customers cus
INNER JOIN Genders ON Genders.GenderID = cus.GenderID
INNER JOIN BankAccounts ON BankAccounts.CustomerID = cus.CustomerID
INNER JOIN Addresses ON Addresses.CustomerID = cus.CustomerID
INNER JOIN PaymentTerms ON PaymentTerms.Title = cus.PaymentTerm
INNER JOIN Countries ON Countries.ShortTitle = Addresses.Country
INNER JOIN Cities ON Cities.Zip = Addresses.Zip AND Cities.Country = Addresses.Country AND Cities.Title = Addresses.City",
                DataBaseConnectionData.ConnectionString);
            var dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }
    }
}