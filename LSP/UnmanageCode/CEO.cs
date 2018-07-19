using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnmanageCode
{
    public class CEO: Employee
    {
        public override void CalculateSalary(int rank)
        {
            decimal baseSalary = 29.75M;
            Salary = baseSalary + (rank * 8);
        }

        public override void ManagerAssign(Employee manager)
        {
            throw new InvalidOperationException("CEO has no manager.");
        }

        public void GeneratePerformaceReview()
        {
            Console.WriteLine("I am reviewing direct report of performance.");
        }

        public  void FireSomeone()
        {
            Console.WriteLine("You are Fired!");
        }
    }
}
