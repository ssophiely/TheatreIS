﻿using Exceptions;
using Microsoft.AspNetCore.Mvc;
using Repertoire.Interaction.In;
using Repertoire.Storage;
using System.Net;

namespace Repertoire.Controllers;

[ApiController]
[Route("act")]
public class ActController : ControllerBase
{
    public ActController(ActStorage storage)
    {
        _storage = storage;
    }

    /// <summary>
    /// Добавление показа спектакля.
    /// </summary>
    [HttpPost]
    public async Task<IActionResult> Add(ActCreateInfo info)
    {
        try
        {
            return await Task.Run<IActionResult>(() =>
            {
                _storage.Add(info);

                return Ok();
            });
        }
        catch (Exception ex)
        {
            return Problem(ex.Message, statusCode: (int)HttpStatusCode.UnprocessableEntity);
        }
    }

    /// <summary>
    /// Удаление показа.
    /// </summary>
    [HttpDelete("id")]
    public async Task<IActionResult> Delete(int id)
    {
        try
        {
            return await Task.Run<IActionResult>(() =>
            {
                _storage.Delete(id);

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

    private readonly ActStorage _storage;
}
