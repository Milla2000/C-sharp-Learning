using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    public  class TwitterException:Exception
    {

        public TwitterException(string message , Exception exception)
            :base(message, exception)
        {
            
        }
    }
}
