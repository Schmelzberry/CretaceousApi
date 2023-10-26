using System.ComponentModel.DataAnnotations;

namespace CretaceousApi.Models
{
  public class Animal
  {
    public int AnimalId { get; set; }

    [Required]
    [StringLength(30, ErrorMessage = "Name must be between 1 and 30 characters.")]
    public string Name { get; set; }

    [Required]
    [StringLength(30, ErrorMessage = "Species must be between 1 and 30 characters.")]
    public string Species { get; set; }

    [Required]
    [Range(0, 200, ErrorMessage = "Age must be between 0 and 200.")]
    public int Age { get; set; }
  }
}