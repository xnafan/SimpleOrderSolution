using RestSharp;

namespace OrderApiClient;
public class OrderApiRestClient
{
    private RestClient _client;

    public OrderApiRestClient(string baseUrl) => _client = new RestClient(baseUrl);

    public Order CreateOrder() { return _client.Post<Order>(new RestRequest()); }
    public bool UpdateOrder(int orderNumber, Order.OrderState newState)
    {
        var restRequest = new RestRequest($"{orderNumber}/state");
        restRequest.AddQueryParameter("newState", newState.ToString());
        return _client.Put<bool>( restRequest);
    }
    public IEnumerable<Order>? GetUnfinishedOrders() => _client.Get<IEnumerable<Order>>(new RestRequest());

    public IEnumerable<Order>? GetSpecificOrders(Order.OrderState state)
    {
        var restRequest = new RestRequest();
        restRequest.AddQueryParameter("orderState", state.ToString());
        return _client.Get<IEnumerable<Order>>(restRequest);
    }
}
