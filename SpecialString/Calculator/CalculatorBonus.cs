using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class CalculatorBonus<T>
    {
        public static T Add(T a, T b )
        {
            dynamic a1 = a;
            dynamic b1 = b;
            return (T)(dynamic)(a1 + b1);
        }
        public static T Sub(T a, T b)
        {
            dynamic a1 = a;
            dynamic b1 = b;
            return (T)(dynamic)(a1 - b1);
        }
        public static T Multiplication(T a, T b)
        {
            dynamic a1 = a;
            dynamic b1 = b;
            return (T)(dynamic)(a1 * b1);
        }
        public static T Division(T a, T b)
        {
            dynamic a1 = a;
            dynamic b1 = b;
            if (b1 == 0 || b1 == null)
                throw new ArithmeticException("Cannot make Division on a null/0 value");

            return (T)(dynamic)(a1 / b1);
        }
    }
}
