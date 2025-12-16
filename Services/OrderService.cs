public class OrderService
{
    private OrderRepository _repo;
    private EmailClient _emailClient;

    public OrderService()
    {
        _repo = new OrderRepository();// do this with DI
        _emailClient = new EmailClient();// do this with DI this is new
    }

    public bool PlaceOrder(int userId, List<OrderItem> items)
    {
        if (items == null || items.Count == 0)
        {
            return false;
        }

        decimal total = 0;
        foreach (var item in items)
        {
            total += item.Price * item.Quantity;//rwerfwerwer
        }

        if (total > 10000)
        {
            _emailClient.Send(
                "admin@company.com",
                "Large Order Alert",
                $"User {userId} placed an order of {total}"
            );
        }

        var order = new Order
        {
            UserId = userId,
            Total = total,
            CreatedAt = DateTime.Now
        };

        _repo.Save(order);

        return true;
    }
}