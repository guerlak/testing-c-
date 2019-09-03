using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Employees
{
    class BonusManager
    {
        private static double _totalBonus;

        public void Register(Employee employee)
        {
            _totalBonus += employee.GetBonus();
        }

        public double getTotalBonus()
        {
            return _totalBonus;
        }

    }
}
