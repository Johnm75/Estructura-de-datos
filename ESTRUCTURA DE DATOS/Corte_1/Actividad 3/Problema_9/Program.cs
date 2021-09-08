/*
Create by: Maria Camila Morales Galeano, 
           Maria Paula Leiva Agudelo,
           Juan David Ropero Prieto,
           John Fredy Marciales Morales.
Group: 239-2A
Shift: day
*/


using System;

namespace Problema_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int lado1;
            int lado2;
            int lado3;

            Console.Write("\nIngrese el lado 1 del triangulo: ");
            lado1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el lado 2 del triangulo: ");
            lado2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el lado 3 del triangulo: ");
            lado3 = Convert.ToInt32(Console.ReadLine());


            if((lado1 + lado2) > lado3){
                if(lado1 == lado2 && lado1 == lado3){
                    Console.WriteLine("El triángulo es Equilátero");
                }else if(lado1 == lado2 || lado1 == lado3 || lado3 == lado2){
                    Console.WriteLine("El triángulo es Isósceles");
                }else if(lado1 != lado2 && lado2 != lado3){
                    Console.WriteLine("El triángulo es Escaleno");
                }
                
            }
             Console.WriteLine("");
        }
    }
}
