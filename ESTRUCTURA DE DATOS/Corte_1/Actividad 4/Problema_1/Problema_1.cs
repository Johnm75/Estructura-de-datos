//Authors:María Camila Morales Galeano,María Paula Leiva Agudelo,Jhon Fredy Marciales Morales,Juandavid Ropero Prieto.
//Working day: Morning
//Group:239-2ª
using System;

namespace Problema_1
{
    class Prblema_1
    {
        static void Main(string[] args)
        {
            int numMult,numDiv;
            int[] valores= new int [15];
            Console.WriteLine("\n Bienvenido a miel.com \n");
            rellenar(valores);
            Console.Write("\nPor favor ingrese un número para realizar la multiplación: ");
            numMult=Convert.ToInt32(Console.ReadLine());
            multiplicar(valores,numMult);
            mostrar(valores);
            Console.Write("Por favor ingrese un número para realizar la división: ");
            numDiv=Convert.ToInt32(Console.ReadLine());
            dividir(valores,numDiv);
            mostrar(valores);

        }
        public static void mostrar(int[] arreglo){

            for (int i = 0; i < arreglo.Length; i++)
            {
                Console.WriteLine($"arreglo[{i}]: {arreglo[i]}");
            }
        }

        public static void rellenar (int[] arreglo){
            
            for (int j = 0; j < arreglo.Length; j++)
            {
                Console.Write($"Por favor ingrese número {j+1}: ");
                arreglo[j]=int.Parse(Console.ReadLine());
            }
        }

        public static void multiplicar (int[] arreglo,int num){
            for (int i = 0; i < arreglo.Length; i++)
            {
                arreglo[i]*=num;
            }

        }
        public static void dividir (int[] arreglo,int num){

            for (int i = 0; i < arreglo.Length; i++)
            {
                arreglo[i]/=num;
                
            }
            
        }
    }
}
