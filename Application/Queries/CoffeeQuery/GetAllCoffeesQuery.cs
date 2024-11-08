using MediatR;
using CoffeeShop.Core.Models;

namespace CoffeeShop.Application.Queries.CoffeeQuery;

public class GetAllCoffeesQuery : IRequest<IEnumerable<Coffee>>
{
}