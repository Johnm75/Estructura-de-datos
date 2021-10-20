/*
Create by: Maria Camila Morales Galeano.
Group: 239-2A
Shift: day
*/

/* Escriba una rutina que reciba dos Colas C1 y C2 de números flotantes y apile las mismas 
en una nueva Cola resultante. Es de destacar que las Colas recibidas no deben sufrir ningún
tipo de cambio o alteración.*/


using System;
using System.Collections;

namespace Ejercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue cola1 = new Queue();
            Queue cola2 = new Queue();
            Queue cola3 = new Queue();    

            int cantidad;

            Console.Write("Digite la cantidad de número que desea en la cola: ");
            cantidad = int.Parse(Console.ReadLine());

            Console.WriteLine("Cola 1:");
            cargar(cantidad,cola1);
            imprimir(cola1);

            Console.WriteLine("\nCola 2:");
            cargar(cantidad,cola2);
            imprimir(cola2);

            Console.WriteLine("\nCola 3:");
            clonar(cola1,cola3);
            clonar(cola2,cola3);
            imprimir(cola3);

        }
        static void cargar(int tamano, Queue cola)
        {
            Random numAle = new Random();
            

            for (int i = 0; i < tamano; i++)
            {
                double numero = (numAle.NextDouble() * 9) + 1;
                string num = numero.ToString("0.##");
                cola.Enqueue(num);
            }
        }
        static void imprimir(Queue cola)
        {
            foreach (var item in cola)
            {
                Console.Write(item + " ");
            }
        }
        static void clonar(Queue cola,Queue colaCopia)
        {
            foreach (var item in cola)
            {
                colaCopia.Enqueue(item);
            }
        }
    }
}
