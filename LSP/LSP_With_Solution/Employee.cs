﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP_With_Solution
{
    public class Employee : BaseEmployee, IManaged
    {
        public IEmployee Manager { get; set; }

        public void AssignManager(IEmployee manager)
        {
            this.Manager = manager;
        }

    }
}
