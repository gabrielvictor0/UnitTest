using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    public static class Calculation 
    {
        public static double Sum(double x, double y)
        {
            return x + y;
        }
        
        public static double Subtraction(double x, double y) 
        {
            return x - y;
        }

        public static double Division(double x, double y) 
        {
            return x / y;
        }

        public static double Multiplication(double x, double y) 
        {
            return x * y;
        }

        public static double Module(double x, double y) 
        {
            return x % y;
        }

    }
}
