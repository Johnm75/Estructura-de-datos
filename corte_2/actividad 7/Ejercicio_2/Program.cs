using System;
using System.Collections;
/*Escriba un programa que calcule la sumatoria de los cuadrados de los elementos de una
lista/pila/cola de números enteros*/

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue cola2 = new Queue();

            Console.WriteLine("> Bienvenido a Miel.com, La lista de números enteros es: ");
            cola2.Enqueue(2);
            cola2.Enqueue(4);
            cola2.Enqueue(6);
            cola2.Enqueue(8);
            cola2.Enqueue(10);
            cola2.Enqueue(12);
            cola2.Enqueue(14);
            cola2.Enqueue(16);

            ImprimirElementosCola(cola2);
            
            Console.WriteLine("> Los valores elevados al cuadrado son los siguientes: ");
            CuadradosElementosCola(cola2);

            Console.WriteLine("> La sumatoria de todos los valores elevados al cuadrado es: ");
            SumatoriaElementosCola(cola2);
        }
        static void ImprimirElementosCola(IEnumerable cola){
            foreach (int n in cola)
            {
                Console.WriteLine($" {n} ");
            }
        }
        static void CuadradosElementosCola(IEnumerable cola){
            foreach (int n in cola)
            {
                Console.WriteLine(" {0} ", n*n);
            }
        }
        static void SumatoriaElementosCola(IEnumerable cola){
            int Elementos=0;
            foreach (int n in cola)
            {
                Elementos= Elementos + (n*n);
                Console.WriteLine(" {0} ", Elementos);
            }
        }

    }
}
