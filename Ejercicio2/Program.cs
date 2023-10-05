using System;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. Hacer un programa que solicite el ingreso de 10 números y 
            //que muestre el mayor de ellos por pantalla.
            // Solo se debe emitir UN valor por pantalla.

            int n, max = 0;
            for (int x = 0; x < 10; x++)
            {Console.WriteLine("Ingrese un nro: ");
            n = int.Parse(Console.ReadLine()); 
              //  if(n > max)
                //    max = n;
                
            //}Console.WriteLine("El numero mayor es: " + max);

            //Esta manera de resolver me sirve para cuando haya numero negativos,
            //lo cual preguntado x == 0 me aseguro que es la primera vuelta sea
            //sea el valor le asigno ese primer valor al max, y no tengo que inicializar
            // max en 0 por que asi le voy a dar el valor, y no va a comparar solo
            //con valores mayores a 0 dejando de lado los negativos
            //puede ser que el programa a veces me de error por no inicializar el max en 0
            //pero igualmente haciendo esto es solo un gesto tecnico para que el programa funcione
            //y va a hacer la comparacion incluyendo los posibles nros negativos
            //que se ingresen.
            if(x == 0){
                max = n;
            }else if(n > max){
                max = n;}
                }
                

             Console.WriteLine("El numero mayor es: " + max);



            
        
     }
} }
