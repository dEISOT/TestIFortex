using Microsoft.AspNetCore.Mvc;
using TestTask.Exceptions;
using TestTask.Models;
using TestTask.Services.Interfaces;

namespace TestTask.Controllers
{
    /// <summary>
    /// Orders controller.
    /// DO NOT change anything here. Use created contract and provide only needed implementation.
    /// </summary>
    [Route("api/v1/orders")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public OrdersController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        /// <summary>
        /// Returns selected order. 
        /// Selection rules are specified in Task description provided by recruiter
        /// </summary>
        [HttpGet]
        [Route("selected-order")]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> Get()
        {
            try
            {
                var order = await _orderService.GetOrderWithMaxTotalPrice();

                return Ok(order);
            }

            catch (Exception ex)
            {
                return ex switch
                {
                    OrderNotFoundException e => NotFound(),

                    _ => StatusCode(500),
                };
            }
        }

        /// <summary>
        /// Returns list of selected orders. 
        /// Selection rules are specified in Task description provided by recruiter
        /// </summary>
        [HttpGet]
        [Route("selected-orders")]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> GetOrders()
        {
            try
            {
                var order = await _orderService.GetOrders();

                return Ok(order);
            }

            catch (Exception ex)
            {
                return ex switch
                {
                    OrderNotFoundException e => NotFound(),

                    _ => StatusCode(500),
                };
            }
        }
    }
}
