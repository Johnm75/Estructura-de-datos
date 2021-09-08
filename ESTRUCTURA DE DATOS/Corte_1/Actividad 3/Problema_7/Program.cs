/*
Create by: Maria Camila Morales Galeano, 
           Maria Paula Leiva Agudelo,
           Juan David Ropero Prieto,
           John Fredy Marciales Morales.
Group: 239-2A
Shift: day
*/

/*
Problema 7:
Realizar un programa que pida al usuario dos números y una letra: “i” ó “p”. El programa presentará los 
números pares (si se pulsó la “p”) ó impares (si se pulsó la “i”) que hay desde el primer número al segundo que 
introdujo el usuario. Si se pulsa alguna tecla distinta de “p” ó “i”, el programa no imprime ningún número.

*/

using System;

namespace Problema_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroUno;
            int numeroDos;
            char opcion;

            Console.Write("Ingrese un número: ");
            numeroUno = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese un número: ");
            numeroDos = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese 'p' para presentar los números pares o 'i' para números impares: ");
            opcion = Console.ReadKey().KeyChar;
            Console.WriteLine("\n");

            switch (opcion){
                case 'p' :
                    for (int i = numeroUno; i <= numeroDos; i++)
                    {
                        if(i % 2 == 0){
                             Console.Write(i + " ");
                        }
                    }
                    break;
                case 'i':
                    for (int i = numeroUno; i <= numeroDos; i++)
                    {
                        if(i % 2 != 0){
                             Console.Write(i + " ");
                        }
                    }
                    break;
                default:
                    Console.WriteLine("");
                    break;
                    

                

            }
        }
    }
}
