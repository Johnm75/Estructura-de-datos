using System;
using System.Collections;
/*Escriba un programa que reciba la dirección del primer elemento de una lista/pila/cola
simple de números enteros y devuelva un apuntador al elemento donde exista el número. 
<x>. Este número es recibido por el método. Se debe retornar NULL si el valor de <x> no
se encuentra en la lista/pila/cola.*/

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList Lista2 = new ArrayList();

            Console.WriteLine("> Bienvenido a Miel.com, La lista de números enteros es: ");
            Lista2.Add(2);
            Lista2.Add(4);
            Lista2.Add(6);
            Lista2.Add(8);
            Lista2.Add(10);
            Lista2.Add(12);
            Lista2.Add(14);
            Lista2.Add(16);

            ImprimirElementosLista(Lista2);
            
            Console.WriteLine("> Los valores elevados al cuadrado son los siguientes: ");
            CuadradosElementosLista(Lista2);

            Console.WriteLine("> La sumatoria de todos los valores elevados al cuadrado es: ");
            SumatoriaElementosLista(Lista2);
        }
        static void ImprimirElementosLista(ArrayList arreglo){
            foreach (int n in arreglo)
            {
                Console.WriteLine($" {n} ");
            }
        }
        static void CuadradosElementosLista(ArrayList arreglo){
            foreach (int n in arreglo)
            {
                Console.WriteLine(" {0} ", n*n);
            }
        }
        static void SumatoriaElementosLista(ArrayList arreglo){
            int Elementos=0;
            foreach (int n in arreglo)
            {
                Elementos= Elementos + (n*n);
                Console.WriteLine(" {0} ", Elementos);
            }
        }

    }
}

