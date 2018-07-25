using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP_Solution
{
    public class Chore : IChore
    {
        ILogger logger;
        IMessageSender messageSender;
        public string ChoreName { get; set; }
        public IPerson Owner { get; set; }

        public double HoursWorked { get; set; }

        public bool IsCompleted { get; set; }

        public Chore(ILogger logger, IMessageSender messageSender)
        {
            this.logger = logger;
            this.messageSender= messageSender;
        }


        public void PerformedWork(int hours)
        {
            HoursWorked += hours;
            logger.log($"Performed work on {ChoreName}");
        }

        public void CompletedChore()
        {
            IsCompleted = true;

            logger.log($"Completed {ChoreName}");

            messageSender.SendMessage(Owner, $"The chore {ChoreName} complete.");    
        }

    }
}
