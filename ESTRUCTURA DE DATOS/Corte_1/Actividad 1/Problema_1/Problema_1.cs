/*
Create by: Maria Camila Morales Galeano
Group: 239-2A
Shift: day
*/

/*
Problema 1
Escribir un programa que, dado un número real cualquiera, encuentre su valor 
absoluto. El valor absoluto de un número x es igual a x si x > 0, y a -x si x es menor 
o igual a 0. 
Por ejemplo, el valor absoluto de 0.5 es 0.5, mientras que el valor absoluto de 3 es 
3.
*/

using System;

namespace Ejercicios_2.Problema_1
{   class Problema_1
    {
        static void Main(string[] args)
        {
            double numeroReal;
            double numeroAbsoluto;

            Console.Write("Ingrese un número real: ");
            numeroReal = Convert.ToDouble(Console.ReadLine());

            if (numeroReal > 0)
            {
                numeroAbsoluto = numeroReal;
                Console.WriteLine("El número absoluto de {0} es {1}", numeroReal, numeroAbsoluto);
            }
            else if (numeroReal < 0)
            {
                numeroAbsoluto = numeroReal * -2 + numeroReal;
                Console.WriteLine("El número absoluto de {0} es {1}", numeroReal, numeroAbsoluto);
            }
            else
            {
                numeroAbsoluto = numeroReal;
                Console.WriteLine("El número absoluto de {0} es {1}", numeroReal, numeroAbsoluto); // 0

            }
        }
    }
}
