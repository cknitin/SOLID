using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP_With_Solution
{
    public class CEO : BaseEmployee, IManager
    {
        public override void CalculateSalary(int rank)
        {
            decimal baseSalary = 29.75M;
            Salary = baseSalary + (rank * 8);
        }

        public void GeneratePerformanceReview()
        {
            Console.WriteLine("Reviewing the performance review reports.");
        }

        public void FireSomeone()
        {
            Console.WriteLine("You are Fired!");
        }
    }
}
