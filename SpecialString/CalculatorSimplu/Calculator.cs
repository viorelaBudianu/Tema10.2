using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorSimplu
{
    public class Calculator
    {
        public static double Adunare(double a, double b)
        {
            return a + b;
        }

        public static double Scadere(double a, double b)
        {
            return a - b;
        }

        public static double Inmultire(double a, double b)
        {
            return a * b;
        }

        public static double Impartire(double a, double b)
        {
            if (b == 0)
                throw new InvalidOperationException($"Cannot divide {a} by 0");

            return a/b;
        }
    }
}
