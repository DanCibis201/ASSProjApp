using MediatR;

namespace CoffeeShop.Application.Commands.CoffeeCommands;

public class UpdateCoffeeCommand : IRequest<Unit>
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public string? Description { get; set; }
    public string? ImageUrl { get; set; }

    public UpdateCoffeeCommand(Guid id, string name, decimal price, string description, string imageUrl)
    {
        Id = id;
        Name = name;
        Price = price;
        Description = description;
        ImageUrl = imageUrl;
    }
}