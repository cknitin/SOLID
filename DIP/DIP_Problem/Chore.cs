using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP_Problem
{
    public class Chore
    {
        public string ChoreName { get; set; }
        public Person Owner { get; set; }

        public double HoursWorked { get; set; }

        public bool IsCompleted { get; set; }

        public void PerformedWork(int hours)
        {
            HoursWorked += hours;

            Logger log = new Logger();
            log.log($"Performed work on {ChoreName}");
        }

        public void CompletedChore()
        {
            IsCompleted = true;
            Logger log = new Logger();
            log.log($"Completed {ChoreName}");

            Emailer emailer = new Emailer();
            emailer.SendEmail(Owner,$"The chore {ChoreName} complete.");    
        }

    }

    
}
