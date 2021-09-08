//Authors:María Camila Morales Galeano,María Paula Leiva Agudelo,Jhon Fredy Marciales Morales,Juandavid Ropero Prieto.
//Working day: Morning
//Group:239-2ª

using System;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace C_
{
    class Program
    {
        static void Main(string[] args)
        {

            int n1;
         
          
            Console.WriteLine("Ingrese el numero del cual quiere imprimir el triangulo");
            n1=int.Parse(System.Console.ReadLine());

            for (int i = 1; i <= n1; i++){
                
                for (int y = 1; y <= i; y++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }


            


        }
    }
}

