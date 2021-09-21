using System;
//Authors:María Camila Morales Galeano,María Paula Leiva Agudelo,Jhon Fredy Marciales Morales,Juan david Ropero Prieto.
//Working day: Morning
//Group:239-2ª
namespace Problema8
{
    class Program
    {
        /*Realiza un programa que sea capaz de rotar todos los elementos de una matriz cuadrada una posición en el sentido de las agujas del reloj. La matriz debe tener 12 filas por 12 columnas y debe contener números generados al azar entre 0 y 100. Se debe mostrar tanto la matriz original como la matriz resultado, ambas con los números convenientemente alineados.*/
        
        
        static void Main(string[] args)
        {
            Program objeto = new Program();
            int [,] matriz = new int [12,12];
            int [,] matrizRotada = new int [12,12];
            objeto.llenarMatriz(matrizRotada,matriz);
            objeto.rotarMatriz(matrizRotada,matriz);
            Console.WriteLine("Matriz Original");
            objeto.imprimirMatriz(matriz);
            Console.WriteLine("Matriz Original");
            objeto.imprimirMatriz(matrizRotada);
        }
        void llenarMatriz(int [,] matrizRotada, int [,] matriz)
        {
            Random rnd = new Random ();
           for (int filas = 0; filas < matriz.GetLength(0); filas++)
            {
                for ( int columnas = 0; columnas< matriz.GetLength (1); columnas++)
                {
                  matriz [filas,columnas]   = rnd.Next(0,100);
                  //matrizRotada [filas,columnas] = matriz [filas,columnas];
                }
            }
        }
        void rotarMatriz(int [,] matrizRotada, int [,] matriz)
        {
            int columnasRotadas = 11;

            for (int filas = 0; filas < matriz.GetLength(0); filas++)
            {
                int filasRotada=0; 
                for ( int columnas = 0; columnas< matriz.GetLength (1); columnas++)
                {
                  matrizRotada [filasRotada,columnasRotadas] = matriz [filas,columnas];
                  filasRotada++;
                }
                columnasRotadas--;
            }
        }
        void imprimirMatriz(int [,] matrizA)
        {
            Console.WriteLine(); 
           for (int filas = 0; filas < matrizA.GetLength(0); filas++)
            {
                
                for ( int columnas = 0; columnas< matrizA.GetLength (1); columnas++)
                {
                 Console.Write(matrizA[filas,columnas] + "  " );
                }
               Console.WriteLine();
            } 
        }
    }
}