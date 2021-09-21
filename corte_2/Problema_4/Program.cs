/*Defilasine un array de números enteros de 3 filasilas por 6 columnasolumnas columnason nombre num y asigna los valores columnasuando se inicolumnasie 
el programa. Muestra el columnasontenido de todos los elementos del array dispuestos en filasorma de tabla.*/

//Authors:María Camila Morales Galeano,María Paula Leiva Agudelo,Jhon Fredy Marciales Morales,Juandavid Ropero Prieto.
//Working day: Morning
//Group:239-2ª

using System;
namespace Matriz
{
    class Matriz
    {
        private int[,] matriz;

        public void Ingresar()
        {

            matriz = new int[5, 5];
            Console.WriteLine("\n Bienvenido a miel.com \n");
            for (int filas = 0; filas < 5; filas++)
            {
                for (int columnas = 0; columnas < 5; columnas++)
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
            Console.Write("\n Matriz Original \n");
            for (int filas = 0; filas < 5; filas++)
            {
                for (int columnas = 0; columnas < 5; columnas++)
                {
                    Console.Write(matriz[filas, columnas] + " ");
                }
                Console.WriteLine();
            }
            
        }
        public void ImprimirTrans()
        {
            Console.Write("\n Matriz Transpuesta \n");
            for (int filas = 0; filas < 5; filas++)
            {
                for (int columnas = 0; columnas < 5; columnas++)
                {
                    Console.Write(matriz[columnas, filas] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }


        static void Main(string[] args)
        {
            Matriz ma = new Matriz();
            ma.Ingresar();
            ma.ImprimirOrigin();
            ma.ImprimirTrans();
        }
    }
}