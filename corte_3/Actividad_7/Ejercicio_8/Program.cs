/*
Create by: Maria Camila Morales Galeano.
Group: 239-2A
Shift: day
*/

/*
Escriba una rutina que reciba dos Colas C1 y C2 de números enteros y proceda a
intercambiar sus elementos, pero manteniendo el orden de salida de los elementos. Al
finalizar la rutina, la Cola C1 tendrá los elementos de la Cola C2 y esta a su vez tendrá los 
elementos de la Cola C1.
*/


using System;
using System.Collections;

namespace Ejercicio_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue cola1 = new Queue();
            Queue cola2 = new Queue();
            int cantidad;

            Console.Write("Digite la cantidad de número que desea en la cola: ");
            cantidad = int.Parse(Console.ReadLine());

            Console.WriteLine("-Cola 1:");
            cargar(cantidad,cola1);
            imprimir(cola1);

            Console.WriteLine("\n-Cola 2:");
            cargar(cantidad,cola2);
            imprimir(cola2);
            Console.WriteLine("\n||||_intercambio_||||");
            clonar(cola1,cola2, cantidad);
            Console.WriteLine("-Cola 1:");
            imprimir(cola1);
            Console.WriteLine("\n-Cola 2:");
            imprimir(cola2);




        }
        static void cargar(int tamano, Queue cola)
        {
            Random numAle = new Random();
            for (int i = 0; i < tamano; i++)
            {
                int numero = numAle.Next(1,100);
                cola.Enqueue(numero);
            }
        }
        static void imprimir(Queue cola)
        {
            foreach (var item in cola)
            {
                Console.Write(item + " ");
            }
        }
        static void clonar(Queue cola1,Queue cola2,int tamano)
        {
            int[] num = new int[tamano];
            int cont = 0;
            foreach (var item in cola1)
            {
                num[cont] = (int)item;
                cont++;                
            }
            cola1.Clear();

            foreach (var item in cola2)
            {
                cola1.Enqueue(item);
            }
            cola2.Clear();
            foreach (var item in num)
            {
                cola2.Enqueue(item);
            }
        }
    }
}
