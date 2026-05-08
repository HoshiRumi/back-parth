using eDomain.mModels.mOrder;
using eMiSide.BusinessLogic.mInterfaces;
using Microsoft.AspNetCore.Mvc;

namespace eMiSide.Api.Controller
{
    [Route("api/order")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private IOrderActions _orderActions;
        public OrderController()
        {
            var bl = new BusinessLogic.BusinessLogic();
            _orderActions = bl.GetOrderActions();
        }

        [HttpGet("{userId}/all")]
        public IActionResult GetUserOrdersById(int userId)
        {
            var orders = _orderActions.GetUserOrdersByIdAction(userId);
            return Ok(orders);
        }

        [HttpGet("{id}")]
        public IActionResult GetOrderById(int id)
        {
            var order = _orderActions.GetOrderByIdAction(id);
            if (order != null)
                return Ok(order);
            return NotFound(new { Message = $"Order with ID {id} not found" });
        }

        [HttpPut("{id}/status")]
        public IActionResult UpdateOrderStatus(int id, [FromQuery] string newStatus)
        {
            var order = _orderActions.UpdateOrderStatusAction(id, newStatus);
            if (order != null)
                return Ok(order);
            return NotFound(new { Message = $"Order with ID {id} not found" });
        }

        [HttpPost]
        public IActionResult CreateOrder([FromBody] OrderDto order)
        {
            var created = _orderActions.CreateOrderAction(order);
            return Created($"api/order/{created.Id}", created);
        }
    }
}