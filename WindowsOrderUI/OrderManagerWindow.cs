using OrderApiClient;
using System.Diagnostics;

namespace WindowsOrderUI;

public partial class OrderManagerWindow : Form
{
    //OrderApiRestClient _restClient = new OrderApiRestClient("https://localhost:7071/api/orders");
    OrderApiRestClient _restClient = new OrderApiRestClient("https://orders.codesamples.dk/api/orders");
    public OrderManagerWindow() => InitializeComponent();

    private void Form1_Load(object sender, EventArgs e)
    {
        RefreshOrdersList();

        //set up event handling
        lnkLblWebsite.Click += (_, _) => OpenWebSite();
        picQRcode.Click += (_, _) => OpenWebSite();

        btnCreateOrder.Click    += (_, _) => CreateNewOrder();
        btnSetOrderReady.Click += (_, _) => ChangeSelectedOrderState(Order.OrderState.ReadyForPickup);
        btnSetOrderPickedUp.Click += (_, _) => ChangeSelectedOrderState(Order.OrderState.PickedUp); 
        lstOrders.Click += (_, _) => RefreshUi();

        KeyDown += (_, e) => HandleKey(e.KeyCode);
    }

    private void HandleKey(Keys keyCode)
    {
        if (keyCode== Keys.R) { ChangeSelectedOrderState(Order.OrderState.ReadyForPickup); }
        else if (keyCode== Keys.P) { ChangeSelectedOrderState(Order.OrderState.PickedUp); }
        else if (keyCode== Keys.B) { ChangeSelectedOrderState(Order.OrderState.BeingPrepared); }
        else if (keyCode== Keys.Delete) { ChangeSelectedOrderState(Order.OrderState.PickedUp); }
        else if (keyCode== Keys.Down)
        {
            if (lstOrders.SelectedIndex < lstOrders.Items.Count - 1) { lstOrders.SelectedIndex++; }
        }
        else if (keyCode== Keys.Up)
        {
            if (lstOrders.SelectedIndex > 0) { lstOrders.SelectedIndex--; }
        }
    }

    private void CreateNewOrder()
    {
        _restClient.CreateOrder();
        RefreshOrdersList();
    }

    private void RefreshOrdersList()
    {
        var selectedIndex = lstOrders.SelectedIndex;
        lstOrders.Items.Clear();
        _restClient.GetUnfinishedOrders()?.ToList().ForEach(order => lstOrders.Items.Add(order));
        if (selectedIndex > lstOrders.Items.Count - 1) { selectedIndex = lstOrders.Items.Count - 1; }
        lstOrders.SelectedIndex = selectedIndex;
        RefreshUi();
    }

    private void RefreshUi() => btnSetOrderPickedUp.Enabled = btnSetOrderReady.Enabled = lstOrders.SelectedIndex > -1;

    private void ChangeSelectedOrderState(Order.OrderState newState)
    {
        if (lstOrders.SelectedIndex == -1) { return; }
        var selectedOrder = (Order)lstOrders.SelectedItem;
        _restClient.UpdateOrder(selectedOrder.OrderNumber, newState);
        RefreshOrdersList();
    }    
    private void OpenWebSite()
    {
        Process.Start(new ProcessStartInfo(lnkLblWebsite.Text) { UseShellExecute = true });
    }
}