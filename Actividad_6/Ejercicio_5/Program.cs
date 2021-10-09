/*
Create by: Maria Camila Morales Galeano.
Group: 239-2A
Shift: day
*/

/*
Escriba una rutina que reciba una Pila P de números enteros y mueva sus elementos a una
nueva Pila, pero manteniendo el orden de salida de estos. Al finalizar la Pila P no debe
contener elementos.

*/

using System;
using System.Collections;

namespace Ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList pilaP = new ArrayList();
            ArrayList pilaN = new ArrayList();
            Random numeroAleatorio = new Random();
            int tamanoArray;
           
            
            Console.Write("\nDigite la cantidad de números que desea en el ArrayList: ");
            tamanoArray = int.Parse(Console.ReadLine());

            for (int i = 0; i < tamanoArray; i++)
            {
                pilaP.Add(numeroAleatorio.Next(0,100));
                                           
            }
            Console.WriteLine("\nPila:");
            imprimirArrayList(pilaP);
            moverArrayList(pilaP,pilaN);
            Console.WriteLine("Pila nueva:");
            imprimirArrayList(pilaN);

        }

        static void moverArrayList(ArrayList array, ArrayList arrayNuevo){            
            foreach (var item in array)
            {
                arrayNuevo.Add(item);
            }
            array.Clear();
        }

        static void imprimirArrayList(ArrayList array){
            foreach (var item in array)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine("\n");
        }
    }
}
