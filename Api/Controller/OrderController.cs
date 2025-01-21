using Api;
using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : StoreController
    {
        private readonly OrdersService ordersService;

        public OrderController(AppDbContext dbContext, OrdersService ordersService)
            : base(dbContext)
        {
            this.ordersService = ordersService;
        }
    }
}
