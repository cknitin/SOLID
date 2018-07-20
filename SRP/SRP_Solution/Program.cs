using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            StandardMessages.WelcomeMessage();

            Person user = PersonCaptureData.Capture();


            bool isUserValid = PersonValidator.ValidateFirstName(user);

            if (!isUserValid)
            {
                StandardMessages.EndApplication();
                return;
            }

            string userName = AccountGenerator.GenerateUserName(user);
            StandardMessages.ShowUserName(userName);

            StandardMessages.EndApplication();
        }

    }
}
