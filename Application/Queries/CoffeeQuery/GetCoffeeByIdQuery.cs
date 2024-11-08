using CoffeeShop.Core.Models;
using CoffeeShop.Infrastructure.Queries;

namespace CoffeeShop.Application.Queries.CoffeeQuery;

public class GetCoffeeByIdQuery : IQuery<Coffee>
{
    public Guid Id { get; set; }

    public GetCoffeeByIdQuery(Guid id)
    {
        Id = id;
    }
}