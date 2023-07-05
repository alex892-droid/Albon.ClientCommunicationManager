namespace Albon.ClientCommunicationManager
{
    public class Receiver
    {
        public string EmailAddress { get; set; }

        public Receiver(string email)
        {
            EmailAddress = email;
        }
    }
}
