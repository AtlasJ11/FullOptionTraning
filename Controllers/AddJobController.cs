using FullTrailning.Dto;
using FullTrailning.Model;
using FullTrailning.Option;
using FullTrailning.Prestence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace FullTrailning.Controllers;
[Route("api/[controller]")]
[ApiController]
public class AddJobController : ControllerBase
{
    private readonly Context _context;
    private readonly Config _config;

    public AddJobController(Context context, IOptions<Config> config)
    {
        _context = context;
        this._config = config.Value;
    }

    [HttpPost]
    public IActionResult CreateJob([FromBody] JobDto dto)
    {
        dto.Jobname ??= _config.DefultDescription;
        var job = new Job()
        {
            JobName = dto.Jobname,
            JobDescription = dto.Description ??=  _config.DefultDescription
        };
        _context.Jobs.Add(job);
        _context.SaveChanges();
        return Ok(job);
    }
}
