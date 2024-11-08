﻿using CoffeeShop.Application.Queries.CoffeeQuery;
using CoffeeShop.Core.Models;
using CoffeeShop.Infrastructure.Repositories;
using MediatR;

namespace CoffeeShop.Application.Handlers.CoffeeHandler;

public class GetCoffeeByIdHandler : IRequestHandler<GetCoffeeByIdQuery, Coffee>

{
    private readonly IRepository<Coffee> _repository;

    public GetCoffeeByIdHandler(IRepository<Coffee> repository)
    {
        _repository = repository;
    }

    public async Task<Coffee> Handle(GetCoffeeByIdQuery request, CancellationToken cancellationToken)
    {
        return await _repository.GetByIdAsync(request.Id);
    }
}