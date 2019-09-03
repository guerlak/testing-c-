using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ByteBank.Employees.Tools
{
    public interface Authenticate
    {
        bool GetAthenticate(string password);
    }
}
