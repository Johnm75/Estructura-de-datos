/*
Create by: Maria Camila Morales Galeano
Group: 239-2A
Shift: day
*/

/*
Problema 3: 
Escriba un programa que reciba cuatro calificaciones de un estudiante y devuelva 
el promedio y la máxima y la mínima calificación.
*/

using System;

namespace Problema_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double notaMenor = 999;
            double notaMayor = 0;
            double promedio = 0;
            Double[] notas = new Double[4];
            
            Console.WriteLine("");
            for(int i = 0; i < 4; i++){
                Console.Write("Ingrese nota "+(i+1)+": ");
                notas[i] = Convert.ToDouble(Console.ReadLine());
                promedio += notas[i];
                if(notas[i] > notaMayor){
                    notaMayor = notas[i];
                }
                if(notas[i] < notaMenor){
                    notaMenor = notas[i];
                }
            }
            promedio /= 4;
            Console.WriteLine("\nEl promedio de las calificaciones es {0}",promedio);
            Console.WriteLine("La calificacion minima es: {0}",notaMenor);
            Console.WriteLine("La calificacion maxima es: {0}\n",notaMayor);
           


        }
    }
}
