/*
Create by: Maria Camila Morales Galeano
Group: 239-2A
Shift: day
*/

/*
Problema 6:
Crea un array de números de un tamaño pasado por teclado, el array contendrá números 
aleatorios entre 1 y 300 y mostrar aquellos números que acaben en un dígito que nosotros 
le indiquemos por teclado (debes controlar que se introduce un numero correcto), estos 
deben guardarse en un nuevo array.
Por ejemplo, en un array de 10 posiciones e indicamos mostrar los números acabados en 
5, podría salir 155, 25, etc.
*/

using System;

namespace Problema_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int tamano;
            int[] numeros;
            int[] numerosTerminados;            
            int cont = 0;
            int numTerminado;
            string num;
            string numTerminadoS;
            Random numAleatorio = new Random();

            Console.Write("\nDigite el tamaño del vector: ");
            tamano = Convert.ToInt32(Console.ReadLine());
            numeros = new int[tamano];
            numerosTerminados = new int[tamano];

            Console.Write("Ingrese un digito (0-9) para buscar lo números terminados en el: ");            
            numTerminado = Convert.ToInt32(Console.ReadLine());
            numTerminadoS = numTerminado + "";
            Console.WriteLine("\nNumeros aletorios: ");
            if(numTerminado >= 0 && numTerminado <= 9){
               
                for (int i = 0; i < numeros.Length; i++)
                {
                    numeros[i] = numAleatorio.Next(1, 300);
                    Console.Write(numeros[i] + " ");
                    num = numeros[i] + "";
                    
                    if(num.EndsWith(numTerminadoS)){
                        numerosTerminados[cont] = numeros[i];
                        cont++;
                    }                    
                }
                Console.WriteLine("\n\nNumeros terminados en " + numTerminado + ":");
                for (int i = 0; i < cont; i++)
                {
                    Console.Write(numerosTerminados[i] +" ");
                }
                Console.WriteLine("\n");
            }else{
                Console.WriteLine("\nEl número ingresado no esta dentro del rango especificado.\n");
            }      
        }
    }
}
