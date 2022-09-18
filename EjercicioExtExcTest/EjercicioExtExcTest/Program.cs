using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioExtExcTest
{
    class Program
    {
        static void Main(string[] args)
        {
                string option;
                ShowUI();
                option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        try
                        {
                            int num;
                            Console.WriteLine("Ingrese el dividendo para la operación:");
                            num = int.Parse(Console.ReadLine());
                            Console.WriteLine($"El resultado de la operación es: {SeveralOperations.DivideByZero(num)}");

                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"No se puede dividir por cero.\nMensaje de la excepción: {ex.Message}");
                        }
                        finally
                        {
                            Console.WriteLine("Operación finalizada!");
                        }
                        break;

                    case "2":
                        try
                        {
                            int num1, num2;
                            Console.WriteLine("Ingrese el dividendo para la operación:");
                            num1 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese el divisor para la operación:");
                            num2 = int.Parse(Console.ReadLine());
                            Console.WriteLine($"El resultado de la operación es: {SeveralOperations.DivideTwoNumbers(num1, num2)}");

                        }
                        catch (DivideByZeroException DZex)
                        {
                            Console.WriteLine($"Solo Mascherano divide por cero... (y Menem!).\nMensaje de la excepción: {DZex.Message}");
                        }
                        catch (FormatException Fex)
                        {
                            Console.WriteLine($"Debe ingresar un número entero.\nMensaje de la excepción: {Fex.Message}");
                        }
                        finally
                        {
                            Console.WriteLine("Operación finalizada!");
                        }
                        break;

                    case "3":
                        try
                        {
                            Logic.ThrowException();
                        }
                        catch (Exception Gex)
                        {
                            Console.WriteLine($"Mensaje de la excepción: {Gex.Message}\nTipo de excepción: {Gex.GetType()}");
                        }
                        finally
                        {
                            Console.WriteLine("Operación finalizada!");
                        }
                        break;

                case "4":
                    try
                    {
                        Console.WriteLine("Desea ingresar un mensaje para la excepción? s/n");
                        string sn;
                        sn = Console.ReadLine();

                        if (sn == "s")
                        {
                            string errorMsg;
                            Console.Write("Mensaje: ");
                            errorMsg = Console.ReadLine();
                            throw new NumberOfCharactersException($"Mensaje de error ingresado por el usuario: {errorMsg}");
                        }

                        Logic.ThrowSpecialException();
                    }
                    catch (NumberOfCharactersException NCex)
                    {
                        Console.WriteLine($"{NCex.Message}\nTipo de excepción: {NCex.GetType()}");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Mensaje de la excepción: {ex.Message}\nTipo de excepción: {ex.GetType()}");
                    }
                    finally
                    {
                        Console.WriteLine("Operación finalizada!");
                    }
                    break;

                default:
                        Console.WriteLine("Opción válida.");
                        break;
                }

                Console.ReadKey();

        }











        public static void ShowUI()
        {
            Console.WriteLine("╔═════════════════════════════════╗");
            Console.WriteLine("║      SELECCIONE OPERACIÓN       ║");
            Console.WriteLine("║                                 ║");
            Console.WriteLine("║ -1 DIVIDIR POR CERO.            ║");
            Console.WriteLine("║ -2 DIVIDIR DOS NÚMEROS ENTEROS. ║");
            Console.WriteLine("║ -3 LANZAR EXCEPCIÓN.            ║");
            Console.WriteLine("║ -4 EXCEPCIÓN PERSONALIZADA.     ║");
            Console.WriteLine("║                                 ║");
            Console.WriteLine("╚═════════════════════════════════╝");
        }

        public class TOperation
        {
            public int MathPower(int number, int power)
            {
                int result;
                result = 1;

                for (int i = 0; i < power; i++)
                {
                    result *= number;
                }
                return result;
            }
        }
    }
}
