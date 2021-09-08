/*
Create by: Maria Camila Morales Galeano, 
           Maria Paula Leiva Agudelo,
           Juan David Ropero Prieto,
           John Fredy Marciales Morales.
Group: 239-2A
Shift: day
*/

/*
Problema 2:
Crear un programa que pida 10 diferentes números (positivos o negativos), evaluar la cantidad de 
números pares e impares. Realizar la suma de cada grupo y su promedio.
*/

using System;

namespace Problema_2
{
    class Problema_2
    {
        static void Main(string[] args)
        {   
            int numerosPares = 0;
            int numerosImpares = 0;
            int promedioPares = 0;
            int promedioImpares = 0;
            int sumaPares=0;
            int sumaImpares=0;
            
            int[] vector = new int[10];

            Console.WriteLine("\n|Bienvenido\n|Dígite 10 números, recuerde que pueden ser positvos o negativos.\n");

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Número " + (i+1) + ": ");
                vector[i] = int.Parse(Console.ReadLine());

                if(vector[i] % 2 == 0){
                    numerosPares++;
                    sumaPares += vector[i];
                }else{
                    numerosImpares++;
                    sumaImpares += vector[i];
                }
            }
            promedioPares = sumaPares / 10;
            promedioImpares = sumaImpares / 10;  
            
            Console.WriteLine("\nLa cantidad de números pares es: " + numerosPares);
            Console.WriteLine("La cantidad de númeos impares es: " + numerosImpares);
            
            Console.WriteLine("\nLa suma de los números pares es: " + sumaPares);
            Console.WriteLine("La suma de los números impares es: " + sumaImpares);   

            Console.WriteLine("\nEl promedio de los números pares es: " + promedioPares);
            Console.WriteLine("El promedio de los números impares es: " + promedioImpares + "\n");       
        }
    }
}