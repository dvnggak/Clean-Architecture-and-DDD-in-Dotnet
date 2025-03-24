namespace BuberDinner.Application.Authentication
{
    public class AuthenticationService : IAuthenticationService
    {
        public AuthenticationResult Login(string Email, string Password)
        {
            return new AuthenticationResult(Guid.NewGuid(), Email, Password, "FirstName", "LastName");
        }

        public AuthenticationResult Register(string FirstName, string LastName, string Email, string Password)
        {
            return new AuthenticationResult(Guid.NewGuid(), FirstName, LastName, Email, "token");
        }
    }
}