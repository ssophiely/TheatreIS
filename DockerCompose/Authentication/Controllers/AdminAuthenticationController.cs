using Authentication.Interaction;
using Exceptions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Net;
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
    /// Аутентификация в системе.
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
                    var id = _storage.GetAdminId(admin.Name);

                    var issuer = _configuration["JWT:Issuer"];
                    var audience = _configuration["JWT:Audience"];
                    var key = Encoding.UTF8.GetBytes(_configuration["JWT:Key"]!);
                    var signingCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256);

                    var subject = new ClaimsIdentity([
                        new Claim("id", id.ToString()),
                        new Claim("name", admin.Name)
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
        catch (NotFoundException ex)
        {
            return Problem(ex.Message, statusCode: (int)HttpStatusCode.NotFound);
        }
        catch (ExistsException ex)
        {
            return Problem(ex.Message, statusCode: (int)HttpStatusCode.Locked);
        }
        catch (Exception ex)
        {
            return Problem(ex.Message, statusCode: (int)HttpStatusCode.UnprocessableEntity);
        }
    }

    /// <summary>
    /// Регистрация.
    /// </summary>
    [HttpPost]
    public async Task<IActionResult> SigningUp(AdminAddInfo admin)
    {
        try
        {
            return await Task.Run<IActionResult>(() =>
            {
                _storage.AddAdmin(admin);

                return Ok();
            });
        }
        catch (ExistsException ex)
        {
            return Problem(ex.Message, statusCode: (int)HttpStatusCode.Locked);
        }
        catch (Exception ex)
        {
            return Problem(ex.Message, statusCode: (int)HttpStatusCode.UnprocessableEntity);
        }
    }


    private readonly IConfiguration _configuration;
    private readonly UserStorage _storage;
}
