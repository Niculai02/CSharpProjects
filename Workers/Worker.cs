using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workers
{
    public class Worker
    {
        protected string _name;
        protected double _basicSalary;
        public string Name()
        {
            return _name;
        }

        public Worker(string name, double basicSalary)
        {
            _name = name;
            _basicSalary = basicSalary;
        }

        public double getSalary()
        {
            return _basicSalary;
        }
    }
}
