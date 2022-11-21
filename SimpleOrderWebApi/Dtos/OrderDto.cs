using DataAccessLayer;
using System.Text.Json.Serialization;

namespace SimpleOrderWebApi.Dtos;

public class OrderDto
{
    public int OrderNumber { get; set; }
    public DateTime OrderPlacedTimestamp { get; set; } = DateTime.Now;

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public string State { get; set; } = Order.OrderState.BeingPrepared.ToString();

    public OrderDto(){}
    public OrderDto(Order order)
    {
        OrderNumber = order.OrderNumber;
        OrderPlacedTimestamp = order.OrderPlacedTimestamp;
        State = order.State.ToString();
    }
}