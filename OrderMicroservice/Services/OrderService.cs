using OrderMicroservice.Models;
using OrderMicroservice.Repositories;

namespace OrderMicroservice.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public IEnumerable<Order> GetOrders() => _orderRepository.GetAllOrders();
        public Order GetOrder(int id) => _orderRepository.GetOrderById(id);
        public void CreateOrder(Order order) => _orderRepository.AddOrder(order);
    }
}
