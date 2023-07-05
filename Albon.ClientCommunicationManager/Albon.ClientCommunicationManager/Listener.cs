using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
