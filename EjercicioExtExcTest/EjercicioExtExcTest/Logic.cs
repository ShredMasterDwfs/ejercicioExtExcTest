using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioExtExcTest
{
    public static class Logic
    {
        public static void ThrowException()
        {
            throw new OperationCanceledException();
        }

        public static void ThrowSpecialException()
        {

        }
    }
}
