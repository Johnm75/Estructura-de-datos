/*
Create by: Maria Camila Morales Galeano.
Group: 239-2A
Shift: day
*/

/*
Define un array de números enteros de 3 filas por 6 columnas con nombre num y asigna los valores 
cuando se inicie el programa. Muestra el contenido de todos los elementos del array dispuestos en 
forma de tabla.
*/

using System;

namespace Ejercicio_3
{
    class Program
    {
        int[,] num = new int[3,6]; 
        static void Main(string[] args)
        {
           Program op = new Program();

           op.llenarArreglo();
           op.imprimirArreglo();
        }

        void llenarArreglo(){
             Console.WriteLine();
            for (int f = 0; f < num.GetLength(0); f++)
            {
                for (int c = 0; c < num.GetLength(1); c++)
                {
                    Console.Write("Ingrese un número: ");
                    num[f,c] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
        void imprimirArreglo(){
            Console.WriteLine();
            for (int f = 0; f < num.GetLength(0); f++)
            {
                for (int c = 0; c < num.GetLength(1); c++)
                {
                    Console.Write($"{num[f,c]}    ");
                }
                Console.WriteLine();
            }    
            
        }
    }
}
