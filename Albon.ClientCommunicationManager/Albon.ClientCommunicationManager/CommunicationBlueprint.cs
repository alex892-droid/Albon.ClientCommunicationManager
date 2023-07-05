namespace Albon.ClientCommunicationManager
{
    public class CommunicationBlueprint
    {
        public string Subject { get; set; }

        public string Body { get; set; }

        public CommunicationBlueprint(string messageSubject, string messageBody) 
        {
            this.Subject = messageSubject;
            this.Body = messageBody;
        }
    }
}
