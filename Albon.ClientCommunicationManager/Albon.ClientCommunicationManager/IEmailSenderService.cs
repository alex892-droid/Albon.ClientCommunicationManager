namespace Albon.ClientCommunicationManager
{
    public interface IEmailSenderService
    {
        public void SendEmail(string emailAddress, string subject, string body);
    }
}
