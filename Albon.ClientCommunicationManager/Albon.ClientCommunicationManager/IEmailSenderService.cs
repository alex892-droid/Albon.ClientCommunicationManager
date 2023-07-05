using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Albon.ClientCommunicationManager
{
    public interface IEmailSenderService
    {
        public void SendEmail(string emailAddress, string subject, string body);
    }
}
