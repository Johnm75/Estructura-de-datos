/*
Create by: Maria Camila Morales Galeano
Group: 239-2A
Shift: day
*/

/*
Problema 4:
Crea un array de números de 100 posiciones, que contendrá los números del 1 al 100. 
Obtén la suma de todos ellos y la media del array
*/

using System;

namespace Problema_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[100];
            int suma = 0;
            double media = 0;

            for (int i = 0; i < 100; i++)
            {
                numeros[i] = i+1;
                suma += numeros[i];
            }
            media = suma / 100;

            Console.WriteLine("la suma de los elementos del array es: "+suma);
            Console.WriteLine("la media de los elementos del array es: "+media);
            
        }
    }
}
