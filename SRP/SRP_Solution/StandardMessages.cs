using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_Solution
{
    public class StandardMessages
    {
        public static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to my application!");
        }

        public static void EndApplication()
        {
            Console.ReadLine();
        }

        public static void ValidateMessage(string fieldName)
        {
            Console.WriteLine($"You did not enter a valid {fieldName}!!");
        }

        public static void ShowUserName(string userName)
        {
            Console.WriteLine($"Your user name is {userName}");
        }
    }
}
