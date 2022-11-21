using DataAccessLayer;
using Microsoft.AspNetCore.Mvc;
using SimpleOrderWebApi.Dtos;
using SimpleOrderWebApi.Tools;

namespace SimpleOrderWebApi.Controllers;
[Route("api/[controller]")]
[ApiController]
public class OrdersController : ControllerBase
{
    IOrderProvider _orderProvider;
    public OrdersController(IOrderProvider provider) => _orderProvider = provider;

    [HttpPost]
    [Route("create")]
    public Order CreateOrder() => _orderProvider.CreateOrder();

    [HttpGet]
    public IEnumerable<OrderDto> GetUnfinishedOrders() => _orderProvider.GetUnfinishedOrders().ToDtos();

    [HttpPut]
    [Route("{orderNumber}")]
    public bool UpdateOrder(int orderNumber, string newState) => _orderProvider.UpdateOrder(orderNumber, Enum.Parse<Order.OrderState>(newState));
    
    [HttpGet]
    [Route("{state}")]
    public IEnumerable<OrderDto> GetSpecificOrders(string state) => _orderProvider.GetSpecificOrders(Enum.Parse<Order.OrderState>(state)).ToDtos();
}