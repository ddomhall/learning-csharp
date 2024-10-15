using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimCoreyCourse.ClassLibrary.Services
{
    public static class CalculationService
    {
        public static void Add(double x, double y)
        {
            Console.WriteLine($"{x} + {y} = {x + y}");
        }
        public static void Subtract(double x, double y)
        {
            Console.WriteLine($"{x} - {y} = {x - y}");
        }
        public static void Multiply(double x, double y)
        {
            Console.WriteLine($"{x} * {y} = {x * y}");
        }
        public static void Divide(double x, double y)
        {
            Console.WriteLine($"{x} / {y} = {x / y}");
        }
    }
}
