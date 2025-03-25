using BuberDinner.Application.Common.Interfaces.Authentication;

namespace BuberDinner.Application.Authentication
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IJwtTokenGenerator _jwtTokenGenerator;

        public AuthenticationService(IJwtTokenGenerator jwtTokenGenerator)
        {
            _jwtTokenGenerator = jwtTokenGenerator;
        }
        public AuthenticationResult Login(string Email, string Password)
        {
            return new AuthenticationResult(Guid.NewGuid(), Email, Password, "FirstName", "LastName");
        }

        public AuthenticationResult Register(string FirstName, string LastName, string Email, string Password)
        {
            // Chcek if the user is already registered

            // Create user (Generate Unique Id)

            // Generate Token

            Guid UserId = Guid.NewGuid();

            var token = _jwtTokenGenerator.GenerateToken(UserId, FirstName, LastName);

            return new AuthenticationResult(
                UserId, 
                FirstName, 
                LastName, 
                Email, 
                token
            );
        }
    }
}