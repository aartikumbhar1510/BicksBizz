using bricksnetcoreapi.Model;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;
using System.Data;
using Microsoft.Extensions.Configuration;
using bricksnetcoreapi.Common;

namespace bricksnetcoreapi.Repository
{
    public class CustomerOrderRepository : ICustomerOrderRepository
    {
        private readonly IConfiguration _configuration;
        private readonly string _connectionString = string.Empty;
        public CustomerOrderRepository(IConfiguration configuration,string connectionString) 
        {
            _configuration = configuration;
            _connectionString = _connectionString!=null? _configuration.GetConnectionString("BricksdbConn").ToString():connectionString.ToString();
        }

        public Task<bool> DeleteOrder(CustomerOrder order)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAllCustomer()
        {
            List<Customer> customers = new List<Customer>();

            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                SqlCommand cmd = new SqlCommand(Constant.GET_ALL_CUSTOMER, con);
                cmd.CommandType = CommandType.StoredProcedure;

                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Customer customer = new Customer();

                    customer.CustomerId = Convert.ToInt32(rdr["id"]);
                    customer.CustomerName = rdr["name"].ToString();
                    customer.CustomerContact = rdr["contact"].ToString();
                    customer.CustomerAddress = rdr["address"].ToString();
                    customer.CustomerStatus = rdr["status"].ToString();

                    customers.Add(customer);
                }
                con.Close();
            }
            return customers;
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
