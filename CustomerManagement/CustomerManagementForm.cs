using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using CustomerManagement.Global;
using CustomerManagement.Logic;

namespace CustomerManagement
{
    public partial class CustomerManagementForm : Form
    {
        private readonly CustomerManagementDataManager customerManagementDataManager;
        private readonly OrderDataManager orderDataManager;

        private DataGridViewRow SelectedCustomerRow => customerGrid.SelectedRows?.Count > 0 ? customerGrid.SelectedRows[0] : null;

        private string SelectedCustomerFullName => (string)SelectedCustomerRow?.Cells["Vorname"].Value
                                                   + ' '
                                                   + (string)SelectedCustomerRow?.Cells["Nachname"].Value;

        private int SelectedCustomerID => (int)(SelectedCustomerRow?.Cells["CustomerID"]?.Value ?? 0);
        public CustomerManagementForm()
        {
            customerManagementDataManager = new CustomerManagementDataManager();
            orderDataManager = new OrderDataManager();

            InitializeComponent();
            InitData();

            customerGrid.SelectionChanged += CustomerGridOnSelectionChanged;
        }

        private void InitData()
        {
            //try
            //{
                customerGrid.DataSource = customerManagementDataManager.GetCustomerData();
                //customerGrid.Columns["CustomerID"].Visible = false;
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("Die Daten konnten nicht geladen werden. Überprüfen Sie, ob Ihre Kundendatenbank vorhanden ist.");
            //}
        }

        private void CustomerGridOnSelectionChanged(object sender, EventArgs e)
        {
            if (orderGrid.SortedColumn == null) return;
            orderGrid.SortedColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
            orderGrid.DataSource = orderDataManager.GetCustomerOrderData(SelectedCustomerID);
        }

        private void OnAddCustomerButtonClicked(object sender, EventArgs e)
        {
            using var addCustomerForm = new CustomerForm();
            addCustomerForm.ShowDialog();
            customerGrid.DataSource = customerManagementDataManager.GetCustomerData();
        }

        private void ManageCustomerOrderButtonClicked(object sender, EventArgs e)
        {
            using var orderManagementForm = new OrderManagementForm(SelectedCustomerFullName, SelectedCustomerID,
                (int)SelectedCustomerRow.Cells["AddressID"]?.Value);
            orderManagementForm.ShowDialog();
            orderGrid.DataSource = orderDataManager.GetCustomerOrderData(SelectedCustomerID);
        }
    }
}
