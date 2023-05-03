using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workers
{
    public class Director : Officer
    {
        private double _directorAllowance;
        public Director(string name, double basicSalary, double bonus, double allowance) : base(name, basicSalary, bonus)
        {
             _directorAllowance= allowance;
        }

        public double computeIncome()
        {
            return computeSalary() + _directorAllowance;
        }


    }
}
