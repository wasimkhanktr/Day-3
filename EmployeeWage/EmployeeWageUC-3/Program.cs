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
            int WagePerHour = 20;
            int FullDayHour = 8;
            int PartTime = 4;
            int DailyEmployeeWage = WagePerHour * FullDayHour;
            int PartTimeEmployeeWage = PartTime * WagePerHour;
            Console.WriteLine("Daily employee wage is " + DailyEmployeeWage);
            Console.WriteLine("Part time employee wage is " + PartTimeEmployeeWage);
        }
    }
}