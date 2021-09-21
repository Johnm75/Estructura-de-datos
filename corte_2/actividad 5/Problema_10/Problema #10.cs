using System;
//Authors:María Camila Morales Galeano,María Paula Leiva Agudelo,Jhon Fredy Marciales Morales,Juan david Ropero Prieto.
//Working day: Morning
//Group:239-2ª
namespace Problema8
{
    class Program
    {
        static void Main(string[] args)
        {
           /*Realiza un programa que rellene un array de 6 filas por 10 columnas con números enteros positivos comprendidos entre 0 y 1000 (ambos incluidos). A continuación, el programa deberá dar la posición tanto del máximo como del mínimo.*/
            int [,] matriz = new int [6,10];
            Random rnd = new Random ();
            int mayor=0, menor=1001;
            int [] pMayor = new int [2];
            int [] pMenor = new int [2];

            for (int filas = 0; filas < matriz.GetLength(0); filas++)
            {
                for ( int columnas = 0; columnas< matriz.GetLength (1); columnas++)
                {
                  matriz [filas,columnas]   = rnd.Next(0,1000);
                }
            }
            for (int filas = 0; filas < matriz.GetLength(0); filas++)
            {
                for ( int columnas = 0; columnas< matriz.GetLength (1); columnas++)
                {
                    int cont=0;
                     if (matriz[filas,columnas] > mayor) 
                 {
                     mayor=matriz[filas,columnas];
                     pMayor[cont]=filas;
                     cont++;
                     pMayor[cont]=columnas;
                 }
                 if (matriz[filas,columnas] < menor) 
                 {
                   int cont2=0;

                     menor=matriz[filas,columnas];
                     pMenor[cont2]=filas;
                     cont2++;
                     pMenor[cont2]=columnas;
                 }
                }
            }
            for (int filas = 0; filas < matriz.GetLength(0); filas++)
            {
                for ( int columnas = 0; columnas< matriz.GetLength (1); columnas++)
                {
                  Console.WriteLine("El numero de la posicion [" + filas+ ","+columnas+ "] es "+matriz[filas,columnas].ToString());
                  
                }
            }


                  Console.WriteLine("\nLa posicion del numero mayor es [" + pMayor[0]+ ","+pMayor[1]+ "] "+matriz[pMayor[0],pMayor[1]].ToString());
                  
                  Console.WriteLine("\nLa posicion del numero menor es [" + pMenor[0]+ ","+pMenor[1]+ "] "+matriz[pMenor[0],pMenor[1]].ToString());
                
            
        }
    }
}