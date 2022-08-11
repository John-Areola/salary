using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salary
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            Electrical electrical = new Electrical();
            Mechanicalengineering mechanicalengineering = new Mechanicalengineering();
            Midwevery midwevery = new Midwevery();
            Console.WriteLine($" The salary after deduction for Electrical engineering is {electrical.CalcSalary()} and the decuctions for Midwevery and mechanical are {midwevery.CalcSalary()} , {mechanicalengineering.CalcSalary()} respectively");
            Console.ReadLine();
        }
    }
}
