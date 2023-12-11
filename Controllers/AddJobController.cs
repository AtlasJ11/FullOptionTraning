using FullTrailning.Model;
using FullTrailning.Prestence;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FullTrailning.Controllers;
[Route("api/[controller]")]
[ApiController]
public class AddJobController : ControllerBase
{
    private readonly Context _context;

    public AddJobController(Context context)
    {
        _context = context;
    }

    [HttpPost] 
    public IActionResult CreateJob (string jobname)
    {
        var job = new Job()
        {
            JobName = jobname,
            JobDescription = "null"
        };
        _context.Jobs.Add(job);
        _context.SaveChanges();
        return Ok(job);
    }
}
