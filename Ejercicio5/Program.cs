using System;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, max = 0, min = 0;
            bool banPar = false, banImpar = false;
            for (int x = 0; x < 20; x++)
            {Console.WriteLine("Ingrese un nro:");
            n = int.Parse(Console.ReadLine());
            if(n % 2 == 0){
                if(banPar == false){
                max = n;
                banPar = true;
                }else if
                (n > max)
                max = n;
                
            }else if(banImpar == false){
            min = n;
            banImpar = true;
            }else if(n < min)
            min = n;
            //Con la ultilizacion de las banderas puedo preguntar si es el primer numero que ingreso
            //de los pares y tambien de los impares, lo inicializo en false y cuando pregunto si la 
            //bandera esta en false, como la inicialize quiere decir que es el primer numero ingresado
            //de ese grupo(grupo par o grupo impar), entonces le asigno en este caso el min o max a ese numero
            //y la bandera en true para que sepa que ya hubo un primer numero ingresado.

            


                
            }
            
                
            
            Console.WriteLine("El nro par mayor es " + max + " El nro impar menor es: " + min);
        }
    }
}
