using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP_Solution
{
    public class Logger : ILogger
    {
        public void log(string logMessage)
        {
            Console.WriteLine(logMessage);
        }
    }
}
