namespace BuberDinner.Contracts.Authentication
{
    public class AuthenticationResponse
    {
        Guid Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? Token { get; set; }
    }
}