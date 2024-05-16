using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Text;
using MyWebApi.Models;
using MyWebApi.Services;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using MyWebApi.Utils;

namespace MyWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IConfiguration configuration;
        private ICommonService<AppUser, AppUser, AppUser> _userService;

        public AuthController(IConfiguration configuration, ICommonService<AppUser, AppUser, AppUser> userService)
        {
            this.configuration = configuration;
            _userService = userService;
        }

        [HttpPost]
        public async Task<IActionResult> Authenticate([FromBody]Credential credential)
        {
            // Get current user
            var user = await _userService.GetByName(credential.UserName);
            
            if (user == null)
            {
                return NotFound();
            }

            // Verify the credential
            if (credential.UserName == user.Username && EncryptionHelper.EncryptString(credential.Password) == user.Password)
            {
                // Creating the claims
                var claims = new List<Claim> {
                    new Claim(ClaimTypes.Name, user.Username), // Name claim
                    new Claim(ClaimTypes.Role, user.Role)  // Role claim
                };
                // Expiration date for JWT token (30 minutes)
                var expiresAt = DateTime.UtcNow.AddMinutes(30);

                return Ok(new
                {
                    access_token = CreateToken(claims, expiresAt),
                    expires_at = expiresAt
                });
                
            }
            return Unauthorized();
        }

        private string CreateToken(IEnumerable<Claim> claims, DateTime expireAt)
        {
            var secretKey = Encoding.ASCII.GetBytes(configuration.GetValue<string>("SecretKey")??"");

            // Generate the JWT
            var jwt = new JwtSecurityToken(
                    claims: claims,
                    notBefore: DateTime.UtcNow,
                    expires: expireAt,
                    signingCredentials: new SigningCredentials(
                        new SymmetricSecurityKey(secretKey),
                        SecurityAlgorithms.HmacSha256Signature)
                );

            return new JwtSecurityTokenHandler().WriteToken(jwt);
        }

    }
}