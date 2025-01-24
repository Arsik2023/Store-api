using System.Net;
using Api;
using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    public class OrderController : StoreController
    {
        private readonly OrdersService ordersService;

        public OrderController(AppDbContext dbContext, OrdersService ordersService)
            : base(dbContext)
        {
            this.ordersService = ordersService;
        }

        [HttpPost]
        public async Task<ActionResult<ResponseServer>> CreateOrder(
            [FromBody] OrderHeaderCreateDto orderHeaderCreateDto
        )
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new ResponseServer
                {
                    IsSucces = false,
                    StatusCode = HttpStatusCode.BadRequest,
                    ErrorMessages = { "Неверное состояние модели заказа" }
                });
            }

            try
            {
                var order = await ordersService.CreateOrderAsync(orderHeaderCreateDto);

                return Ok(new ResponseServer
                {
                    StatusCode = HttpStatusCode.Created,
                    Result = order
                });
            }
            catch (Exception ex)
            {
                return BadRequest(new ResponseServer
                {
                    IsSucces = false,
                    StatusCode = HttpStatusCode.BadRequest,
                    ErrorMessages = { "Невероятная ошибка", ex.Message }
                });
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ResponseServer>> GetOrder(int id)
        {
            if (id <= 0)
            {
                return BadRequest(new ResponseServer
                {
                    IsSucces = false,
                    StatusCode = HttpStatusCode.BadRequest,
                    ErrorMessages = { "Неверный идентификатор заказа" }
                });
            }

            try
            {
                var orderHeader = await ordersService.GetOrderByIdAsync(id);

                if (orderHeader == null)
                {
                    return NotFound(new ResponseServer
                    {
                        IsSucces = false,
                        StatusCode = HttpStatusCode.NotFound,
                        ErrorMessages = { "Заказ не найден" }
                    });
                }

                return Ok(new ResponseServer
                {
                    StatusCode = HttpStatusCode.OK,
                    Result = orderHeader
                });
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

        [HttpGet]
        public async Task<ActionResult<ResponseServer>> GetOrdersByUserId(string userId)
        {
            try
            {
                var orderHeaders = await ordersService.GetOrderByUserIdAsync(userId);

                return Ok(new ResponseServer
                {
                    StatusCode = HttpStatusCode.OK,
                    Result = orderHeaders
                });
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError,
                new ResponseServer
                {
                    IsSucces = false,
                    StatusCode = HttpStatusCode.InternalServerError,
                    ErrorMessages = { "При обработке возникла проблема", ex.Message }
                });
            }
        }
        [HttpPut("{id}")]
        public async Task<ActionResult<ResponseServer>> UpdateOrderHeader(
            int id, [FromBody] OrderHeaderUpdateDto orderHeaderUpdateDto
        )
        {
            try
            {
                var success = await ordersService
                    .UpdateOrderHeaderAsync(id, orderHeaderUpdateDto);

                if (!success)
                {
                    return BadRequest(new ResponseServer
                    {
                        IsSucces = false,
                        StatusCode = HttpStatusCode.BadRequest,
                        ErrorMessages = { "Обновление пошло не по плану" }
                    });
                }

                return Ok(new ResponseServer
                {
                    StatusCode = HttpStatusCode.OK,
                    Result = new { Results = true, Text = "Всё обновлено" }
                });
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError,
                    new ResponseServer
                    {
                        IsSucces = false,
                        StatusCode = HttpStatusCode.InternalServerError,
                        ErrorMessages = { "При обновлении проблема", ex.Message }
                    });
            }
        }
    }
}


