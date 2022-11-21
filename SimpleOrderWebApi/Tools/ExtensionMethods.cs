using DataAccessLayer;
using SimpleOrderWebApi.Dtos;

namespace SimpleOrderWebApi.Tools;
public static class ExtensionMethods
{
    public static OrderDto ToDto(this Order order) => new OrderDto(order);
    public static IEnumerable<OrderDto> ToDtos(this IEnumerable<Order> orders)
    {
        foreach (var order in orders)
        {
            yield return order.ToDto();
        }
    }
}