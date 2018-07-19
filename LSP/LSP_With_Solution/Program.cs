using LSPSolution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP_With_Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager accountingManager = new Manager();
            accountingManager.FirstName = "Peter";
            accountingManager.LastName = "Parker";
            accountingManager.CalculateSalary(4);

            IManaged emp = new Employee();
            emp.FirstName = "Bruce";
            emp.LastName = "Wyan";
            emp.AssignManager(accountingManager);
            emp.CalculateSalary(3);

            Console.WriteLine($"{emp.FirstName} 's salary is {emp.Salary}/hour");

            Console.ReadLine();


        }
    }
}
