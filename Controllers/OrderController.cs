using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/orders")]
public class OrderController : ControllerBase
{
    [HttpPost("place")]
    public IActionResult PlaceOrder([FromBody] PlaceOrderRequest request)
    {
        var service = new OrderService();
        var result = service.PlaceOrder(request.UserId, request.Items);

        if (!result)
        {
            return BadRequest("Unable to place order");
        }

        return Ok("Order placed successfully");
    }
}

public class PlaceOrderRequest
{
    public int UserId { get; set; }
    public List<OrderItem> Items { get; set; }
}