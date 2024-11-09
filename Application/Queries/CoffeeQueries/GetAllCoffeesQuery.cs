using MediatR;
using CoffeeShop.Core.Models;

namespace CoffeeShop.Application.Queries.CoffeeQueries;

public class GetAllCoffeesQuery : IRequest<IEnumerable<Coffee>>
{
}