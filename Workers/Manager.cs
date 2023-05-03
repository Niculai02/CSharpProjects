using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Workers
{
    public class Manager:Officer
    {
        private double _managerAllowance;
        public Manager(string name, double basicSalary, double bonus, double allowance) : base( name, basicSalary, bonus)
        {
            _managerAllowance = allowance;
        }

        public double computeIncome()
        {
            return computeSalary() + _managerAllowance;
        }
    }
}
