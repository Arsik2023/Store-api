using Microsoft.EntityFrameworkCore;

namespace Api;

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
            OrderDateTime = DateTime.UtcNow,
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

    public async Task<OrderHeader> GetOrderByIdAsync(int id)
    {
        return await dbContext
        .OrderHeaders
        .Include(items => items.OrderDetailItems)
        .ThenInclude(x => x.Product)
        .FirstOrDefaultAsync(u => u.OrderHeaderId == id);
    }

    public async Task<IEnumerable<OrderHeader>> GetOrderByUserIdAsync(string userId)
    {
        var query = dbContext
            .OrderHeaders
            .Include(items => items.OrderDetailItems)
            .OrderByDescending(u => u.AppUserId);

        if (!string.IsNullOrEmpty(userId))
        {
            return await query
                .Where(u => u.AppUserId == userId)
                .ToListAsync();
        }
        return await query.ToListAsync();
    }

    public async Task<bool> UpdateOrderHeaderAsync(int id, OrderHeaderUpdateDto orderHeaderUpdateDto)
    {
        if (orderHeaderUpdateDto == null
            || orderHeaderUpdateDto.OrderHeaderId != id)
        {
            return false;
        }

        var orderHeaderFromDb = await dbContext
            .OrderHeaders
            .FirstOrDefaultAsync(u => u.OrderHeaderId == id);

        if (orderHeaderFromDb == null)
        {
            return false;
        }

        if (!string.IsNullOrEmpty(orderHeaderUpdateDto.CustomerName))
        {
            orderHeaderFromDb.CustomerName = orderHeaderUpdateDto.CustomerName;
        }

        if (!string.IsNullOrEmpty(orderHeaderUpdateDto.CustomerEmail))
        {
            orderHeaderFromDb.CustomerEmail = orderHeaderUpdateDto.CustomerEmail;
        }

        if (!string.IsNullOrEmpty(orderHeaderUpdateDto.Status))
        {
            orderHeaderFromDb.Status = orderHeaderUpdateDto.Status;
        }

        await dbContext.SaveChangesAsync();

        return true;
    }
}
