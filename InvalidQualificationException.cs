using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApplication
{
    class InvalidQualificationException:Exception
    {
        public InvalidQualificationException(String message):base(message)
        {

        }
    }
}
