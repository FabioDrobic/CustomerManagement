using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerManagement
{
    public partial class CustomerForm : Form
    {
        private string connection = @"Data Source=FABIODROBIC;Initial Catalog=CustomerDB;Integrated Security=True";

        public CustomerForm()
        {
            InitializeComponent();
            paymentTermComboBox.DataSource = GetPaymentTerms();
        }

        private DataTable GetPaymentTerms()
        {
            using var sqlConnection = new SqlConnection(connection);
            var sqlCommand = new SqlCommand(@"USE CustomerDB

SELECT * FROM PaymentTerms", sqlConnection);

            var sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlConnection.Open();
            var dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            paymentTermComboBox.DisplayMember = "Title";
            paymentTermComboBox.ValueMember = "Title";

            return dataTable;
        }

        private void OnApplyButtonClicked(object sender, EventArgs e)
        {
            // Überprüfung auf leere Felder
            foreach (var control in Controls)
            {
                if (control is not TextBox textBox || !string.IsNullOrWhiteSpace(textBox.Text)) continue;
                MessageBox.Show("Es dürfen keine Felder leer gelassen werden.");
                return;
            }

            try
            {
                CreateNewCustomer();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Der Benutzer konnte nicht hinzugefügt werden.\n" + ex.Message);
            }
        }

        /// <summary>
        /// Methode um den Kunden inkl Infos in die DB zu übernehmen
        /// </summary>
        private void CreateNewCustomer()
        {
            using var sqlConnection = new SqlConnection(connection);
            sqlConnection.Open();

            // Command für das neue Land
            var command = new SqlCommand(@"INSERT INTO Countries(ShortTitle, InternationalTitle, LocalTitle)
VALUES (@shortTitle, @internationalTitle, @localTitle)", sqlConnection);

            command.Parameters.AddWithValue("@shortTitle", countryShortTitleTextBox.Text);
            command.Parameters.AddWithValue("@internationalTitle", internationalCountryTextBox.Text);
            command.Parameters.AddWithValue("@localTitle", localCountryTextBox.Text);
            command.ExecuteNonQuery();

            // Command für die neue Stadt
            command = new SqlCommand(@"INSERT INTO Cities(Title, Country, Zip)
VALUES (@title, @country, @zip)", sqlConnection);
            command.Parameters.AddWithValue("@title", cityTextBox.Text);
            command.Parameters.AddWithValue("@country", countryShortTitleTextBox.Text);
            command.Parameters.AddWithValue("@zip", zipTextBox.Text);
            command.ExecuteNonQuery();

            // Command für neues Geschlecht
            command = new SqlCommand(@"INSERT INTO Genders(Title)
OUTPUT inserted.GenderID
VALUES (@gender)", sqlConnection);
            command.Parameters.AddWithValue("@gender", genderTextBox.Text);
            command.ExecuteNonQuery();

            // GenderID über OUTPUT des vorherigen Statements ermitteln
            var sqlDataAdapter = new SqlDataAdapter(command);
            var dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            var genderID = (int)dataTable.Rows[0]["GenderID"];

            // Command für neuen Kunden
            command = new SqlCommand(@"INSERT INTO Customers
(
Salutation, Title, FirstName, LastName, BirthDate, GenderID, AtuNumber, PaymentTerm, Discount
)
OUTPUT inserted.CustomerID
VALUES
(@salutation, @title, @firstName, @lastName, @birthDate, @genderID, @atuNumber, @paymentTerm, @discount)",
                sqlConnection);
            command.Parameters.AddWithValue("@salutation", salutationTextBox.Text);
            command.Parameters.AddWithValue("@title", titleTextBox.Text);
            command.Parameters.AddWithValue("@firstName", customerFirstNameTextBox.Text);
            command.Parameters.AddWithValue("@lastName", customerLastNameTextBox.Text);
            command.Parameters.AddWithValue("@birthDate", birthDatePicker.Value);
            command.Parameters.AddWithValue("@genderID", genderID);
            command.Parameters.AddWithValue("@atuNumber", atuNumberTextBox.Text);
            command.Parameters.AddWithValue("@paymentTerm", paymentTermComboBox.SelectedItem);
            command.Parameters.AddWithValue("@discount", discountTextBox.Text);
            command.ExecuteNonQuery();

            // CustomerID über OUTPUT des vorherigen Statements ermitteln
            sqlDataAdapter = new SqlDataAdapter(command);
            dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            // Stelle Null steht für den OUTPUT
            var customerID = (int)dataTable.Rows[0]["CustomerID"];

            // Command für die neue Addresse
            command = new SqlCommand(@"INSERT INTO Addresses(Country, Zip, City, StreetNumber, Street, DoorNumber, CustomerID)
VALUES
(@country, @zip, @city, @streetNumber, @street, @doorNumber, @customerID)", sqlConnection);
            command.Parameters.AddWithValue("@country", countryShortTitleTextBox.Text);
            command.Parameters.AddWithValue("@zip", zipTextBox.Text);
            command.Parameters.AddWithValue("@city", cityTextBox.Text);
            command.Parameters.AddWithValue("@streetNumber", houseNumberTextBox.Text);
            command.Parameters.AddWithValue("@street", streetTextBox.Text);
            command.Parameters.AddWithValue("@doorNumber", doorNumberTextBox.Text);
            command.Parameters.AddWithValue("@customerID", customerID);
            command.ExecuteNonQuery();

            // Command für das neue Land
            command = new SqlCommand(@"INSERT INTO BankAccounts(Iban, BankName, Bic, CustomerID)
VALUES
(@iban, @bankName, @bic, @customerID)", sqlConnection);
            command.Parameters.AddWithValue("@iban", ibanTextBox.Text);
            command.Parameters.AddWithValue("@bankName", bankNameTextBox.Text);
            command.Parameters.AddWithValue("@bic", bicTextBox.Text);
            command.Parameters.AddWithValue("@customerID", customerID);
            command.ExecuteNonQuery();
        }
    }
}
