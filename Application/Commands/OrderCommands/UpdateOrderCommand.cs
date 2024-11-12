﻿using MediatR;

namespace CoffeeShop.Application.Commands.OrderCommands;

public class UpdateOrderCommand : IRequest<Unit>
{
    public Guid Id { get; set; }
    public Guid CoffeeId { get; set; }
    public int Quantity { get; set; }
    public DateTime OrderDate { get; set; }

    public UpdateOrderCommand(Guid id, Guid coffeeId, int quantity, DateTime orderDate)
    {
        Id = id;
        CoffeeId = coffeeId;
        Quantity = quantity;
        OrderDate = orderDate;
    }
}