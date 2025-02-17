using Microsoft.AspNetCore.Mvc;
using OrderMicroservice.Models;
using OrderMicroservice.Services;

namespace OrderMicroservice.Controllers;

[ApiController]
[Route("api/orders")]
public class OrderController : ControllerBase
{
    private readonly IOrderService _orderService;

    public OrderController(IOrderService orderService)
    {
        _orderService = orderService;
    }

    [HttpGet]
    public IActionResult GetOrders() => Ok(_orderService.GetOrders());

    [HttpGet("{id}")]
    public IActionResult GetOrder(int id)
    {
        var order = _orderService.GetOrder(id);
        return order != null ? Ok(order) : NotFound();
    }

    [HttpPost]
    public IActionResult CreateOrder([FromBody] Order order)
    {
        _orderService.CreateOrder(order);
        return CreatedAtAction(nameof(GetOrder), new { id = order.Id }, order);
    }
}
