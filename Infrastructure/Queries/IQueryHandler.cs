using MediatR;

namespace CoffeeShop.Infrastructure.Queries;

public interface IQueryHandler<in TCommand, TQueryResponse> : IRequestHandler<TCommand, TQueryResponse> where TCommand : IQuery<TQueryResponse>
{
}