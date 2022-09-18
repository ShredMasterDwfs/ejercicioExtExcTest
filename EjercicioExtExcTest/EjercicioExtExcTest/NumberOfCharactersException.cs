using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioExtExcTest
{
    public class NumberOfCharactersException:Exception
    {

        public NumberOfCharactersException(string message) : base(message + " : Error Controlado y editado.")
        {
            
        }

        public NumberOfCharactersException() : base("Excepción personalizada: La cantidad de caracteres es incorrecta.")
        {

        }
    }
}
