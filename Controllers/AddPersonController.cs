using FullTrailning.Model;
using FullTrailning.Prestence;
using Microsoft.AspNetCore.Mvc;

namespace FullTrailning.Controllers;
[Route("api/[controller]")]
[ApiController]
public class AddPersonController : ControllerBase
{
    private readonly Context _context;

    public AddPersonController(Context context)
    {
        _context = context;
    }

    [HttpPost]
    public IActionResult CreatePerson(string userName, int age)
    {
        var person = new Person()
        {
            Name = userName,
            Age = age,
            PhoneNumber = "null"
        };

        _context.Persons.Add(person);
        _context.SaveChanges();

        return Ok(person);
    }

}
