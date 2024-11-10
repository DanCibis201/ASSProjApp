namespace CoffeeShop.Core.Models;

public class Coffee
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public string? ImageUrl { get; set; }

    public ICollection<Review>? Reviews { get; set; }
    public ICollection<Order>? Orders { get; set; }
}