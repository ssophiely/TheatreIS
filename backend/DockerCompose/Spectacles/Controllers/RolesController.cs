using Exceptions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Spectacles.Interaction.In;
using Spectacles.Storage;
using System.Net;

namespace Spectacles.Controllers;

[Route("roles")]
[ApiController]
public class RolesController : ControllerBase
{
    public RolesController(SpectacleStorage storage)
    {
        _storage = storage;
    }


    [HttpPost]
    [Authorize]
    public async Task<IActionResult> AddRole(RoleAddInfo info)
    {
        try
        {
            return await Task.Run<IActionResult>(() =>
            {
                _storage.AddRole(info);

                return Ok();
            });
        }
        catch (Exception ex)
        {
            return Problem(ex.Message, statusCode: (int)HttpStatusCode.UnprocessableEntity);
        }
    }

    [HttpDelete("id")]
    [Authorize]
    public async Task<IActionResult> DeleteRole(int id)
    {
        try
        {
            return await Task.Run<IActionResult>(() =>
            {
                _storage.DeleteRole(id);

                return Ok();
            });
        }
        catch (NotFoundException ex)
        {
            return Problem(ex.Message, statusCode: (int)HttpStatusCode.NotFound);
        }
        catch (Exception ex)
        {
            return Problem(ex.Message, statusCode: (int)HttpStatusCode.UnprocessableEntity);
        }
    }

    [HttpPut("id")]
    [Authorize]
    public async Task<IActionResult> ChangeRole(int id, RoleUpdateInfo info)
    {
        try
        {
            return await Task.Run<IActionResult>(() =>
            {
                _storage.ChangeRole(id, info);

                return Ok();
            });
        }
        catch (NotFoundException ex)
        {
            return Problem(ex.Message, statusCode: (int)HttpStatusCode.NotFound);
        }
        catch (Exception ex)
        {
            return Problem(ex.Message, statusCode: (int)HttpStatusCode.UnprocessableEntity);
        }
    }

    private readonly SpectacleStorage _storage;
}
