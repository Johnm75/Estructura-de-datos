/*
Create by: John Fredy Marciales Morales.
Group: 239-2A
Shift: day
*/

/*
Escriba una rutina que reciba una Cola C de números enteros y mueva sus elementos a
una nueva Pila, pero manteniendo el orden de salida de los elementos. Al finalizar la Cola
C no debe contener elementos
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> C = new Queue<int>();
            Stack<int> nuevaPila = new Stack<int>();
            int finalizar = 1;
            int CSize = 0;
            while (finalizar == 1)
            {
                Console.Write("Digite un número entero: ");
                C.Enqueue(Convert.ToInt32(Console.ReadLine()));
                CSize++;
                Console.WriteLine("Para ingresar un nuevo número, digite 1. De lo contrario, ingrese cualquier otro número.");
                finalizar = Convert.ToInt32(Console.ReadLine());
            }
            int[] data = new int[CSize];
            data = C.ToArray();
            for (int i = 0; i < CSize; i++)
            {
                nuevaPila.Push(Convert.ToInt32(data[i]));
                Console.WriteLine(data[i]);
                C.Dequeue();
            }
        }
    }
}