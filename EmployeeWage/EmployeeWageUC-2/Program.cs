using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int WageEmpHour = 20;
            int FullEmpHour = 8;
            int dailyEmployeeWage = WageEmpHour * FullEmpHour;
            Console.WriteLine("Daily employee wage is " + dailyEmployeeWage);
        }
    }
}