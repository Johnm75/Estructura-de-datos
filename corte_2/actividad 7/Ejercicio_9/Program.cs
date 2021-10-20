/*
Create by: Maria Camila Morales Galeano.
Group: 239-2A
Shift: day
*/

/*
Escriba una rutina que reciba una Cola C de números enteros y devuelva una copia exacta
de la misma. Es de destacar que la Cola C no debe sufrir ningún tipo de cambio o alteración.
*/


using System;
using System.Collections;

namespace Ejercicio_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue cola1 = new Queue();
            Queue colaCopia = new Queue();
            int cantidad;

            Console.Write("Digite la cantidad de número que desea en la cola: ");
            cantidad = int.Parse(Console.ReadLine());

            Console.WriteLine("-Cola :");
            cargar(cantidad,cola1);
            imprimir(cola1);
            Console.WriteLine("\n-Cola copia:");
            clonar(cola1,colaCopia,cantidad);
            imprimir(colaCopia);
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
            
            foreach (var item in cola1)
            {
                cola2.Enqueue(item);               
            }
            
        }
    }
}


