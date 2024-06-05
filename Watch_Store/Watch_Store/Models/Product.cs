
using System.ComponentModel.DataAnnotations;

namespace Watch_Store.Models;

public class Product
{
    public string ProductId { get; set; }
    public string Name { get; set; }
    public string Category { get; set; }
    public string ImagePath { get; set; }
    public decimal Price { get; set; }
    public string Description { get; set; }
}