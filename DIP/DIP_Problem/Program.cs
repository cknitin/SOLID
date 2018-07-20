using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            Person owner = new Person()
            {
                FirstName = "Bruce",
                LastName = "Wyan",
                Email = "bruce@wyan.com",
                PhoneNumber = "555-454-999"
            };

            Chore chore = new Chore()
            {
                ChoreName = "Take out the trash",
                Owner = owner
            };

            chore.PerformedWork(5);
            chore.PerformedWork(1);
            chore.CompletedChore();
            
            Console.ReadLine();
        }
    }
}
