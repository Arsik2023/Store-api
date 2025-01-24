﻿namespace Api;

public static class PaymentServiceExtension
{
    public static IServiceCollection AddPaymentService(
        this IServiceCollection services
    )
    {
        return services.AddScoped<IPaymentService, FakePaymentService>();
    }
}
