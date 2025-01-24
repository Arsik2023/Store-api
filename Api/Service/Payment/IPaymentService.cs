using Microsoft.AspNetCore.Mvc;

namespace Api;

public interface IPaymentService
{
    Task<ActionResult<ResponseServer>> HandlePaymentAsync(
        string userId, int orderHeaderId, string cardHeader
    );
}
