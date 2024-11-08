using MediatR;
using CoffeeShop.Core.Models;

namespace CoffeeShop.Application.Queries.ReviewQueries;

public class GetAllReviewsQuery : IRequest<IEnumerable<Review>>
{
}