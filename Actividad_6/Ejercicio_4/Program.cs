/*
Create by: Maria Camila Morales Galeano.
Group: 239-2A
Shift: day
*/

/*
Escriba un programa que dadas dos lista/pila/cola ordenadas de números enteros, realice
la concatenación en forma ordenada de ambas lista/pila/cola.

*/

using System;
using System.Collections;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList lista = new ArrayList();
            ArrayList lista2 = new ArrayList();
            ArrayList listaConcatenada = new ArrayList();

            Random numeroAleatorio = new Random();
            int tamanoArray;

            Console.Write("\nDigite la cantidad de números que desea en el ArrayList: ");
            tamanoArray = int.Parse(Console.ReadLine());

            for (int i = 0; i < tamanoArray; i++)
            {
                lista.Add(numeroAleatorio.Next(0,100));
                lista2.Add(numeroAleatorio.Next(0,100));                                
            }

            Console.WriteLine("\nArrayList 1: ");
            lista.Sort();
            imprimirArrayList(lista);

            Console.WriteLine("\nArrayList 2: ");
            lista2.Sort();
            imprimirArrayList(lista2);

            Console.WriteLine("\n\nLista Concatenada y ordenada: ");
            listaConcatenada.AddRange(lista);
            listaConcatenada.AddRange(lista2);
            listaConcatenada.Sort();
            imprimirArrayList(listaConcatenada);
            Console.WriteLine();

        }

        static void imprimirArrayList(ArrayList array){
            foreach (var item in array)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine();
        }
    }
}
