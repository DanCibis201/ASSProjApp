﻿using CoffeeShop.Application.Commands.CoffeeCommands;
using CoffeeShop.Core.Models;
using CoffeeShop.Infrastructure.Repositories;
using MediatR;

namespace CoffeeShop.Application.Handlers.CoffeeHandlers;

public class UpdateCoffeeHandler : IRequestHandler<UpdateCoffeeCommand, Unit>
{
    private readonly IRepository<Coffee> _repository;

    public UpdateCoffeeHandler(IRepository<Coffee> repository)
    {
        _repository = repository;
    }

    public async Task<Unit> Handle(UpdateCoffeeCommand request, CancellationToken cancellationToken)
    {
        var coffee = await _repository.GetByIdAsync(request.Id);
        if (coffee == null)
        {
            throw new KeyNotFoundException("Coffee not found");
        }

        coffee.Name = request.Name;
        coffee.Price = request.Price;
        coffee.Description = request.Description;
        coffee.ImageUrl = request.ImageUrl;

        await _repository.UpdateAsync(coffee);
        return Unit.Value;
    }
}