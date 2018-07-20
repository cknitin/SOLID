using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP_Problem
{
    public class Manager: Employee
    {
        public override void CalculateSalary(int rank)
        {
            decimal baseSalary = 19.75M;
            Salary = baseSalary + (rank * 4);
        }

        public  void GeneratePerformaceReview()
        {
            Console.WriteLine("I am reviewing direct report.");
        }
    }
}
