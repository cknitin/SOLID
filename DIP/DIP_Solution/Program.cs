using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP_Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            IPerson owner = Factory.CreatePerson();
            owner.FirstName = "Bruce";
            owner.LastName = "Wyan";
            owner.Email = "bruce@wyan.com";
            owner.PhoneNumber = "555-454-999";


            IChore chore = Factory.CreateChore();
            chore.ChoreName = "Take out the trash";
            chore.Owner = owner;


            chore.PerformedWork(5);
            chore.PerformedWork(1);
            chore.CompletedChore();

            Console.ReadLine();
        }
    }
}
