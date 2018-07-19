using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPSolution
{
    public class Manager : Employee, IManager
    {
        public override void CalculateSalary(int rank)
        {
            decimal baseSalary = 19.75M;
            Salary = baseSalary + (rank * 4);
        }

        public void GeneratePerformanceReview()
        {
            Console.WriteLine("Generating performance review reports.");
        }
    }
}
