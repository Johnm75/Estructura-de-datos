/*En la clase de estructuras de datos asiste un grupo de N alumnos. El profesor de dicha asignatura aplica 3 exámenes. 
Realice un programa que genere un array de N alumnos y sus 3 calificaciones y que calcule e imprima:
oEl promedio de calificaciones de cada alumno.
oEl promedio general de grupo.
oEl número del estudiante que tuvo el mayor promedio de calificación.*/

//Authors:María Camila Morales Galeano,María Paula Leiva Agudelo,Jhon Fredy Marciales Morales,Juandavid Ropero Prieto.
//Working day: Morning
//Group:239-2ª
using System;

namespace promedio
{
    class promedio
    {

        public static void Main (string[] args)
        {
            int numEstudiante;

            Console.WriteLine("\n Bienvenido a miel.com \n");
            
            Console.WriteLine("Por favor ingrese el número de estudiantes:");
            numEstudiante=Convert.ToInt32(Console.ReadLine());

            int[,] matrizEstudiante= new int [numEstudiante,3];

            for (int filas = 0; filas < numEstudiante; filas++)
            {
                 Console.WriteLine("Estudiante #" + (filas+1) + ":");

                for (int columnas = 0; columnas < 3; columnas++)
                {
                    Console.Write("Ingrese la calificación " +(columnas+1)+ " = ");
                    string linea;
                    linea = Console.ReadLine();
                    matrizEstudiante[filas, columnas] = int.Parse(linea);
                }
            }

            int[] promedioEstudiante = new int [numEstudiante];
            int indice=0;
            int mayor=0;
            for (int filas = 0; filas < numEstudiante; filas++)
            {
                int suma = 0;

                for (int columnas = 0; columnas < 3; columnas++)
                {
                    suma += matrizEstudiante [filas,columnas];
                }
                int promedioM = suma/3;
                promedioEstudiante [filas]= promedioM;
                if (promedioM>mayor)
                {
                    mayor = promedioM;
                    indice = filas;
                }
                
            }
            Console.WriteLine();
            for (int i = 0; i < promedioEstudiante.Length; i++)
            {
                Console.WriteLine("> El promedio del estudiante #" +(i+1)+ " es :"+ promedioEstudiante[i]);
            }
            Console.WriteLine();

            double sumatoria = 0;
		    foreach(double calificacion in matrizEstudiante){
			sumatoria += calificacion;
		    }
		    double promedio = sumatoria / matrizEstudiante.Length;
            Console.WriteLine("> Promedio del curso: " + promedio);
            Console.WriteLine("> El estudiante con el mayor promedio es el número  " + (indice+1) + " con: " + mayor);
            Console.WriteLine();
        
        }
    }
}