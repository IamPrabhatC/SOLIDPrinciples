using OrderMicroservice.Models;

namespace OrderMicroservice.Repositories
{
    public class OrderRepository: IOrderRepository
    {
        private readonly List<Order> _orders = new() { new Order() { Id = 1, ProductName = "Product1" ,Quantity =2} };

        public IEnumerable<Order> GetAllOrders() => _orders;
        public Order GetOrderById(int id) => _orders.FirstOrDefault(o => o.Id == id);
        public void AddOrder(Order order) => _orders.Add(order);
    }
}
