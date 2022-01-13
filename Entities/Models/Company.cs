using System.ComponentModel.DataAnnotations;

namespace Entities.Models;

public class Company
{
    [Required(ErrorMessage = "Company Id is a required field.")]
    public int Id { get; set; }

    [Required(ErrorMessage = "Company name is a required field.")]
    [MaxLength(60, ErrorMessage = "Maximum length for the Name is 60 characters.")]
    public string? Name { get; set; }

    [Required(ErrorMessage = "Company address is a required field.")]
    [MaxLength(60, ErrorMessage = "Maximum length for the Address is 60 characters")]
    public string? Address { get; set; }

    public string? Country { get; set; }
    public ICollection<Item>? Items { get; set; }
}