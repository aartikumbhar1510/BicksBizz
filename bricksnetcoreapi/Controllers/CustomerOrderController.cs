using bricksnetcoreapi.Model;
using bricksnetcoreapi.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace bricksnetcoreapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerOrderController : ControllerBase
    {
        public readonly ICustomerOrderRepository _orderRepository;
        public readonly IConfiguration _configuration;

        public CustomerOrderController(ICustomerOrderRepository orderRepository, IConfiguration configuration)
        {
            _orderRepository = orderRepository;
            _configuration = configuration;
        }

        [HttpGet]
        [Route("getorderbyid")]
        public Task<IActionResult> GetOrderByOrderId(string orderId)
        {
            dynamic result = _orderRepository.GetOrderByOrderId(orderId);
            return Ok(result);
        }
    }
}
