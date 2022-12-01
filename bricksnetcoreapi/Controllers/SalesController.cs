using bricksnetcoreapi.Model;
using bricksnetcoreapi.Models;
using bricksnetcoreapi.Models.dtos;
using bricksnetcoreapi.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace bricksnetcoreapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesController : ControllerBase
    {
        private readonly ISalesRepository _salesRepository;
        public SalesController(ISalesRepository salesRepository)
        {
            _salesRepository = salesRepository;
        }


        [HttpGet]
        [Route("getorders")]
        public IActionResult GetAllOrders()
        {
            OrderModel orderModel = new OrderModel();
            orderModel = _salesRepository.GetAllOrders();
            return Ok(orderModel);
        }

        [HttpPost]
        [Route("placeorder")]
        public IActionResult PlaceOrder(OrderDTO order)
        {
            var result = _salesRepository.PlaceOrder(order);
            return Ok(result);
        }
    }
}
