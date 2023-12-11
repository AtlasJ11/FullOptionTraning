using FullTrailning.Dto;
using FullTrailning.Model;
using FullTrailning.Option;
using FullTrailning.Prestence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Options;

namespace FullTrailning.Controllers;
[Route("api/[controller]")]
[ApiController]
public class AddPersonController : ControllerBase
{
    private readonly Context _context;
    private readonly Config _config;

    public AddPersonController(Context context,IOptions<Config> config)
    {
        _context = context;
        _config = config.Value;
    }

    [HttpPost]
    public IActionResult CreatePerson([FromBody] PersonDto dto)
    {
        var person = new Person()
        {
            Name = dto.Name,
            Age = dto.Age,
            PhoneNumber = dto.Phone??= _config.DefultDescription
        };

        _context.Persons.Add(person);
        _context.SaveChanges();

        return Ok(person);
    }

}
