﻿namespace Api;

public class OrdersService
{
    private readonly AppDbContext dbContext;

    public OrdersService(AppDbContext dbContext)
    {
        this.dbContext = dbContext;
    }

    public async Task<OrderHeader> CreateOrderAsync(
        OrderHeaderCreateDto orderHeaderCreateDto
    )
    {
        var order = new OrderHeader
        {
            AppUserId = orderHeaderCreateDto.AppUserId,
            CustomerName = orderHeaderCreateDto.CustomerName,
            CustomerEmail = orderHeaderCreateDto.CustomerEmail,
            OrderTotalAmount = orderHeaderCreateDto.OrderTotalAmount,
            TotalCount = orderHeaderCreateDto.TotalCount,
            Status = string.IsNullOrEmpty(orderHeaderCreateDto.Status)
                ? SharedData.OrderStatus.Pending
                : orderHeaderCreateDto.Status
        };

        await dbContext.OrderHeaders.AddAsync(order);
        await dbContext.SaveChangesAsync();

        foreach (var orderDetailsDto in orderHeaderCreateDto.OrderDetailsDto)
        {
            var orderDetails = new OrderDetails
            {
                OrderHeaderId = order.OrderHeaderId,
                ProductId = orderDetailsDto.ProductId,
                Quantity = orderDetailsDto.Quantity,
                ItemName = orderDetailsDto.ItemName,
                Price = orderDetailsDto.Price,
            };
            await dbContext.OrderDetails.AddAsync(orderDetails);
        }
        await dbContext.SaveChangesAsync();
        return order;
    }
}
