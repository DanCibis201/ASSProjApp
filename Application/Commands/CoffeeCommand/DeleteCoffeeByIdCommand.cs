using MediatR;

namespace CoffeeShop.Application.Commands.CoffeeCommand;

public class DeleteCoffeeByIdCommand : IRequest<Unit>
{
    public Guid Id { get; set; }

    public DeleteCoffeeByIdCommand(Guid id)
    {
        Id = id;
    }
}