using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomerManagement.Global;

namespace CustomerManagement
{
    public partial class Dashboard : Form
    {
        private readonly UserLoginForm userLoginForm;

        public Dashboard()
        {
            userLoginForm = new UserLoginForm();
            InitializeComponent();
            EnableButtons(false);
        }
        
        public void EnableButtons(bool enabled)
        {
            manageUserOrdersButton.Enabled = enabled;
            manageUserRoleButton.Enabled = enabled;
        }

        private void LoginButtonClicked(object sender, EventArgs e)
        {
            Hide();
            userLoginForm.ShowDialog(this);
            EnableButtons(true);
        }

        private void ManageUserOrdersButtonClicked(object sender, EventArgs e)
        {
            Hide();
            new CustomerManagementForm().ShowDialog(this);
        }
    }
}
