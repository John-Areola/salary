using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salary
{
    internal class Midwevery : lecturers
    {
        public double Salary { get; set; }
        private double DeductionRate { get; set; }
        public override double CalcSalary()
        {
            return 120000 - (0.01 * 120000);
        }
    }
}
