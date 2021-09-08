/*
Create by: Maria Camila Morales Galeano
Group: 239-2A
Shift: day
*/

/*
Problema 7: 
Sean A, B y C tres variables enteras que representan las ventas de tres productos 
A, B y C, respectivamente. Utilizando dichas variables, escribe las expresiones que 
representen cada una de las siguientes afirmaciones: 
    a) Las ventas del producto A son las más elevadas. 
    b) Ningún producto tiene unas ventas inferiores a 200. 
    c) Algún producto tiene unas ventas superiores a 400. 
    d) La media de ventas es superior a 500. 
    e) El producto B no es el más vendido. 
    f) El total de ventas esta entre 500 y 1000.
*/

using System;

namespace Problema_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int c;
            int media;
            int total;

            Console.Write("Ingrese las ventas del producto A: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese las ventas del producto B: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese las ventas del producto C: ");
            c = Convert.ToInt32(Console.ReadLine());

            total = a + b + c;
            media = total / 3;

            Console.WriteLine("");
            if (a > b && a > c)
            {
                Console.WriteLine("Las ventas del producto A son las más elevada.");
            }
            if (a >= 200 && b >= 200 && c >= 200)
            {
                Console.WriteLine("Ningún producto tiene unas ventas inferiores a 200.");
            }
            if (a > 400 || b > 400 || c > 400)
            {
                Console.WriteLine("Algún producto tiene unas ventas superiores a 400.");
            }
            if (media > 500)
            {
                Console.WriteLine("La media de ventas es superior a 500.");
            }
            if (b < a || b < c)
            {
                Console.WriteLine("El producto B no es el más vendido. ");
            }
            if (total >= 500 && total <= 1000)
            {
                Console.WriteLine("El total de ventas esta entre 500 y 1000.");
            }
            Console.WriteLine("");
            
        }
    }
}
