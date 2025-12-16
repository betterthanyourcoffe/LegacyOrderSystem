public class EmailClient
{
    public void Send(string to, string subject, string body)
    {
        Console.WriteLine("Sending email...");
        Console.WriteLine($"To: {to}");
        Console.WriteLine($"Subject: {subject}");
        Console.WriteLine($"Body: {body}");
    }
}