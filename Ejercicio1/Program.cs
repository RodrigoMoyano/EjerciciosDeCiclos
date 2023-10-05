using System;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Hacer un programa para mostrar los números del 1 al 10.
            // No se debe realizar ningún pedido de datos.
            int cont = 1;
            for (int  x  = 0; x < 10; x++)
            {cont++;
            
                Console.WriteLine("Los nros son: " + cont);
            }
            Console.WriteLine("Fin del programa");
            
        }
    }
}
