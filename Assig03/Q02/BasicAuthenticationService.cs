using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assig03.Q02
{
    internal class BasicAuthenticationService : IAuthenticationService

    {
      
        public bool AuthenticateUser(string userName, string password)
        {
            if (userName != null )
            {  
                password = password;
                return true;
            }
            return false;
        }

        public bool AuthorizeUser(string userName , string role)
        {
            if (userName != null)
            {
                  Console.WriteLine(role);
                return true;
            }
            return false;
        }
    }
}
