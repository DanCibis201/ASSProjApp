using CoffeeShop.Core.Models;
using CoffeeShop.Infrastructure.Queries;

namespace CoffeeShop.Application.Queries.OrderQueries;

public class GetOrderByIdQuery : IQuery<Order>
{
    public Guid Id { get; set; }

    public GetOrderByIdQuery(Guid id)
    {
        Id = id;
    }
}