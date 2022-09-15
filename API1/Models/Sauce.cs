using System.ComponentModel.DataAnnotations;

namespace API1.Models;

public class Sauce
{
    public int Id { get; set; }

    [Required]
    [MaxLength(100)]
    public string? Name { get; set; }

    public bool IsVegan { get; set; }
}