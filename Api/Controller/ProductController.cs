using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{

    public class ProductController : StoreController
    {
        [HttpGet()]
        public async Task<ActionResult<string>> Get()
        {
            return Ok(await Task.FromResult<string>("Hello world"));
        }

    }
}
