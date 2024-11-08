﻿using CoffeeShop.Application.Commands.CoffeeCommands;
using CoffeeShop.Core.Models;
using CoffeeShop.Infrastructure.Repositories;
using MediatR;

namespace CoffeeShop.Application.Handlers.CoffeeHandler
{
    public class CreateCoffeeHandler : IRequestHandler<CreateCoffeeCommand, Unit>
    {
        private readonly IRepository<Coffee> _repository;

        public CreateCoffeeHandler(IRepository<Coffee> repository)
        {
            _repository = repository;
        }

        public async Task<Unit> Handle(CreateCoffeeCommand request, CancellationToken cancellationToken)
        {
            var coffee = new Coffee
            {
                Id = Guid.NewGuid(),
                Name = request.Name,
                Price = request.Price
            };

            await _repository.AddAsync(coffee);
            return Unit.Value;
        }
    }
}