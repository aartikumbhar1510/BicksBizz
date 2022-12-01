using bricksnetcoreapi.Model;

namespace bricksnetcoreapi.Repository
{
    public interface IOrderRepository
    {
        Task<bool> PlaceOrder(OrderModel order);
        Task<bool> UpdateOrder(OrderModel order);
        Task<bool> DeleteOrder(OrderModel order);
        Task<OrderModel> GetOrderByOrderId(string id);
        Task<List<OrderModel>> GetOrdersList();
        List<CustomerModel> GetAllCustomer();
    }
}
