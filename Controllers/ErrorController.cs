using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace FullTrailning.Controllers;
[Route("api/[controller]")]
[ApiController]
public class ErrorController : ControllerBase
{
    [HttpGet]
    public async Task <IActionResult> post()
    {
        throw new Exception();
    }
}
