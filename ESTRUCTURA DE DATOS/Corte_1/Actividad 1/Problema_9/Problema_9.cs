/*
Create by: Maria Camila Morales Galeano
Group: 239-2A
Shift: day
*/

/*
Problema 9: 
Crea un programa que calcule el equivalente humano de la edad de un perro. Los 
dos primeros años de vida de un perro equivalen cada uno a diez y medio años 
humanos, y los siguientes años de vida de un perro equivalen cada uno a cuatro 
años humanos. 
*/

using System;

namespace Problema_9
{
    class Problema_9
    {
        static void Main(string[] args)
        {
            int edadPerro;  
            double edadHumana;          
            Console.Write("Ingrese la edad de un perro: ");
            edadPerro = Convert.ToInt32(Console.ReadLine());

            if(edadPerro <= 2){
                edadHumana = 10.5 * edadPerro;
            }else{
                edadHumana = 10.5 * 2;
                edadPerro -= 2;
                edadHumana += edadPerro * 4;
            }

            Console.WriteLine("La edad del perro es {0}",edadHumana);
            
        }
    }
}
