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
            const int WagePerHour = 20;
            const int FullDayHr = 8;
            const int PartTimeHr = 4;
            const int Present = 1;
            const int Absent = 0;
            const int PartialPresent = 2;
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            int totalWage = 0;
            switch (empCheck)
            {
                case PartialPresent:
                    totalWage = PartTimeHr * WagePerHour;
                    break;
                case Absent:
                    break;
                case Present:
                    totalWage = WagePerHour * FullDayHr;
                    break;
            }
            Console.WriteLine("Daily employee wage is " + totalWage);
        }
    }
}