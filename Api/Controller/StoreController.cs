using Api;
using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public class StoreController : ControllerBase
    {
        protected readonly AppDbContext dbContext;

        public StoreController(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
    }
}
