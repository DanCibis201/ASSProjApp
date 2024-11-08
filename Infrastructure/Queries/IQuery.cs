using MediatR;

namespace CoffeeShop.Infrastructure.Queries;

public interface IQuery<out TQueryResponse> : IRequest<TQueryResponse>
{
}