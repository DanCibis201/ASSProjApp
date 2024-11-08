using CoffeeShop.Application.Commands.CoffeeCommand;
using CoffeeShop.Core.Models;
using CoffeeShop.Infrastructure.Repositories;
using MediatR;

namespace CoffeeShop.Application.Handlers.CoffeeHandler;

public class DeleteCoffeeByIdHandler : IRequestHandler<DeleteCoffeeByIdCommand, Unit>
{
    private readonly IRepository<Coffee> _repository;

    public DeleteCoffeeByIdHandler(IRepository<Coffee> repository)
    {
        _repository = repository;
    }

    public async Task<Unit> Handle(DeleteCoffeeByIdCommand request, CancellationToken cancellationToken)
    {
        await _repository.DeleteAsync(request.Id);
        return Unit.Value;
    }
}