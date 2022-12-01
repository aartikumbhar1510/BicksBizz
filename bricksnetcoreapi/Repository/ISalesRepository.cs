using bricksnetcoreapi.Model;
using bricksnetcoreapi.Models;
using bricksnetcoreapi.Models.dtos;

namespace bricksnetcoreapi.Repository
{
    public interface ISalesRepository
    {
        OrderModel GetAllOrders();
        bool PlaceOrder(OrderDTO order);
        bool UpdateOrder(OrderDTO order);


    }
}
