using Exceptions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Spectacles.Interaction.In;
using Spectacles.Storage;
using System.Net;

namespace Spectacles.Controllers;

[ApiController]
[Route("spectacles")]
public class SpectaclesController : ControllerBase
{
    public SpectaclesController(SpectacleStorage storage)
    {
        _storage = storage;
    }

    /// <summary>
    /// Получение данных по всем спектаклям.
    /// </summary>
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        try
        {
            return await Task.Run<IActionResult>(() =>
            {
                var spectacles = _storage.GetAll();

                return Ok(spectacles);
            });
        }
        catch (Exception ex)
        {
            return Problem(ex.Message, statusCode: (int)HttpStatusCode.UnprocessableEntity);
        }
    }

    /// <summary>
    /// Получение всех жанров.
    /// </summary>
    [HttpGet("genres")]
    public async Task<IActionResult> GetGenres()
    {
        try
        {
            return await Task.Run<IActionResult>(() =>
            {
                var genres = _storage.GetGenres();

                return Ok(genres);
            });
        }
        catch (Exception ex)
        {
            return Problem(ex.Message, statusCode: (int)HttpStatusCode.UnprocessableEntity);
        }
    }

    /// <summary>
    /// Получение данных по спектаклю.
    /// </summary>
    [HttpGet("{id}")]
    public async Task<IActionResult> Get(int id)
    {
        try
        {
            return await Task.Run<IActionResult>(() =>
            {
                var spectacle = _storage.GetSpectacle(id);

                return Ok(spectacle);
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
    /// Создание спектакля.
    /// </summary>
    [HttpPost]
    [Authorize]
    public async Task<IActionResult> Add(SpectacleCreateInfo info)
    {
        try
        {
            return await Task.Run<IActionResult>(() =>
            {
                _storage.CreateSpectacle(info);

                return Ok();
            });
        }
        catch (Exception ex)
        {
            return Problem(ex.Message, statusCode: (int)HttpStatusCode.UnprocessableEntity);
        }
    }

    /// <summary>
    /// Удаление спектакля.
    /// </summary>
    [HttpDelete("{id}")]
    [Authorize]
    public async Task<IActionResult> Delete(int id)
    {
        try
        {
            return await Task.Run<IActionResult>(() =>
            {
                _storage.DeleteSpectacle(id);

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
    /// Изменение данных по спектаклю.
    /// </summary>
    [HttpPut("{id}")]
    [Authorize]
    public async Task<IActionResult> Update(int id, SpectacleUpdateInfo info)
    {
        try
        {
            return await Task.Run<IActionResult>(() =>
            {
                _storage.UpdateSpectacle(id, info);

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

    private SpectacleStorage _storage;
}