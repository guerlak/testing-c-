using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ByteBank.Employees.Tools
{
    //visible just inside the project 
    internal class AuthenticationHelper
    {
        public bool ComparePasswords(string password, string attempt)
        {
            return password == attempt;
        }
    }
}
