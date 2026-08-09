using _5_July.Models;

namespace _5_July.Repository
{
    public interface IOrderService
    {
        List<Order> GetOrders();
        Order GetOrder(int id);
        void UpdateOrder(Order order);

        void DeleteOrder(int id);   

    }
}
