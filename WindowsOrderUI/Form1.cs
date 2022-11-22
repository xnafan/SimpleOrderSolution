using OrderApiClient;

namespace WindowsOrderUI;

public partial class Form1 : Form
{
    OrderApiRestClient _restClient = new OrderApiRestClient("https://localhost:7071/api/orders");
    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        RefreshOrdersList();
    }

    private void btnCreateOrder_Click(object sender, EventArgs e)
    {
        _restClient.CreateOrder();
        RefreshOrdersList();
    }

    private void RefreshOrdersList()
    {
        var selectedIndex = lstOrders.SelectedIndex;
        lstOrders.Items.Clear();
        _restClient.GetUnfinishedOrders()?.ToList().ForEach(order => lstOrders.Items.Add(order));
        if(selectedIndex > lstOrders.Items.Count -1) { selectedIndex = lstOrders.Items.Count - 1; }
        lstOrders.SelectedIndex = selectedIndex;
        RefreshUi();
    }

    private void RefreshUi()
    {
            btnSetOrderPickedUp.Enabled = btnSetOrderReady.Enabled = lstOrders.SelectedIndex > -1;
    }

    private void LstOrders_SelectedIndexChanged(object sender, EventArgs e) => RefreshUi();

    private void btnSetOrderReady_Click(object sender, EventArgs e)
    {
        ChangeSelectedOrderState(Order.OrderState.ReadyForPickup);
    }

    private void ChangeSelectedOrderState(Order.OrderState newState)
    {
        var selectedOrder = (Order)lstOrders.SelectedItem;
        _restClient.UpdateOrder(selectedOrder.OrderNumber, newState);
        RefreshOrdersList();
    }

    private Order? FindOrderInListByOrderNumber(int orderNumber)
    {
        foreach (Order order in lstOrders.Items)
        {
            if(order.OrderNumber == orderNumber) { return order; }
        }
        return null;
    }

    private void btnSetOrderPickedUp_Click(object sender, EventArgs e)
    {
        ChangeSelectedOrderState(Order.OrderState.PickedUp);
    }
}
