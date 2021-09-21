/*
Create by: Maria Camila Morales Galeano.
Group: 239-2A
Shift: day
*/

/*
Escribe un programa que pida 20 números enteros. Estos números se deben introducir en un array de 4 
filas por 5 columnas. El programa mostrará las sumas parciales de filas y columnas igual que si de una 
hoja de cálculo se tratara. La suma total debe aparecer en la esquina inferior derecha.
*/
using System;

namespace Ejercicio_1
{
    class Program
    {
        int[,] arreglo = new int[4,5];        
        int[] sumFila = new int[4];
        int[] sumColumna = new int[5];
        int sumaTotalArreglo = 0;

        static void Main(string[] args)
        {
            Program op = new Program();
            op.llenarArreglo();
            op.sumarFila();
            op.sumarColumna();
            op.sumarArreglo();
            op.imprimirArreglo();
            
        }
        void llenarArreglo(){
            for (int f = 0; f < arreglo.GetLength(0); f++)
            {
                for (int c = 0; c < arreglo.GetLength(1); c++)
                {
                    Console.Write("Ingrese un número: ");
                    arreglo[f,c] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
        void sumarFila(){
            int sumaFila;

            for (int f = 0; f < arreglo.GetLength(0); f++)
            {
                sumaFila = 0;
                for (int c = 0; c < arreglo.GetLength(1); c++)
                {
                    sumaFila += arreglo[f,c];            
                }
                sumFila[f] = sumaFila;

            }            
        }

        void sumarArreglo(){
            
            for (int f = 0; f < arreglo.GetLength(0); f++)
            {
                for (int c = 0; c < arreglo.GetLength(1); c++)
                {
                    
                    sumaTotalArreglo += arreglo[f,c];
                }
            }
        }

        void sumarColumna(){
            int sumaColumna;

            for (int f = 0; f < arreglo.GetLength(1); f++) 
            {
                sumaColumna = 0;
                for (int c = 0; c < arreglo.GetLength(0); c++) 
                {
                    sumaColumna += arreglo[c,f];            
                }
                sumColumna[f] = sumaColumna;
            }            
        }
        void imprimirArreglo(){

            Console.WriteLine();
            for (int f = 0; f < arreglo.GetLength(0); f++)
            {
                for (int c = 0; c < arreglo.GetLength(1); c++)
                {
                    Console.Write($"{arreglo[f,c]}    ");
                }
                Console.Write($" {sumFila[f]}");
                Console.WriteLine();
            }    
            Console.WriteLine();
            for (int i = 0; i < sumColumna.Length; i++)
            {
                Console.Write($"{sumColumna[i]}   ");
            }    
            Console.WriteLine($"n\t\t\t\t\t\t\t{sumaTotalArreglo}");   
        }        
    }
}
