using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioExtExcTest
{
    class SeveralOperations
    {
        public static double DivideByZero(int number)
        {
            return number / 0;
        }

        public static float DivideTwoNumbers(int firstNumber, int secondNumber)
        {
            return firstNumber / secondNumber;
        }
    }
}
