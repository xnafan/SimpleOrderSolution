using DataAccessLayer;
using Microsoft.AspNetCore.SignalR;

namespace SimpleOrderWebApi;
public class OrderHub : Hub
{
    IOrderProvider _orderProvider;
    public OrderHub(IOrderProvider orderProvider) => _orderProvider = orderProvider;
    public async Task SignalOrderChange() => await Clients.All.SendAsync("receiveOrders", _orderProvider.GetUnfinishedOrders());
}