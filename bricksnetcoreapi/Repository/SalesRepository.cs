using bricksnetcoreapi.Model;
using bricksnetcoreapi.Models;
using bricksnetcoreapi.Models.dtos;
using System.Collections.Generic;

namespace bricksnetcoreapi.Repository
{
    public class SalesRepository : ISalesRepository
    {
       
        public  OrderModel GetAllOrders()
        {
            BricksBizBdContext _context = new BricksBizBdContext();
            OrderModel orderModel = new OrderModel();
            orderModel.orders = _context.Orders.ToList();

            return orderModel;

        }

        public bool PlaceOrder(OrderDTO order)
        {
            if (order != null)
            {
                TblOrder tblOrder = new TblOrder();
                tblOrder.OrderId = order.OrderId;
                tblOrder.OrderCode = order.OrderCode;
                tblOrder.Qty = order.Qty;
                tblOrder.Rate = order.Rate;
                tblOrder.Total = order.Qty * order.Rate;
                tblOrder.Status = order.Status;

                BricksBizBdContext bizBdContext = new BricksBizBdContext();
                bizBdContext.Add(tblOrder);
                bizBdContext.SaveChanges();
                return true;
            }
            return false;
        }

        public bool UpdateOrder(OrderDTO order)
        {
            throw new NotImplementedException();
        }
    }
}
