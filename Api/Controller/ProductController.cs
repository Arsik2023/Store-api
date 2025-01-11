using Microsoft.AspNetCore.Mvc;
using Api;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace MyApp.Namespace
{

    public class ProductController : StoreController
    {

        public ProductController(AppDbContext dbContext) : base(dbContext) // наследование от родителя
        {

        }

        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            ResponseServer responseServer = new ResponseServer
            {
                StatusCode = HttpStatusCode.OK,
                Result = await dbContext.Products.ToListAsync()
            };
            return Ok(responseServer);
        }
    }
}
