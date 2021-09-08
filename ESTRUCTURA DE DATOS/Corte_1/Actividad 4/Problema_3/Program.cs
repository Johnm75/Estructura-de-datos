//Authors:María Camila Morales Galeano,María Paula Leiva Agudelo,Jhon Fredy Marciales Morales,Juandavid Ropero Prieto.
//Working day: Morning
//Group:239-2ª
using System;

namespace Problema_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] valores;

            Console.Write("\nBienvenido a miel.com\n");
            Console.Write("Por favor ingrese el valor del tamaño del array:");
            int tamano=Convert.ToInt32(Console.ReadLine());
            valores=new int[tamano];

            Console.WriteLine("Por favor ingrese el valor del rango: ");
            Console.Write("->");
            int numIncial=Convert.ToInt32(Console.ReadLine());
            Console.Write("->");
            int numFinal=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            string mayorMenor=numAle(valores, numIncial,numFinal);
            mostrar(valores);
            Console.WriteLine(mayorMenor);

        }
        public static void mostrar(int[] valor){
            Console.WriteLine($"Los números primos son: ");
            for (int i = 0; i < valor.Length; i++)
            {
                Console.WriteLine(valor[i]);

            }

        }
        private static string  numAle(int[] valor,int numInicial,int numFinal){
            Random numAleatorio=new Random();
            int numMayor=0;
            int numMenor=9999;
            int contador=0;
            int num;
            for (int i = 0; i < valor.Length; i++)
            {
                do{

                
                 num=numAleatorio.Next(numInicial,numFinal);
                 contador=0;
                 for (int j = 1; j <= num; j++)
                 {
                    if(num%j==0){
                        contador++;
                    }

                 }
                
                }while (contador!=2);
                valor[i]=num;
                if(numMayor<valor[i]){
                    numMayor=valor[i];
                }  
                if(numMenor>valor[i]){
                    numMenor=valor[i];
                }

            }
            string mensaje= $"El número mayor es:{numMayor}\nEl número menor es:{numMenor}";
            return mensaje;
            

        }



    }
}
