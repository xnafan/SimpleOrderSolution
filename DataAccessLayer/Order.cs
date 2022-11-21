namespace DataAccessLayer;

public class Order
{
    public int OrderNumber { get; set; }
    public DateTime OrderPlacedTimestamp { get; set; } = DateTime.Now;
    public OrderState State { get; set; }

    public Order(){}
    public Order(int orderNumber) => OrderNumber = orderNumber;

    public enum OrderState
    {
        BeingPrepared, ReadyForPickup, PickedUp
    }
}