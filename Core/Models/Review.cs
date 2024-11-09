namespace CoffeeShop.Core.Models;

public class Review
{
    public Guid Id { get; set; }
    public Guid CoffeeId { get; set; }
    public string? UserName { get; set; }
    public string Comment { get; set; }
    public int Rating { get; set; }

    public Coffee? Coffee { get; set; }
}