using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Workers
{
     public class Officer : Worker
    {
        protected double _bonus;
        public Officer(string name, double basicSalary, double bonus): base(name, basicSalary)
        {
            _bonus = bonus;
        }
         public double computeSalary()
        {
            return _basicSalary + (_bonus/100)*_basicSalary;
        }

    }
}
