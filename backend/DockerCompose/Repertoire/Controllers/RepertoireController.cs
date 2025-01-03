using Exceptions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Repertoire.Clients;
using Repertoire.Interaction.In;
using Repertoire.Storage;
using System.Net;

namespace Repertoire.Controllers;

[ApiController]
[Route("repertoire")]
public class RepertoireController : ControllerBase
{
    public RepertoireController(RepertoireStorage storage, SpectaclesClient client)
    {
        _storage = storage;
        _client = client;
    }

    /// <summary>
    /// Получение репертуара.
    /// </summary>
    [HttpGet]
    public async Task<IActionResult> Get()
    {
        try
        {
            return await Task.Run<IActionResult>(async () =>
            {
                var reps = _storage.Get();

                foreach (var rep in reps)
                {
                    var spec = await _client.GetSpectacle(rep.SpectacleId);
                    rep.Spectacle = spec;
                }

                return Ok(reps);
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
            return await Task.Run<IActionResult>(async () =>
            {
                var repertoire = _storage.GetByDate(date);

                foreach (var rep in repertoire)
                {
                    rep.Spectacle = await _client.GetSpectacle(rep.SpectacleId);
                }

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
    [Authorize]
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
    [HttpDelete("{id}")]
    [Authorize]
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

    private readonly SpectaclesClient _client;

    private readonly RepertoireStorage _storage;
}
