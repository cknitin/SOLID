using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_Solution
{
    public class PersonValidator
    {
        public static bool ValidateFirstName(Person user)
        {
            if (string.IsNullOrWhiteSpace(user.FirstName))
            {
                StandardMessages.ValidateMessage("First Name");
                return false;
            }

            if (string.IsNullOrWhiteSpace(user.LastName))
            {
                StandardMessages.ValidateMessage("Last Name");
                return false;
            }
            return true;
        }

    }
}
