using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPSolution
{
    public class BaseEmployee : IEmployee 
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Salary { get; set; }

        public virtual void CalculateSalary(int rank)
        {
            decimal baseSalary = 12.50M;
            Salary = baseSalary + (rank * 2);
        }
    }
}
