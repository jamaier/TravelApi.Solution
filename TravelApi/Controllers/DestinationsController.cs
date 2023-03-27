using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TravelApi.Models;

namespace TravelApi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class DestinationsController : ControllerBase
  {
    private readonly TravelApiContext _db;

    public DestinationsController(TravelApiContext db)
    {
      _db = db;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Destination>>> Get()
    {
      return await _db.Destinations.ToListAsync();
    }

    //Get: apiDestinations/1
    [HttpGet("{id}")]
    public async Task<ActionResult<Destination>> GetDestination(int id)
    {
      Destination destination = await _db.Destinations.FindAsync(id);

      if (destination == null)
      {
        return NotFound();
      }

      return destination;
    }

    //POST api/destinations
    [HttpPost]
    public async Task<ActionResult<Destination>> Post(Destination destination)
    {
        _db.Destinations.Add(destination);
        await _db.SaveChangesAsync();
        return CreatedAtAction(nameof(GetDestination), new { id = destination.DestinationId }, destination);
    }
  }
}
