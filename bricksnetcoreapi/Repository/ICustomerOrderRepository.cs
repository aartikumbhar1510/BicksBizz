using bricksnetcoreapi.Model;

namespace bricksnetcoreapi.Repository
{
    public interface ICustomerOrderRepository
    {
        Task<bool> PlaceOrder(CustomerOrder order);
        Task<bool> UpdateOrder(CustomerOrder order);
        Task<bool> DeleteOrder(CustomerOrder order);
        Task<CustomerOrder> GetOrderByOrderId(string id);
        Task<List<CustomerOrder>> GetOrdersList();
    }
}
