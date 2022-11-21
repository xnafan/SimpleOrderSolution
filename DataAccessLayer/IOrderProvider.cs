namespace DataAccessLayer;
public interface IOrderProvider
{
    Order CreateOrder();
    bool UpdateOrder(int orderNumber, Order.OrderState newState);
    IEnumerable<Order> GetUnfinishedOrders();
    IEnumerable<Order> GetSpecificOrders(Order.OrderState state);
}