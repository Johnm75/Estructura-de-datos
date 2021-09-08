/*
Create by: Maria Camila Morales Galeano
Group: 239-2A
Shift: day
*/

/*
Problema 4: 
Considere siguiente proceso repetitivo para un número entero dado: si el número 
es 1, el proceso termina. De lo contrario, si es par se divide entre 2, y si es impar 
se multiplica por 3 y se le suma 1. Si empezamos con 6, por ejemplo, obtendremos 
la sucesión de números 6, 3, 10, 5, 16, 8, 4, 2, 1. La conjetura de Collatz dice que, 
a partir de cualquier número inicial, la sucesión obtenida siempre termina en 1. 
Escriba un programa que permita verificar la conjetura de Collatz para cualquier 
entero dado, y que imprima la secuencia correspondiente. 
*/

using System;

namespace Problema_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean prueba = false;
            int numero;
             Console.Write("Ingrese un número: ");
             numero = Convert.ToInt32(Console.ReadLine());

            while(numero != 1){
                if(numero%2 == 0 && numero != 1){
                    numero /= 2;
                    Console.Write(numero+" ");
                }
                else if(numero%2 != 0 && numero != 1){
                    numero = (numero * 3) + 1;
                    Console.Write(numero+" ");
                    
                }
            }

        }
    }
}
