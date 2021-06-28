using System;
using System.Windows.Forms;
using CustomerManagement.Global;
using CustomerManagement.Logic;

namespace CustomerManagement
{
    public partial class UserLoginForm : Form
    {
        private readonly UserLogin userLogin;
        private readonly UserDataManager userDataManager;

        public UserLoginForm()
        {
            userLogin = new UserLogin();
            userDataManager = new UserDataManager();

            InitializeComponent();
            AcceptButton = loginButton;
        }

        private void LoginButtonClicked(object sender, EventArgs e)
        {
            var storedPasswordSalt = userDataManager.GetUserPasswordSalt(usernameTextBox.Text);

            string storedPasswordHash = userDataManager.GetUserPasswordHash(usernameTextBox.Text);

            if (!VerifyUserLogin(storedPasswordHash, storedPasswordSalt))
            {
                return;
            }

            Dispose();

            FormInstanceManager.DashboardSingleton.EnableButtons(true);

            if (FormInstanceManager.DashboardSingleton.Visible)
            {
                FormInstanceManager.DashboardSingleton.Activate();
            }
            else
            {
                FormInstanceManager.DashboardSingleton.ShowDialog();
            }
        }

        private bool VerifyUserLogin(string storedPasswordHash, string storedPasswordSalt)
        {
            DialogResult messageBoxResult;

            if (string.IsNullOrWhiteSpace(storedPasswordHash) || string.IsNullOrWhiteSpace(storedPasswordSalt))
            {
                messageBoxResult = MessageBox.Show(
                    "Die Kombination aus Benutzer und Passwort konnte nicht gefunden werden.\nMöchten Sie einen neuen Benutzer anlegen?",
                    "Login-Fehler", MessageBoxButtons.YesNo);
                if (messageBoxResult != DialogResult.Yes)
                {
                    return false;
                }

                InsertUserWithCredentials(storedPasswordSalt);
            }

            if (!userLogin.VerifyPasswordHash(passwordTextBox.Text, storedPasswordHash, storedPasswordSalt))
            {
                messageBoxResult = MessageBox.Show(
                    "Das angegebene Passwort stimmt nicht mit dem Benutzer überein.",
                    "Login-Fehler", MessageBoxButtons.OK);
            }
            
            return true;

        }

        private void InsertUserWithCredentials(string storedPasswordSalt)
        {
            var salt = userLogin.GenerateSalt(64);
            var hashedPassword = userLogin.GenerateHash(passwordTextBox.Text, storedPasswordSalt ?? salt);
            userDataManager.InsertUser(usernameTextBox.Text, hashedPassword, salt);
            Hide();
        }
    }
}
