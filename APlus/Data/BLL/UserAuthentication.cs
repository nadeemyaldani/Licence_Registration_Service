namespace APlus.Data.BLL
{
    public class UserAuthentication
    {
        public Task<bool> Login()
        {
            return Task.FromResult(true);
        }
        public Task<bool> Register()
        {
            return Task.FromResult(true);
        }
        public Task<bool> Logout()
        {
            return Task.FromResult(true);
        }
        public Task<bool> ValidateAll()
        {
            return Task.FromResult(true);
        }
    }
}