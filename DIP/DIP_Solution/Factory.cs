﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP_Solution
{
    public static class Factory
    {
        public static IPerson CreatePerson()
        {
            return new Person();
        }

        public static IChore CreateChore()
        {
            return new Chore(new Logger(), new SMSSender());
        }


        public static ILogger CreateLogger()
        {
            return new Logger();
        }

        public static IMessageSender CreateEmailer()
        {
            return new Emailer();
        }

    }
}