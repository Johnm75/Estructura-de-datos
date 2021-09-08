//Authors:María Camila Morales Galeano,María Paula Leiva Agudelo,Jhon Fredy Marciales Morales,Juandavid Ropero Prieto.
//Working day: Morning
//Group:239-2ª
using System;

namespace Problema_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] valores;

            Console.Write("\nBienvenido a miel.com\n");
            Console.Write("Por favor ingrese el valor del tamaño del array:");
            int tamano=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            valores=new int[tamano];
            rellenar(valores);
            mostrar(valores);



        }
        public static void rellenar(int[] valor){
            for (int i = 0; i < valor.Length; i++)
            {
                valor[i]= numAle();
                
            }
        }
        public static void mostrar(int[] valor){
            int suma=0;
            for (int i = 0; i < valor.Length; i++)
            {
                Console.WriteLine(valor[i]);
                suma +=valor[i];
            }
            Console.WriteLine($"El resultado de la suma es: {suma}");

        }


        private static int  numAle(){
            Random numAleatorio=new Random();
            return numAleatorio.Next(0,9);
        }

    }
}
