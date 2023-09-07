using Church.Email.Models;
namespace Church.Email.Servise
{
    public interface IEmailServise
    {
        void SendEmail(EmailMessage message);
    }
}
