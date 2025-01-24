using Microsoft.AspNetCore.Mvc;

namespace Api;

public class FakePaymentService : IPaymentService
{
    public Task<ActionResult<ResponseServer>> HandlePaymentAsync(string userId, int orderHeaderId, string cardHeader)
    {
        throw new NotImplementedException();
    }
}
