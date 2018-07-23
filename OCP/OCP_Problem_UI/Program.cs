using OCP_Problem_Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_Problem_UI
{
    class Program
    {
        static void Main(string[] args)
        {
            List<PersonModel> applicants = new List<PersonModel>
            {
                new PersonModel{ FirstName="Bruce", LastName="Wyan" },
                new PersonModel{ FirstName="Peter", LastName="Parker" },
                new PersonModel{ FirstName="Tony", LastName="Stark" },
            };

            List<EmployeeModel> Employees = new List<EmployeeModel>();

            Accounts accountProcessor = new Accounts();

            foreach (var person in applicants)
            {
                Employees.Add(accountProcessor.Create(person));
            }

            foreach (var emp in Employees)
            {
                Console.WriteLine($"{emp.FirstName} {emp.LastName}: {emp.EmailAddress}");
            }

            Console.ReadLine();
        }
    }
}
