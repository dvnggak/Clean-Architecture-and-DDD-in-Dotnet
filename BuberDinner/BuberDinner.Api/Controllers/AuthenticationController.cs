using BuberDinner.Contracts.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace BuberDinner.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        [HttpPost("register")]
        public IActionResult Register(RegisterRequest request)
        {
            // Implementation
            return Ok(request); // Ensure a default response is returned
        }

        [HttpPost("login")]
        public IActionResult Login(LoginRequest request)
        {
            // Implementation
            return Ok(request); // Ensure a default response is returned
        }
    }
}