using System;
//Authors:María Camila Morales Galeano,María Paula Leiva Agudelo,Jhon Fredy Marciales Morales,Juan david Ropero Prieto.
//Working day: Morning
//Group:239-2ª
namespace Problema8
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantidad = 0;
            double probabilidad =0 ;
            Random rnd = new Random();
            byte [] bytes = new byte [3];
            int numero = 0;
         
           
            Console.Write("Ingrese el numero maximo que estará en la loteria ");
            cantidad = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("A continuacion se seleccionaran 5 numeros al azar hasta {0} ", cantidad);

            for(int i = 1;  i <= 5; i++)
                {
                    
                  numero =rnd.Next(cantidad);
                  
                  Console.WriteLine(numero);

                }
            probabilidad = cantidad *(cantidad-1)*(cantidad-2)*(cantidad-3)*(cantidad-4);
            Console.WriteLine("La probabilidad de ganar la loteria es:");
            Console.WriteLine(probabilidad);
        }
    }
}