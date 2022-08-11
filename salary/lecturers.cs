using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salary
{
    abstract class lecturers
    {
        public double Salary { get; set; }
        private double DeductionRate { get; set; }
        public abstract double CalcSalary();
    }
}
