using Api;
using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    public class PaymentController : StoreController
    {
        private readonly IPaymentService paymentService;

        public PaymentController(AppDbContext dbContext, IPaymentService paymentService)
            : base(dbContext)
        {
            this.paymentService = paymentService;
        }

        [HttpPost]
        public async Task<ActionResult<ResponseServer>> MakePayment(
            string userId, int orderHeaderId, string cardNumber
        )
        {
            return await paymentService.HandlePaymentAsync(
                userId, orderHeaderId, cardNumber
            );
        }
    }
}
