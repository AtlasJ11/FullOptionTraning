using FullTrailning.Prestence;
using FullTrailning.Service;
using Microsoft.AspNetCore.Mvc;

namespace FullTrailning.Controllers;
[Route("api/[controller]")]
[ApiController]
public class DiShowInformationController : ControllerBase
{
    private readonly IDiServices _services;
    private readonly Context context;

    public DiShowInformationController(IDiServices services, Context context)
    {
        _services = services;
        this.context = context;
    }

    [HttpGet]
    public IActionResult ShowInfo(string Name)
    {
        var Info = context.Persons
            .Where(s => s.Name.Contains(Name))
            .ToList();

        if (Info is null)
            return NotFound("nothing found");

        return Ok(Info);
    }

    [HttpPost]
    public IActionResult SearchWiththeDI(string name, int age)
    {
        var searchresult = context.Persons
            .Where(s => s.Name == name && s.Age == age)
            .FirstOrDefault();
        if (searchresult is null)
        {
            return NotFound("No maching record found");
        }
        return Ok(_services.ShowUserInfo(searchresult.Name, searchresult.Age));
    }
}
