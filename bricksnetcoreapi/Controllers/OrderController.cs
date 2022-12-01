using bricksnetcoreapi.Model;
using bricksnetcoreapi.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

namespace bricksnetcoreapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        public readonly IOrderRepository _orderRepository;


        public OrderController(IOrderRepository orderRepository)
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
        public List<Customer> GetAllCustomer()
        {
            List<Customer> customers = new List<Customer>();
            customers = _orderRepository.GetAllCustomer();
            return customers;
            
        }
    }
}
