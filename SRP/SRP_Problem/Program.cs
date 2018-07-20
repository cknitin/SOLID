using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my application!");
            Person user = new Person();

            Console.WriteLine("What is you r first name:");
            user.FirstName = Console.ReadLine();

            Console.WriteLine("What is you r last name:");
            user.LastName = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(user.FirstName))
            {
                Console.WriteLine("You did not enter a valid first name!!");
                Console.ReadLine();
                return;
            }

            if (string.IsNullOrWhiteSpace(user.LastName))
            {
                Console.WriteLine("You did not enter a valid last name!!");
                Console.ReadLine();
                return;
            }

            Console.WriteLine($"Your user name is # {user.FirstName.Substring(0,1)}{user.LastName}");
            Console.ReadLine();
        }
    }
}
