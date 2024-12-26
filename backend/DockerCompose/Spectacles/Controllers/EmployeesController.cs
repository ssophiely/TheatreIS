using Microsoft.AspNetCore.Mvc;
using Spectacles.Storage;
using System.Net;

namespace Spectacles.Controllers;

[ApiController]
[Route("employees")]
public class EmployeesController : ControllerBase
{
    public EmployeesController(EmpStorage storage)
    {
        _storage = storage;
    }

    /// <summary>
    /// Получение данных по сотрудникам.
    /// </summary>
    [HttpGet]
    public async Task<IActionResult> Get()
    {
        try
        {
            return await Task.Run<IActionResult>(() =>
            {
                var info = _storage.GetEmployees();

                return Ok(info);
            });
        }
        catch (Exception ex)
        {
            return Problem(ex.Message, statusCode: (int)HttpStatusCode.UnprocessableEntity);
        }
    }

    private readonly EmpStorage _storage;
}
