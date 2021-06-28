using System.Data;
using System.Data.SqlClient;
using CustomerManagement.Global;

namespace CustomerManagement.Logic
{
    public class UserDataManager
    {
        private SqlConnection sqlConnection;

        public UserDataManager()
        {
            sqlConnection = new SqlConnection(DataBaseConnectionData.ConnectionString);
        }

        public string GetUserPasswordHash(string username)
        {
            var command = new SqlCommand(@"USE CustomerDB 
SELECT u.PasswordHash FROM Users u WHERE u.Name = @username", sqlConnection);
            command.Parameters.AddWithValue("@username", username);

            sqlConnection.Open();
            var passwordHash = (string)command.ExecuteScalar();
            sqlConnection.Close();
            return passwordHash;
        }

        public string GetUserPasswordSalt(string username)
        {
            var command = new SqlCommand(@"USE CustomerDB 
SELECT u.PasswordSalt FROM Users u WHERE u.Name = @username", sqlConnection);
            command.Parameters.AddWithValue("@username", username);

            sqlConnection.Open();
            var passwordSalt = (string)command.ExecuteScalar();
            sqlConnection.Close();
            return passwordSalt;
        }

        public void InsertUser(string username, string passwordHash, string passwordSalt)
        {
            var command = new SqlCommand(@"USE CustomerDB 
INSERT INTO Users(Name, PasswordHash, PasswordSalt)
VALUES
(@username, @passwordHash, @passwordSalt)", sqlConnection);
            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@passwordHash", passwordHash);
            command.Parameters.AddWithValue("@passwordSalt", passwordSalt);

            sqlConnection.Open();
            command.ExecuteNonQuery();
            sqlConnection.Close();
        }
    }
}