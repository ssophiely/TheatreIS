﻿using Authentication.Exceptions;
using Authentication.Interaction;
using Authentication.Storage;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Authentication.Controllers;

[ApiController]
[Route("auth/viewer")]
public class ViewerAuthenticationController : ControllerBase
{
    public ViewerAuthenticationController(IConfiguration configuration, UserStorage storage)
    {
        _configuration = configuration;
        _storage = storage;
    }

    /// <summary>
    /// Аутентификация в системе.
    /// </summary>
    [HttpPost("verify")]
    public async Task<IActionResult> Auth(ViewerAuthInfo viewer)
    {
        try
        {
            return await Task.Run<IActionResult>(() =>
            {
                if (_storage.VerifyViewer(viewer))
                {
                    var issuer = _configuration["JWT:Issuer"];
                    var audience = _configuration["JWT:Audience"];
                    var key = Encoding.UTF8.GetBytes(_configuration["JWT:Key"]!);
                    var signingCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256);

                    var subject = new ClaimsIdentity([
                        new Claim(JwtRegisteredClaimNames.Email, viewer.Mail)
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
    /// Регистрация.
    /// </summary>
    [HttpPost]
    public async Task<IActionResult> SigningUp(ViewerAuthInfo viewer)
    {
        try
        {
            return await Task.Run<IActionResult>(() =>
            {
                _storage.AddViewer(viewer);

                return Ok();
            });
        }
        catch (Exception ex)
        {
            return UnprocessableEntity(ex.Message);
        }
    }

    /// <summary>
    /// Обновление данных.
    /// </summary>
    [HttpPost("update")]
    public async Task<IActionResult> UpdateInfo(ViewerUpdateInfo info)
    {
        try
        {
            return await Task.Run<IActionResult>(() =>
            {
                _storage.UpdateViewer(info);

                return Ok();
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


    private readonly IConfiguration _configuration;
    private readonly UserStorage _storage;
}