using OrderMicroservice.Models;

namespace OrderMicroservice.Repositories
{
    //Interface Segregation: Define Small Interfaces
    public interface IOrderRepository
    {
        IEnumerable<Order> GetAllOrders();
        Order GetOrderById(int id);
        void AddOrder(Order order);
    }
}
