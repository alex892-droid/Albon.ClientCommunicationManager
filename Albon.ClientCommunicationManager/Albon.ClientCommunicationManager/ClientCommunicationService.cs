namespace Albon.ClientCommunicationManager
{
    public class ClientCommunicationService
    {
        public IEmailSenderService EmailSenderService { get; set; }

        public ClientCommunicationService(IEmailSenderService emailSenderService)
        {
            EmailSenderService = emailSenderService;
        }

        public void SendCommunication(Receiver receiver, CommunicationBlueprint communication, CommunicationType communicationType)
        {
            switch (communicationType)
            {
                case CommunicationType.Email:
                    EmailSenderService.SendEmail(receiver.EmailAddress, communication.Subject, communication.Body);
                    break;
            }
        }

        public void SendCommunication(Receiver receiver, CommunicationBlueprint communication)
        {
            foreach(var communicationType in Enum.GetValues(typeof(CommunicationType)).OfType<CommunicationType>())
            {
                switch (communicationType)
                {
                    case CommunicationType.Email:
                        EmailSenderService.SendEmail(receiver.EmailAddress, communication.Subject, communication.Body);
                        break;
                }
            }
        }
    }
}
