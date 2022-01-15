using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

public class Item
{
    [Required(ErrorMessage = "Company Id is a required field.")]
    public int Id { get; set; }

    [Required(ErrorMessage = "Model name is a required field.")]
    [MaxLength(30, ErrorMessage = "Maximum length for the Name is 30 characters.")]
    public string? Model { get; set; }


    [Required(ErrorMessage = "Position is a required field.")]
    [MaxLength(20, ErrorMessage = "Maximum length for the Position is 20 characters.")]
    public string? Position { get; set; }

    public Company? Company { get; set; }

    [Precision(6,2)]
    public decimal Price { get; set; }
}