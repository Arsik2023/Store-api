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
                    ErrorMessages = { "Неверный id" }
                });
            }
            var product = await dbContext.Products.FirstOrDefaultAsync(x => x.Id == id);
            if (product == null)
            {
                return NotFound(new ResponseServer
                {
                    StatusCode = HttpStatusCode.NotFound,
                    IsSucces = false,
                    ErrorMessages = { "Продукт по указанному id не найден" }
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
                            IsSucces = false,
                            StatusCode = HttpStatusCode.BadRequest,
                            ErrorMessages = { "Image не может быть пустым" }
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
                            Image = $"https://placehold.co/250"
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
                        ErrorMessages = { "Модель данных не подходит" }
                    });
                }
            }
            catch (Exception ex)
            {
                return BadRequest(new ResponseServer
                {
                    IsSucces = false,
                    StatusCode = HttpStatusCode.BadRequest,
                    ErrorMessages = { "Что-то поломалось", ex.Message }
                });
            }
        }

        [HttpPut]
        public async Task<ActionResult<ResponseServer>> UpdateProduct(
            int id, [FromBody] ProductUpdateDto productUpdateDto
        )
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (productUpdateDto == null
                    || productUpdateDto.Id != id)
                    {
                        return BadRequest(new ResponseServer
                        {
                            IsSucces = false,
                            StatusCode = HttpStatusCode.BadRequest,
                            ErrorMessages = { "Несоответствие модели данных" }
                        });
                    }
                    else
                    {
                        Product productFromDb = await dbContext
                            .Products
                            .FindAsync(id);

                        if (productFromDb == null)
                        {
                            return NotFound(new ResponseServer
                            {
                                IsSucces = false,
                                StatusCode = HttpStatusCode.NotFound,
                                ErrorMessages = { "Продукт с таким id не найден" }
                            });
                        }
                        productFromDb.Name = productUpdateDto.Name;
                        productFromDb.Description = productUpdateDto.Description;
                        productFromDb.SpecialTag = productUpdateDto.SpecialTag;
                        productFromDb.Category = productUpdateDto.Category;
                        productFromDb.Price = productUpdateDto.Price;

                        if (productUpdateDto.Image != null
                            && productUpdateDto.Image.Length > 0)
                        {
                            productFromDb.Image = $"https://placehold.co/300";
                        }

                        dbContext.Products.Update(productFromDb);
                        await dbContext.SaveChangesAsync();

                        return Ok(new ResponseServer
                        {
                            StatusCode = HttpStatusCode.OK,
                            Result = productFromDb
                        });
                    }
                }
                else
                {
                    return BadRequest(new ResponseServer
                    {
                        IsSucces = false,
                        StatusCode = HttpStatusCode.BadRequest,
                        ErrorMessages = { "Модель данных не подходит" }
                    });
                }
            }
            catch (Exception ex)
            {
                return BadRequest(new ResponseServer
                {
                    IsSucces = false,
                    StatusCode = HttpStatusCode.BadRequest,
                    ErrorMessages = { "Что-то пошло не так", ex.Message }
                });
            }
        }

        [HttpDelete]
        public async Task<ActionResult<ResponseServer>> RemoveProductById(int id)
        {
            try
            {
                if (id <= 0)
                {
                    return BadRequest(new ResponseServer
                    {
                        IsSucces = false,
                        StatusCode = HttpStatusCode.BadRequest,
                        ErrorMessages = { "Неверный id" }
                    });
                }
                Product productFromDb = await dbContext.Products.FindAsync(id);

                if (productFromDb == null)
                {
                    return NotFound(new ResponseServer
                    {
                        IsSucces = false,
                        StatusCode = HttpStatusCode.NotFound,
                        ErrorMessages = { "Продукт по указанному id не найден" }
                    });
                }

                dbContext.Products.Remove(productFromDb);
                await dbContext.SaveChangesAsync();

                return Ok(new ResponseServer
                {
                    IsSucces = true,
                    StatusCode = HttpStatusCode.NoContent
                });
            }
            catch (Exception ex)
            {
                return BadRequest(new ResponseServer
                {
                    IsSucces = false,
                    StatusCode = HttpStatusCode.BadRequest,
                    ErrorMessages = { "Всё плохо", ex.Message }
                });
            }
        }
    }
}
