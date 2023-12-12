using FullTrailning.Prestence;
using FullTrailning.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FullTrailning.Controllers;
[Route("api/[controller]")]
[ApiController]
public class DiShowInformationController : ControllerBase
{
    private readonly IDiServices services;
    private readonly Context context;

    public DiShowInformationController(IDiServices services, Context context)
    {
        this.services = services;
        this.context = context;
    }

    [HttpGet]
    public IActionResult ShowInfo (string Name)
    {
        var Info = context.Persons
            .Where(s => s.Name == Name);
        return Ok(Info);
    }
}
