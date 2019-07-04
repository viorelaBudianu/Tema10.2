using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Generic.Math;
namespace CalculatorBonusNuget
{
    public class CalculatorGenericMath
    {
        public static T Add<T>(T value1, T value2)
        {
            return GenericMath<T>.Add(value1, value2);
        }
        public static T Subtract<T>(T value1, T value2)
        {
            return GenericMath<T>.Subtract(value1, value2);
        }

        public static T Multiply<T>(T value1, T value2)
        {
            return GenericMath<T>.Multiply(value1, value2);
        }

        public static T Divide<T>(T value1, T value2)
        {
            return GenericMath<T>.Divide(value1, value2);
        }
    }
}
