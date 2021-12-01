namespace ITHS_CC_Labb2;

public interface IEmailService
{
    void SendNotificationEmail(string email, Guid id);
}