﻿using System;
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
            const int WagePerHr = 20;
            const int FullDayHr = 8;
            const int PartTimeHr = 4;
            const int Present = 1;
            const int Absent = 0;
            const int PartialPresent = 2;
            int day = 0;
            Random random = new Random();
            int totalWage = 0;
            int totalWorkingHours = 0;
            while (day < 20 && totalWorkingHours < 100)
            {
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case PartialPresent:
                        totalWage += PartTimeHr * WagePerHr;
                        totalWorkingHours += PartTimeHr;
                        break;
                    case Absent:
                        break;
                    case Present:
                        totalWage += WagePerHr * FullDayHr;
                        totalWorkingHours += FullDayHr;
                        break;
                }
                day++;
            }
            Console.WriteLine("Total employee wage is " + totalWage);
        }
    }
}