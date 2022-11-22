using DataAccessLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace SimpleOrderWebApi.Controllers;
[Route("api/[controller]")]
[ApiController]
public class OrdersController : ControllerBase
{
    IOrderProvider _orderProvider;
    IHubContext<OrderHub> _orderHubContext;
    public OrdersController(IOrderProvider provider, IHubContext<OrderHub> orderHubContext)
    {
        _orderProvider = provider;
        _orderHubContext = orderHubContext;
    }

    [HttpPost]
    [Route("create")]
    public async Task<Order> CreateOrder()
    {
        var createdOrder = _orderProvider.CreateOrder();
        await _orderHubContext.Clients.All.SendCoreAsync("receiveOrders", _orderProvider.GetUnfinishedOrders().ToArray());
        return createdOrder;
    }

    [HttpGet]
    public IEnumerable<Order> GetUnfinishedOrders() => _orderProvider.GetUnfinishedOrders();

    [HttpPut]
    [Route("{orderNumber}")]
    public bool UpdateOrder(int orderNumber,[FromBody] Order.OrderState newState) => _orderProvider.UpdateOrder(orderNumber, newState);
    
    [HttpGet]
    [Route("{orderState}")]
    public IEnumerable<Order> GetSpecificOrders(Order.OrderState state) => _orderProvider.GetSpecificOrders(state);
}