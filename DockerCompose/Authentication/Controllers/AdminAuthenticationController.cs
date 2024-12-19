using Authentication.Exceptions;
using Authentication.Interaction;
using Authentication.Storage;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Authentication.Controllers;

[ApiController]
[Route("auth/admin")]
public class AdminAuthenticationController : ControllerBase
{
    public AdminAuthenticationController(IConfiguration configuration, UserStorage storage)
    {
        _configuration = configuration;
        _storage = storage;
    }

    /// <summary>
    /// �������������� � �������.
    /// </summary>
    [HttpPost("verify")]
    public async Task<IActionResult> Auth(AdminAuthInfo admin)
    {
        try
        {
            return await Task.Run<IActionResult>(() =>
            {
                if (_storage.VerifyAdmin(admin))
                {
                    var issuer = _configuration["JWT:Issuer"];
                    var audience = _configuration["JWT:Audience"];
                    var key = Encoding.UTF8.GetBytes(_configuration["JWT:Key"]!);
                    var signingCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256);

                    var subject = new ClaimsIdentity([
                        new Claim(JwtRegisteredClaimNames.Sub, admin.Name)
                    ]);

                    var expires = DateTime.UtcNow.AddMinutes(60);

                    var tokenDescriptor = new SecurityTokenDescriptor
                    {
                        Subject = subject,
                        Expires = expires,
                        Issuer = issuer,
                        Audience = audience,
                        SigningCredentials = signingCredentials
                    };

                    var tokenHandler = new JwtSecurityTokenHandler();
                    var token = tokenHandler.CreateToken(tokenDescriptor);
                    var jwtToken = tokenHandler.WriteToken(token);

                    return Ok(jwtToken);
                }

                return Unauthorized();
            });
        }
        catch (StorageException ex)
        {
            return NotFound(ex.Message);
        }
        catch (Exception ex)
        {
            return UnprocessableEntity(ex.Message);
        }
    }

    /// <summary>
    /// �����������.
    /// </summary>
    [HttpPost]
    public async Task<IActionResult> SigningUp(AdminAuthInfo admin)
    {
        try
        {
            return await Task.Run<IActionResult>(() =>
            {
                _storage.AddAdmin(admin);

                return Ok();
            });
        }
        catch (Exception ex)
        {
            return UnprocessableEntity(ex.Message);
        }
    }


    private readonly IConfiguration _configuration;
    private readonly UserStorage _storage;
}
