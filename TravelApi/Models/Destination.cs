using System.ComponentModel.DataAnnotations;

namespace TravelApi.Models
{
  public class Destination
  {
    public int DestinationId { get; set; }
    [Required]
    [StringLength(20)]
    public string Country { get; set; }
    [Required]
    public string City { get; set; }
    [Required]
    public string Review { get; set; }
    [Required]
    [Range(0, 200, ErrorMessage = "Rating must be between 0 and 10.")]
    public int Rating { get; set; }
    [Required]
    public string UserName { get; set; }
  }
}