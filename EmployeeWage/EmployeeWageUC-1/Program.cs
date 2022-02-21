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
            Console.WriteLine("Welcome to employee wage computation program");
            Random random = new Random();
            if (random.Next(0, 2) == 0)
                Console.WriteLine("Employee is Absent");
            else
                Console.WriteLine("Employee is Present");
        }
    }
}