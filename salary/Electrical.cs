using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salary
{
    internal class Electrical : lecturers
    {
        public double Salary { get; set; }
        private double DeductionRate { get; set; }
        public override double CalcSalary()
        {
            return 120000 - (0.17 * 120000);
        }
    }
}
