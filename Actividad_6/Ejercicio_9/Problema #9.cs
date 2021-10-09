using System;
//Authors:María Camila Morales Galeano,María Paula Leiva Agudelo,Jhon Fredy Marciales Morales,Juan david Ropero Prieto.
//Working day: Morning
//Group:239-2ª
using System.Collections;
namespace Ejercicio_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("P1: ");
            ArrayList datos = new ArrayList();
            datos.Add(1);
            datos.Add(2);
            datos.Add(3);

            
            imprime(datos);
            ArrayList datos2 = new ArrayList();
            datos.AddRange(datos2);
            datos2.Add(datos);

            Console.WriteLine("Nueva copia");
            imprime(datos);
        static void imprime(ArrayList arreglo)
        {
            foreach (int n in arreglo)
                Console.Write(" {0}, ", n);
            Console.WriteLine("\n-------------");
        }
        }
    }
}