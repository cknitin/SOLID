using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP_Problem
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Employee Manager { get; set; }
        public decimal Salary { get; set; }


        public virtual void ManagerAssign(Employee manager)
        {
            this.Manager = manager;
        }

        public virtual void CalculateSalary(int rank)
        {
            decimal baseSalary = 12.50M;
            Salary = baseSalary + (rank * 2); 
        }
    }
}
