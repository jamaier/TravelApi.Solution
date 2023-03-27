using System.ComponentModel.DataAnnotations;
using TravelApi.Models;
using System.Collections.Generic;

namespace TravelApi.Models
{
  public class Destination
  {
    // public PagedList<Destination> GetDestinations(DestinationParameters destinationParameters)
    // {
    //   return PagedList<Destination>.ToPagedList(FindAll(),
    //                                             destinationParameters.PageNumber,
    //                                             destinationParameters.PageSize);
    // }
    public int DestinationId { get; set; }
    [Required]
    [StringLength(20)]
    public string Country { get; set; }
    [Required]
    public string City { get; set; }
    [Required]
    public string Review { get; set; }
    [Required]
    [Range(0, 10, ErrorMessage = "Rating must be between 0 and 10.")]
    public int Rating { get; set; }
    [Required]
    public string UserName { get; set; }
    // IQueryable<T> FindAll();
  }
}