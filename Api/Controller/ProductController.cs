using Microsoft.AspNetCore.Mvc;
using Api;
using Microsoft.EntityFrameworkCore;

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
            return Ok(await dbContext.Products.ToListAsync());
        }
    }
}
