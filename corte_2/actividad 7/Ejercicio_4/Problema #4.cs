using System;
//Authors:María Camila Morales Galeano,María Paula Leiva Agudelo,Jhon Fredy Marciales Morales,Juan david Ropero Prieto.
//Working day: Morning
//Group:239-2
using System.Collections;
namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("P1: ");
            ArrayList datos = new ArrayList();
            datos.Add(1);
            datos.Add(3);
            datos.Add(5);

         
            imprime(datos);
            Console.WriteLine("P2");
            ArrayList datos2 = new ArrayList();
            datos2.Add(2);
            datos2.Add(4);
            datos2.Add(6);

            Console.WriteLine(" ");
            imprime(datos2);
            ArrayList datos3 = new ArrayList();
            Console.WriteLine("Ordenados:");
            
            datos3.AddRange(datos);
            datos3.AddRange(datos2);
            datos3.Sort();
            imprime(datos3);

        static void imprime(ArrayList arreglo)
        {
            foreach (int n in arreglo)
                Console.Write(" {0}, ", n);
            Console.WriteLine("\n-------------");
        }
        }
    }
}