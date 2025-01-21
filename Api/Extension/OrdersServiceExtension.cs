namespace Api;

public static class OrdersServiceExtension
{
    public static IServiceCollection AddOrdersService(
        this IServiceCollection services
    )
    {
        return services.AddScoped<OrdersService>();
    }
}
