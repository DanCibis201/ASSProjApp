using CoffeeShop.Core.Models;
using CoffeeShop.Infrastructure.Queries;

namespace CoffeeShop.Application.Queries.ReviewQueries;

public class GetReviewByIdQuery : IQuery<Review>
{
    public Guid Id { get; set; }

    public GetReviewByIdQuery(Guid id)
    {
        Id = id;
    }
}