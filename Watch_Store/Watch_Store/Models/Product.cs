
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Watch_Store.Models;

public class Product
{
    public string ProductId { get; set; }

    [StringLength(60, MinimumLength = 3)]
    [Required]
    public string Name { get; set; }

    [Required]
    [StringLength(30)]
    public string Category { get; set; } = string.Empty;

    [Display(Name = "Image")]
    public string ImagePath { get; set; }

    [Range(1, 100)]
    [DataType(DataType.Currency)]
    [Column(TypeName = "decimal(18, 2)")]
    public decimal Price { get; set; }
    public string Description { get; set; }
}