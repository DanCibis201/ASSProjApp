using CoffeeShop.Application.Queries.CoffeeQuery;
using CoffeeShop.Core.Models;
using CoffeeShop.Infrastructure.Repositories;
using MediatR;

namespace CoffeeShop.Application.Handlers;

public class GetAllCoffeesHandler : IRequestHandler<GetAllCoffeesQuery, IEnumerable<Coffee>>
{
    private readonly IRepository<Coffee> _repository;

    public GetAllCoffeesHandler(IRepository<Coffee> repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<Coffee>> Handle(GetAllCoffeesQuery request, CancellationToken cancellationToken)
    {
        return await _repository.GetAllAsync();
    }
}