using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;

namespace TestApi.Controllers;

[ApiVersion(1)]
[Route("api/v{version:apiVersion}/[controller]")]
[ApiController]
public class BooksController : ControllerBase
{
    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(Data.books);
    }
}
