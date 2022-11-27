using bricksnetcoreapi.Model;
using bricksnetcoreapi.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

namespace bricksnetcoreapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerOrderController : ControllerBase
    {
        public readonly ICustomerOrderRepository _orderRepository;


        public CustomerOrderController(ICustomerOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
    
        }

        [HttpGet]
        [Route("getorderbyid")]
        public Task<IActionResult> GetOrderByOrderId(string orderId)
        {
            dynamic result = _orderRepository.GetOrderByOrderId(orderId);
            return Ok(result);
        }

        [HttpGet]
        [Route("getallcustomer")]
        public Task<IActionResult> GetAllCustomer()
        {
            dynamic result = _orderRepository.GetAllCustomer();
            return Ok(result);
        }
    }
}
