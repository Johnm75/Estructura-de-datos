/*
-Authors:
    María Camila Morales Galeano,
    María Paula Leiva Agudelo,
    Jhon Fredy Marciales Morales,
    Juan david Ropero Prieto.
-Working day: Morning
-Group:239-2ª
*/

using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ejercicios
{
    public class socios
    {
        private string nombre;
        private int antiguedad;
        public void socio ()
        {
            int numSocio;

            Console.WriteLine("Por favor ingrese el número de estudiantes:");
            numSocio=Convert.ToInt32(Console.ReadLine());
            
            int[,] matrizSocio= new int [numSocio,1];

            for (int filas = 0; filas < numSocio; filas++)
            {
                 Console.WriteLine("Ingrese el nombre del socio #" + (filas+1) + ":");
                 nombre=Console.ReadLine();
                 

                for (int columnas = 0; columnas < 1; columnas++)
                {
                    Console.Write("Ingrese la antiguedad = ");
                    
                    antiguedad = Int32.Parse(Console.ReadLine());
                    matrizSocio[filas, columnas] =(antiguedad);
                }
            }

            int indice=0;
            int mayor=0;
            for (int filas = 0; filas < numSocio; filas++)
            {

                if (antiguedad>mayor)
                {
                    mayor = antiguedad;
                    indice = filas;
                }
                
            }
            Console.WriteLine();
            Console.WriteLine(" El socio mas antiguo es  " + (indice) + " con: " + mayor);
            Console.WriteLine();
        }
    }
    public class Items
    {
        class club
        {

            static void Main(string[] args)
            {
            socios s = new socios();
            s.socio();
             
            }
        }
    }
}