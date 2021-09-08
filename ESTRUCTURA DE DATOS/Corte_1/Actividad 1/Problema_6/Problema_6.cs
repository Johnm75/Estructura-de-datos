/*
Create by: Maria Camila Morales Galeano
Group: 239-2A
Shift: day
*/

/*
Problema 6: 
Crea un programa que dado un número entero que designa un periodo de tiempo 
expresado en segundos, imprima el equivalente en días, horas, minutos y segundos.

*/

using System;

namespace Problema_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int segundos;
            double minutos;
            double horas;
            double dias;

            Console.WriteLine("Ingrese los segundos: ");
            segundos = Convert.ToInt32(Console.ReadLine());
            minutos = segundos / 60;
            horas = segundos / 3600;
            dias = segundos / 86400;

            Console.WriteLine("\nDías: " + dias);
            Console.WriteLine("Horas: " + horas);
            Console.WriteLine("Minutos: " + minutos);
            Console.WriteLine("Segundos: " + segundos + "\n");
            

        }
    }
}
