public class OrderRepository
{
    public void Save(Order order)
    {
        Console.WriteLine("Saving order...");
        Console.WriteLine($"UserId: {order.UserId}");
        Console.WriteLine($"Total: {order.Total}");
        Console.WriteLine($"CreatedAt: {order.CreatedAt}");
    }
}