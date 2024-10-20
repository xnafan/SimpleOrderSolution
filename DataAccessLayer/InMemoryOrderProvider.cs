﻿namespace DataAccessLayer;
public class InMemoryOrderProvider : IOrderProvider
{
    private int _nextOrderId = 1;
    private List<Order> _orders = new() { 
        //new Order() { OrderNumber=232, State=Order.OrderState.BeingPrepared} ,
        //new Order() { OrderNumber=432, State=Order.OrderState.ReadyForPickup},
        //new Order() { OrderNumber=88, State=Order.OrderState.BeingPrepared}
    };
    public Order CreateOrder()
    {
        var order = new Order(_nextOrderId);
        _orders.Add(order);
        _nextOrderId++;
        return order;
    }
    public IEnumerable<Order> GetSpecificOrders(Order.OrderState state)
    {
        return  _orders.Where(order => order.State == state);
    }

    public IEnumerable<Order> GetUnfinishedOrders() => _orders.Where(order => order.State != Order.OrderState.PickedUp);
    public bool UpdateOrder(int orderNumber, Order.OrderState newState)
    {
        var foundOrder = _orders.FirstOrDefault(order => order.OrderNumber == orderNumber);
        if (foundOrder == null) { return false; }

        foundOrder.State = newState;
        if (newState == Order.OrderState.PickedUp) { _orders.Remove(foundOrder); }
        return true;
    }
}