using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP_Solution
{
    public class SMSSender : IMessageSender
    {
        public void SendMessage(IPerson person, string message)
        {
            Console.WriteLine($"SMS Sending {message} to {person.PhoneNumber}");

        }
    }
}
