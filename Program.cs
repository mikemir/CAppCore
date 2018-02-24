using System;

namespace CAppCore
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: validar entrada de datos
            Console.WriteLine("Digita tu nombre: ");
            var nombre = Console.ReadLine();

            Console.WriteLine($"Hello {nombre}");
        }
    }
}
