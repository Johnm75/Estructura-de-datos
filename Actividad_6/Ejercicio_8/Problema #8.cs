using System;
//Authors:María Camila Morales Galeano,María Paula Leiva Agudelo,Jhon Fredy Marciales Morales,Juan david Ropero Prieto.
//Working day: Morning
//Group:239-2ª
using System;
using System.Collections;
namespace Ejercicio_8
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
            Console.WriteLine("P2");
            ArrayList datos2 = new ArrayList();
            datos2.Add(4);
            datos2.Add(5);
            datos2.Add(6);

            Console.WriteLine(" ");
            imprime(datos2);

            Console.WriteLine("Cambio:");
            Console.WriteLine("P1: ");
            imprime(datos2);
            Console.WriteLine("P2: ");
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