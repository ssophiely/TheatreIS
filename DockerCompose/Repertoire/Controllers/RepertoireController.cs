using Exceptions;
using Microsoft.AspNetCore.Mvc;
using Repertoire.Interaction.In;
using Repertoire.Storage;
using System.Net;

namespace Repertoire.Controllers;

[ApiController]
[Route("repertoire")]
public class RepertoireController : ControllerBase
{
    public RepertoireController(RepertoireStorage storage)
    {
        _storage = storage;
    }

    /// <summary>
    /// Получение репертуара.
    /// </summary>
    [HttpGet("id")]
    public async Task<IActionResult> Get(int id)
    {
        try
        {
            return await Task.Run<IActionResult>(() =>
            {
                var repertoire = _storage.Get(id);

                return Ok(repertoire);
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

    /// <summary>
    /// Получение спектаклей из репертуара по дате.
    /// </summary>
    [HttpGet("date")]
    public async Task<IActionResult> GetByDate(DateTime date)
    {
        try
        {
            return await Task.Run<IActionResult>(() =>
            {
                var repertoire = _storage.GetByDate(date);

                return Ok(repertoire);
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

    /// <summary>
    /// Добавление спектакля в репертуар.
    /// </summary>
    [HttpPost]
    public async Task<IActionResult> Add(RepertoireAddInfo info)
    {
        try
        {
            return await Task.Run<IActionResult>(() =>
            {
                _storage.Add(info);

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

    /// <summary>
    /// Удаление спектакля из репертуара.
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



    private readonly RepertoireStorage _storage;
}
