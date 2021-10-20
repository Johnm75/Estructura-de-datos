using System;
//Authors:María Camila Morales Galeano,María Paula Leiva Agudelo,Jhon Fredy Marciales Morales,Juan david Ropero Prieto.
//Working day: Morning
//Group:239-2
using System.Collections;
namespace Ejercicio_6
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
            
            ArrayList datos2 = new ArrayList();
            Console.WriteLine("Ordenados:");
            
            datos2.AddRange(datos);  
            datos2.Reverse();
            imprime(datos2);

        static void imprime(ArrayList arreglo)
        {
            foreach (int n in arreglo)
                Console.Write(" {0}, ", n);
            Console.WriteLine("\n-------------");
        }
        }
    }
}