using bricksnetcoreapi.Model;
using Microsoft.EntityFrameworkCore;

namespace bricksnetcoreapi.Repository
{
    public class CustomerOrderRepository : ICustomerOrderRepository
    {
        private DbContext _context;
        public CustomerOrderRepository(DbContext context) 
        {
            _context = context;
        }

        public Task<bool> DeleteOrder(CustomerOrder order)
        {
            throw new NotImplementedException();
        }

        public Task<CustomerOrder> GetOrderByOrderId(string id)
        {
            throw new NotImplementedException();
        }

        public Task<List<CustomerOrder>> GetOrdersList()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task<bool> PlaceOrder(CustomerOrder order)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateOrder(CustomerOrder order)
        {
            throw new NotImplementedException();
        }
    }
}
