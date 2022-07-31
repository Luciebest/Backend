using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TudorPortal.Business.Exceptions
{
   public class UserNotFoundException : ApplicationException
    {
        public UserNotFoundException(string message) : base(message)
        {
            string.Format("Sorry the user is not found");
        }
    }
}
