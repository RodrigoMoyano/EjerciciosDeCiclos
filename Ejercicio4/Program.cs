using System;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, R, cont = 0;
            Console.WriteLine("Ingrese un nro:");
            n = int.Parse(Console.ReadLine());
            for (int x = 1; x <= n; x++)
            {
            //if(n % x == 0)
            //cont++;
            R = n % x;
            if( R == 0)
            cont++;

            
                
            }if(cont == 2)
            
            Console.WriteLine("El nro es primo");
            else
            {Console.WriteLine("El nro no es primo");
                
            }
        }
    }
}
