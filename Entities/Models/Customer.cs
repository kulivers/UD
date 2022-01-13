using System.ComponentModel.DataAnnotations;

namespace Entities.Models;

public class Customer
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Name is a required field.")]
    [MaxLength(30, ErrorMessage = "Maximum length for the Name is 30 characters.")]
    public string Name { get; set; }


    [Required(ErrorMessage = "Age is a required field.")]
    public int Age { get; set; }

    public decimal MockMoney { get; set; }
}