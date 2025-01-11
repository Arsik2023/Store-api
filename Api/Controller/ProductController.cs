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

        [HttpGet("{id}", Name = nameof(GetProductById))]
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
        [HttpPost]
        public async Task<ActionResult<ResponseServer>> CreateProduct(
            [FromBody] ProductCreateDto productCreateDto
        )
        {
            try
            {
                if (ModelState.IsValid) // проверка правильности переданной модели 
                {
                    if (productCreateDto.Image == null
                    || productCreateDto.Image.Length == 0)
                    {
                        return BadRequest(new ResponseServer
                        {
                            StatusCode = HttpStatusCode.BadRequest,
                            IsSucces = false,
                            ErrorMessage = { "Image не может быть пустым" }
                        });
                    }
                    else
                    {
                        Product item = new()
                        {
                            Name = productCreateDto.Name,
                            Description = productCreateDto.Description,
                            SpecialTag = productCreateDto.SpecialTag,
                            Category = productCreateDto.Category,
                            Price = productCreateDto.Price,
                            Image = $"https://placehold.co/200"
                        };

                        await dbContext.Products.AddAsync(item);
                        await dbContext.SaveChangesAsync();
                        ResponseServer response = new()
                        {
                            StatusCode = HttpStatusCode.Created,
                            Result = item
                        };
                        return CreatedAtRoute(nameof(GetProductById), new { id = item.Id }, response);
                    }
                }
                else
                {
                    return BadRequest(new ResponseServer
                    {
                        StatusCode = HttpStatusCode.BadRequest,
                        IsSucces = false,
                        ErrorMessage = { "Модель данных не подходит" }
                    });
                }
            }
            catch (Exception ex)
            {
                return BadRequest(new ResponseServer
                {
                    StatusCode = HttpStatusCode.BadRequest,
                    IsSucces = false,
                    ErrorMessage = { "Что-то поломалось", ex.Message }
                });
            }
        }
    }
}
