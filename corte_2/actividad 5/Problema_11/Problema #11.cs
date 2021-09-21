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
           /* De una empresa de transporte se quiere guardar el nombre de los conductores que tiene, y los kilómetros que conducen cada día de la semana. 
           ▪Para guardar esta información se van a utilizar dos arreglos:
           ▪Nombre: Vector para guardar los nombres de los conductores.
           ▪kms: Tabla para guardar los kilómetros que realizan cada día de la semana.
           ▪Se quiere generar un nuevo vector (“total_kms”) con los kilómetros totales que realza cada conductor.Al finalizar se debe mostrar la tabla con la lista de conductores*/
            int [] total_Kms;
            int[,] kilometros;
            string[] nombres;
            int numeroConductores;


            Console.Write("Ingrese la cantidad de conductores: ");
            numeroConductores=Convert.ToInt32(Console.ReadLine());

            kilometros = new int[numeroConductores,7];
            nombres = new string[numeroConductores];
            total_Kms = new int [numeroConductores];


            for (int fila = 0; fila < numeroConductores; fila++)
            {
                Console.Write("Ingrese el nombre del conductor #" +(fila+1) +": ");
                nombres[fila]=Console.ReadLine();

                    for (int columna = 0; columna < 7; columna++)
                     {
                         Console.Write("Ingrese los kilometros del dia #" +(columna+1) +": ");
                         kilometros[fila,columna]=Convert.ToInt32(Console.ReadLine());
                     }
                     Console.WriteLine();
            }
            for (int fila = 0; fila < kilometros.GetLength(0); fila++)
            {
                int total_suma_kms=0;
                for (int columnas = 0; columnas < kilometros.GetLength(1); columnas++)
                {
                    total_suma_kms= kilometros[fila,columnas]+ total_suma_kms;
                }
                total_Kms[fila]=total_suma_kms;
            }
            for (int fila = 0; fila < kilometros.GetLength(0); fila++)
            {
                Console.Write(nombres[fila]+": ");
                for (int columnas = 0; columnas < kilometros.GetLength(1); columnas++)
                {
                    Console.Write(kilometros[fila,columnas]+ "  ");
                }
                Console.Write(" el total es:"+total_Kms[fila]);
                Console.WriteLine("");
            }
        }
    }
}