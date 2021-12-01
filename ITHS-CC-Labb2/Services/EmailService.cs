namespace ITHS_CC_Labb2;

public class EmailService : IEmailService
{
    public void SendNotificationEmail(string email, Guid id)
    {
        Console.WriteLine($"Notification sent to email {email} for order {id}");
    }
}