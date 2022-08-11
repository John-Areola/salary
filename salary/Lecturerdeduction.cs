using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salary
{
    internal class Lecturerdeduction
    {
        double TotalDeductions(List<lecturers> deduction)
        {
            double total = 0;

            try
            {
                foreach (var deductions in deduction)
                {
                    total += deductions.CalcSalary();

                }

                return total;
            }
            catch (Exception a)
            {

                Console.WriteLine("This is an error");
                return 0;
            }
        }
    }
}
