using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_Solution
{
    public class PersonCaptureData
    {
        public static Person Capture()
        {
            Person user = new Person();
            Console.WriteLine("What is you r first name:");
            user.FirstName = Console.ReadLine();

            Console.WriteLine("What is you r last name:");
            user.LastName = Console.ReadLine();

            return user;
        }

    }
}
