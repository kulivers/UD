using System.ComponentModel.DataAnnotations;

namespace Entities.Models;

public class Order
{
    public int Id { get; set; }

    [Required(ErrorMessage = "CustomerIdIsRequired")]
    public int CustomerId { get; set; }

    [Required(ErrorMessage = "ItemIdsIsRequired")]
    public ICollection<int> ItemId { get; set; }

    public float? Discount { get; set; } = 0;

    public DateTime? DateTime { get; set; }
}