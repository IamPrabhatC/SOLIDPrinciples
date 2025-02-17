using OrderMicroservice.Models;

namespace OrderMicroservice.Services
{
    // Open/Closed Principle: Extendable Services
    public interface IOrderService
    {
        IEnumerable<Order> GetOrders();
        Order GetOrder(int id);
        void CreateOrder(Order order);
    }
}
