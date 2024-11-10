using CoffeeShop.Core.Models;
using MediatR;

namespace CoffeeShop.Application.Queries.OrderQueries;

public class GetAllOrdersQuery : IRequest<IEnumerable<Order>>
{
}