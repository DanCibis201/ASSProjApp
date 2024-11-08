using MediatR;

namespace CoffeeShop.Application.Commands.CoffeeCommands;

public class CreateCoffeeCommand : IRequest<Unit>
{
    public string Name { get; set; }
    public decimal Price { get; set; }
}