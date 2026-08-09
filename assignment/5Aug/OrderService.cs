using _5_July.Data;
using _5_July.Models;
using _5_July.Repository;

namespace _5_July.Services
{
    public class OrderService:IOrderService
    {
        private readonly AppDbContext context;
        public OrderService(AppDbContext context)
        {
            this.context = context; 
        }
        public List<Order> GetOrders()
        {
            return context.Orders.ToList();
        }
        public Order GetOrder(int id)
        {
            return context.Orders.Find(id);
        }
        public void UpdateOrder( Order order)
        {

            context.Orders.Update(order);
            context.SaveChanges();  
        }


        public void DeleteOrder(int id)
        {
            var ord = context.Orders.Find(id);

            if (ord != null)
            {
                context.Orders.Remove(ord);
                context.SaveChanges();
            }
        }
    }



    }

