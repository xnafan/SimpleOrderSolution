using DataAccessLayer;
using Microsoft.AspNetCore.Mvc;

namespace SimpleOrderWebApi.Controllers;
[Route("api/[controller]")]
[ApiController]
public class OrdersController : ControllerBase, IOrderProvider
{
    IOrderProvider _orderProvider;
    public OrdersController(IOrderProvider provider) => _orderProvider = provider;

    [HttpPost]
    [Route("create")]
    public Order CreateOrder() => _orderProvider.CreateOrder();

    [HttpGet]
    public IEnumerable<Order> GetUnfinishedOrders() => _orderProvider.GetUnfinishedOrders();

    [HttpPut]
    [Route("{orderNumber}")]
    public bool UpdateOrder(int orderNumber,[FromBody] Order.OrderState newState) => _orderProvider.UpdateOrder(orderNumber, newState);
    
    [HttpGet]
    [Route("{orderState}")]
    public IEnumerable<Order> GetSpecificOrders(Order.OrderState state) => _orderProvider.GetSpecificOrders(state);
}