/*
Create by: Maria Camila Morales Galeano.
Group: 239-2A
Shift: day
*/

/*
Modifica el programa para que me indique por medio de un menú que si quiero ingresar o que los 
números que se introducen en el array se generen de forma aleatoria (valores entre 100 y 999).
*/

using System;

namespace Ejercicio_2
{
    class Program
    {
        int[,] arreglo = new int[4,5];        
        int[] sumFila = new int[4];
        int[] sumColumna = new int[5];
        int sumaTotalArreglo = 0;

        static void Main(string[] args)
        {
            int opcion = 4;
            Program op = new Program();
            
            do{
                Console.WriteLine("\n\t\t-Arreglo-");
                Console.WriteLine("| 1 = Ingresar números manualmente\n| 2 = Generar números aletorios");
                
                Console.Write("\nEliga una opción: ");
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1: 
                        op.llenarArregloManual();
                        op.sumarFila();
                        op.sumarColumna();
                        op.sumarArreglo();
                        op.imprimirArreglo();
                        break;
                    case 2: 
                        op.llenarArregloAutomatico();
                        op.sumarFila();
                        op.sumarColumna();
                        op.sumarArreglo();
                        op.imprimirArreglo();
                        break;
                    default:
                        Console.WriteLine("-->Opción invalida. Digite nuevamente una opción valida.");
                        break;
                }

            }while(opcion != 1 && opcion !=2);
        }

        void llenarArregloManual(){
             Console.WriteLine();
            for (int f = 0; f < arreglo.GetLength(0); f++)
            {
                for (int c = 0; c < arreglo.GetLength(1); c++)
                {
                    Console.Write("Ingrese un número: ");
                    arreglo[f,c] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
        void llenarArregloAutomatico(){
            Random numeroAleatorio = new Random();
            for (int f = 0; f < arreglo.GetLength(0); f++)
            {
                for (int c = 0; c < arreglo.GetLength(1); c++)
                {
                    arreglo[f,c] = numeroAleatorio.Next(100,999);
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
            Console.WriteLine($"\n\t\t\t\t\t\t\t{sumaTotalArreglo}");   
        }
    }
}
