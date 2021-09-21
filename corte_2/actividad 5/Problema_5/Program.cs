/*Realice un programa que al recibir como datos dos arreglos bidimensionales enteros, calcule la suma del arreglo 
1 más la transpuesta del arreglo 2 y almacene el resultado en otro arreglo bidimensional.*/

//Authors:María Camila Morales Galeano,María Paula Leiva Agudelo,Jhon Fredy Marciales Morales,Juandavid Ropero Prieto.
//Working day: Morning
//Group:239-2ª
using System;
namespace Matriz
{
    class Matriz
    {
        private int[,] matriz;
        private int[,] matrizResul;

        public void Ingresar()
        {

            matriz = new int[3, 3];
            matrizResul = new int[3, 3];

            Console.WriteLine("\n Bienvenido a miel.com \n");
            for (int filas = 0; filas < 3; filas++)
            {
                for (int columnas = 0; columnas < 3; columnas++)
                {
                    Console.Write("Ingrese el número de la posición ["+(filas+1)+","+(columnas+1)+"]: ");
                    string linea;
                    linea = Console.ReadLine();
                    matriz[filas, columnas] = int.Parse(linea);
                }
            }
        }

        public void ImprimirOrigin()
        {
            Console.Write("\n Matriz Original: \n");
            for (int filas = 0; filas < 3; filas++)
            {
                for (int columnas = 0; columnas < 3; columnas++)
                {
                    Console.Write(matriz[filas, columnas] + " ");
                }
                Console.WriteLine();
            }
            
        }
        public void ImprimirTrans()
        {
            Console.Write("\n Matriz Transpuesta: \n");
            for (int filas = 0; filas < 3; filas++)
            {
                for (int columnas = 0; columnas < 3; columnas++)
                {
                    Console.Write(matriz[columnas, filas] + " ");
                }
                Console.WriteLine();
            }
            for (int filas = 0; filas < 3; filas++)
            {
                for (int columnas = 0; columnas < 3; columnas++)
                {
                    matrizResul[filas,columnas]=matriz[filas, columnas]+matriz[columnas, filas];
                }
            }
        }
        public void ImprimirSuma()
        {
            Console.WriteLine("\n La suma de la Matriz Original y Matriz Transpuesta es: ");
            for (int filas = 0; filas < 3; filas++)
            {
                Console.Write("\n");
                for (int columnas = 0; columnas < 3; columnas++)
                {
                    Console.Write(matrizResul[filas,columnas]+"  ");

                }
            }

            Console.ReadKey();
        }


        static void Main(string[] args)
        {
            Matriz ma = new Matriz();
            ma.Ingresar();
            ma.ImprimirOrigin();
            ma.ImprimirTrans();
            ma.ImprimirSuma();
        }
    }
}