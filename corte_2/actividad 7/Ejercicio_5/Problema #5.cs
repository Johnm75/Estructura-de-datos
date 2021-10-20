using System;
//Authors:María Camila Morales Galeano,María Paula Leiva Agudelo,Jhon Fredy Marciales Morales,Juan david Ropero Prieto.
//Working day: Morning
//Group:239-2ª
using System.Collections;
namespace Ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pila: ");
            ArrayList datos = new ArrayList();
            datos.Add(1);
            datos.Add(2);
            datos.Add(3);

         
            imprime(datos);
            Console.WriteLine("Pila Nueva");
            ArrayList datos2 = new ArrayList();
            datos2.Add(1);
            datos2.Add(2);
            datos2.Add(3);
            imprime(datos2);

            Console.WriteLine("Pila aintigua");
            datos.Clear();
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