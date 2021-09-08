/*
Create by: Maria Camila Morales Galeano
Group: 239-2A
Shift: day
*/

/*
Problema 5: 
Calcule la raíz cuadrada de un número dado. Recuerde que se debe validar que el 
número sea positivo.
*/

using System;

namespace Problema_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Double numero;
            Console.Write("\nIngrese un número: ");
            numero = Convert.ToDouble(Console.ReadLine());
            if(numero >= 0){
                Console.WriteLine("\nLa raiz cuadrada de {0} es {1}\n",numero,Math.Round(Math.Sqrt(numero),2));
            }else{
                Console.WriteLine("\nEL numero es negativo. vuelva a intentarlo...\n");
                
            }
            
            
        }
    }
}
