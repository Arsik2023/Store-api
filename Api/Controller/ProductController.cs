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

        [HttpGet]
        public async Task<IActionResult> GetProductById(int id)
        {
            if (id <= 0)
            {
                return BadRequest(new ResponseServer
                {
                    StatusCode = HttpStatusCode.BadRequest,
                    IsSucces = false,
                    ErrorMessage = { "Неверный id" }
                });
            }
            var product = await dbContext.Products.FirstOrDefaultAsync(x => x.Id == id);
            if (product == null)
            {
                return NotFound(new ResponseServer
                {
                    StatusCode = HttpStatusCode.NotFound,
                    IsSucces = false,
                    ErrorMessage = { "Продукт по указанному id не найден" }
                }
                );
            }
            else
            {
                return Ok(new ResponseServer
                {
                    StatusCode = HttpStatusCode.OK,
                    Result = product
                });
            }

        }
    }
}
