using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using CustomerManagement.Logic;

namespace CustomerManagement
{
    public partial class OrderManagementForm : Form
    {
        private readonly int customerID;
        private readonly int addressID;
        private readonly OrderDataManager orderDataManager;

        public OrderManagementForm(string customerName, int customerID, int addressID)
        {
            this.customerID = customerID;
            this.addressID = addressID;
            orderDataManager = new OrderDataManager();
            AcceptButton = createOrderButton;
            InitializeComponent();
            InitializeData(customerName);
        }

        private void InitializeData(string customerName)
        {
            productGrid.DataSource = orderDataManager.GetProducts();
            orderPositionGrid.DataSource = orderDataManager.GetOrderPositions();
            paymentTermsComboBox.DataSource = orderDataManager.GetPaymentTerms();
            paymentTermsComboBox.DisplayMember = "Title";
            customerNameTextBox.Text = customerName;
        }

        private void CreateOrderButtonClicked(object sender, EventArgs e)
        {

        }

        private void AddToCartButtonClicked(object sender, EventArgs e)
        {
            AddProductToCart();
            orderPositionGrid.Update();
        }

        private void AddProductToCart()
        {
            var selectedProductCells = productGrid.SelectedRows[0].Cells;
            var orderID = orderDataManager.InsertOrder(customerID, dateTimePicker1.Value, statusTextBox.Text, paymentTermsComboBox.SelectedText);

            if (sameAddressRadioButton.Checked)
            {
                orderDataManager.InsertProductInOrderPosition(orderID,
                    (int)selectedProductCells["ProductID"].Value, (decimal)selectedProductCells["Price"].Value,
                    (string)selectedProductCells["Type"].Value, addressID, addressID, (int)productAmount.Value);
                return;
            }

            // ToDo: Lieferadresse anlegen
            orderDataManager.InsertProductInOrderPosition(orderID,
                (int)selectedProductCells["ProductID"].Value, (decimal)selectedProductCells["Price"].Value,
                (string)selectedProductCells["Type"].Value, addressID, addressID, (int)productAmount.Value);
        }

        private void OwnAddressRadioButtonCheckedChanged(object sender, EventArgs e)
        {
            addressLayoutPanel.Enabled = true;
        }

        private void SameAddressRadioButtonCheckedChanged(object sender, EventArgs e)
        {
            addressLayoutPanel.Enabled = false;
        }
    }
}
