using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnmanageCode;

namespace LSP
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager accountingManager = new Manager();
            accountingManager.FirstName = "Peter";
            accountingManager.LastName = "Parker";
            accountingManager.CalculateSalary(4);

            Employee emp = new CEO();
            emp.FirstName = "Bruce";
            emp.LastName = "Wyan";
            emp.ManagerAssign(accountingManager);
            emp.CalculateSalary(3);

            Console.WriteLine($"{emp.FirstName} 's salary is {emp.Salary}/hour");

            Console.ReadLine();

        }
    }
}
