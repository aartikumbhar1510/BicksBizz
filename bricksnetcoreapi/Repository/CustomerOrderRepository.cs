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
        public CustomerOrderRepository(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = _configuration.GetConnectionString("BricksdbConn").ToString();
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
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable ds = new DataTable();
                sda.Fill(ds);
                for (int i = 0; i < ds.Rows.Count; i++)
                {
                    Customer customer = new Customer();
                    customer.CustomerId = Convert.ToInt32(ds.Rows[i]["customer_id"]);
                    customer.CustomerName = ds.Rows[i]["customer_name"].ToString();
                    customer.CustomerContact = ds.Rows[i]["customer_contact"].ToString();
                    customer.CustomerAddress = ds.Rows[i]["customer_address"].ToString();
                    customer.CustomerStatus = ds.Rows[i]["customer_status"].ToString();
                    customers.Add(customer);
                }

                con.Close();
            }

            return customers.ToList();
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
        /// <param name = "order"></param>
        /// <returns></returns>
        /// <exception cref = "NotImplementedException"></exception>
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