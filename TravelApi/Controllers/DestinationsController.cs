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

    // Pagination Code:
    [HttpGet("page/{page}")]
    public async Task<ActionResult<List<Destination>>> GetPages(int page, int pageSize = 6)
    {
      if (_db.Destinations == null)
        return NotFound();

      int pageCount = _db.Destinations.Count();

      var destinations = await _db.Destinations
        .Skip((page - 1) * pageSize)
        .Take(pageSize)
        .ToListAsync();

      var response = new DestinationResponse
      {
        Destinations = destinations,
        //page number inside the url
        CurrentPage = page,
        //the amount of destinations returned from our database
        Pages = pageCount,
        //amnt of items on the page
        PageSize = pageSize
      };
      return Ok(response);
    }

    [HttpGet]
    public async Task<List<Destination>> Get(string country, string city, string review, int rating, string userName)
    {

      IQueryable<Destination> query = _db.Destinations.AsQueryable();

      if (country != null)
      {
        query = query.Where(entry => entry.Country == country);
      }

      if (city != null)
      {
        query = query.Where(entry => entry.City == city);
      }

      if (review != null)
      {
        query = query.Where(entry => entry.Review == review);
      }

      if (rating >= 0)
      {
        query = query.Where(entry => entry.Rating >= rating);
      }

      if (userName != null)
      {
        query = query.Where(entry => entry.UserName == userName);
      }

      return await query.ToListAsync();
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

      return Ok(destination);
    }

    //POST api/destinations
    [HttpPost]
    public async Task<ActionResult<Destination>> Post(Destination destination)
    {
      _db.Destinations.Add(destination);
      await _db.SaveChangesAsync();
      return CreatedAtAction(nameof(GetDestination), new { id = destination.DestinationId }, destination);
    }

    //PUT: api/Destinations/5
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Destination destination)
    {
      if (id != destination.DestinationId)
      {
        return BadRequest();
      }

      _db.Destinations.Update(destination);

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!DestinationExists(id))
        {
          return NotFound();
        }
        else
        {
          throw;
        }
      }
      return NoContent();
    }

    private bool DestinationExists(int id)
    {
      return _db.Destinations.Any(location => location.DestinationId == id);
    }

    //DELETE: api/Destinations/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteDestination(int id)
    {
      Destination destination = await _db.Destinations.FindAsync(id);
      if (destination == null)
      {
        return NotFound();
      }

      _db.Destinations.Remove(destination);
      await _db.SaveChangesAsync();

      return NoContent();
    }
  }
}