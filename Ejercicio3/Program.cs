using System;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            //3. Hacer un programa que solicite 20 edades y luego calcule 
            // el promedio de edad de aquellas personas mayores a 18 años.
            int edad, acum = 0, cont = 0, promedio;
            for (int x = 0; x < 20; x++)
            {Console.WriteLine("Ingrese su edad: ");
            edad = int.Parse(Console.ReadLine());
                if(edad > 18){
            cont++;        
            acum += edad;}

                
            }promedio = acum / cont;


            Console.WriteLine("El promedio de edad en personas mayores a 18 es: " + promedio);
        }
    }
}
