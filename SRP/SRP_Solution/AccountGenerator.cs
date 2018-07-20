using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_Solution
{
    public class AccountGenerator
    {
        public static string GenerateUserName(Person user)
        {
            return user.FirstName.Substring(0, 1) + user.LastName;
        }
    }
}
