using bricksnetcoreapi.Model;

namespace bricksnetcoreapi.Repository
{
    public interface IOrderRepository
    {
        Task<bool> PlaceOrder(CustomerOrder order);
        Task<bool> UpdateOrder(CustomerOrder order);
        Task<bool> DeleteOrder(CustomerOrder order);
        Task<CustomerOrder> GetOrderByOrderId(string id);
        Task<List<CustomerOrder>> GetOrdersList();
        List<Customer> GetAllCustomer();
    }
}
