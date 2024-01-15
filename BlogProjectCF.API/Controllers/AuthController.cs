using BlogProjectCF.BusinessL.Managers.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace BlogProjectCF.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly IAuthorManager _authorManager;
        public AuthController(IConfiguration configuration, IAuthorManager authorManager)
        {
            _configuration = configuration;
            _authorManager = authorManager;
        }
        [AllowAnonymous]
        [HttpPost("Login")]
        public IActionResult Login(string username, string password)
        {
            var user = _authorManager.MGetAuthorByUsernameAndPassword(username, password);
            if (user == null)
                return BadRequest("User Not Found");

            var token = GenerateJwtToken(username);
            return Ok(new { Token = token });
        }

        private string GenerateJwtToken(string username)
        {
            var key = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(_configuration.GetSection("JWTSecretKey").Value));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: "BlogProjectCF Ali Fortacı",
                audience: username,
                claims: new[] { new Claim(ClaimTypes.Name, username) },
                expires: DateTime.Now.AddMinutes(30),
                signingCredentials: creds
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

    }
}
