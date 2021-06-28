namespace CustomerManagement.Interfaces
{
    public interface IUserLogin
    {
        public string GenerateSalt(int length);

        public string GenerateHash(string plainText, string salt);

        public bool VerifyPasswordHash(string plainText, string storedHash, string salt);
    }
}