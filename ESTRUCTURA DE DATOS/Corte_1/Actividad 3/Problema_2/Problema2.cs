//Authors:María Camila Morales Galeano,María Paula Leiva Agudelo,Jhon Fredy Marciales Morales,Juandavid Ropero Prieto.
//Working day: Morning
//Group:239-2ª

using System;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace C_
{
    class Problema2
    {
        static void Main(string[] args)
        {

            int n1;
         
          
            Console.WriteLine("Ingrese el numero del cual quiere imprimir el triangulo");
            n1=int.Parse(System.Console.ReadLine());
            
            if (n1==1 ){
                
                for (int i = 1; i <= n1; i++){
                
                    for (int y = 1; y <= n1 - i; y++){
                        Console.Write(" ");
                    }
                    for (int y = 1; y <= i; y++)
                    {
                        Console.Write(" *");
                    }
                    for (int y = 1; y <= i - 1; y++){
                    Console.Write(" ");
                    }
                    Console.WriteLine();
                }
            }
            else if ( n1==3 ){
                n1=n1-1;
                for (int i = 1; i <= n1; i++){
                
                    for (int y = 1; y <= n1 - i; y++){
                        Console.Write(" ");
                    }
                    for (int y = 1; y <= i; y++)
                    {
                        Console.Write(" *");
                    }
                    for (int y = 1; y <= i - 1; y++){
                    Console.Write(" ");
                    }
                    Console.WriteLine();
                }
            }
            else if ( n1==6 ){
                n1=n1-3;
                for (int i = 1; i <= n1; i++){
                
                    for (int y = 1; y <= n1 - i; y++){
                        Console.Write(" ");
                    }
                    for (int y = 1; y <= i; y++)
                    {
                        Console.Write(" *");
                    }
                    for (int y = 1; y <= i - 1; y++){
                    Console.Write(" ");
                    }
                    Console.WriteLine();
                }
            }
            else if ( n1==10 ){
                n1=n1-6;
                for (int i = 1; i <= n1; i++){
                
                    for (int y = 1; y <= n1 - i; y++){
                        Console.Write(" ");
                    }
                    for (int y = 1; y <= i; y++)
                    {
                        Console.Write(" *");
                    }
                    for (int y = 1; y <= i - 1; y++){
                    Console.Write(" ");
                    }
                    Console.WriteLine();
                }
            }
            else if (n1==15 ){
                n1=n1-10;
                for (int i = 1; i <= n1; i++){
                
                    for (int y = 1; y <= n1 - i; y++){
                        Console.Write(" ");
                    }
                    for (int y = 1; y <= i; y++)
                    {
                        Console.Write(" *");
                    }
                    for (int y = 1; y <= i - 1; y++){
                    Console.Write(" ");
                    }
                    Console.WriteLine();
                }
            }
            else if (n1==21 ){
                n1=n1-15;
                for (int i = 1; i <= n1; i++){
                
                    for (int y = 1; y <= n1 - i; y++){
                        Console.Write(" ");
                    }
                    for (int y = 1; y <= i; y++)
                    {
                        Console.Write(" *");
                    }
                    for (int y = 1; y <= i - 1; y++){
                    Console.Write(" ");
                    }
                    Console.WriteLine();
                }
            }
            else if (n1==28 ){
                n1=n1-21;
                for (int i = 1; i <= n1; i++){
                
                    for (int y = 1; y <= n1 - i; y++){
                        Console.Write(" ");
                    }
                    for (int y = 1; y <= i; y++)
                    {
                        Console.Write(" *");
                    }
                    for (int y = 1; y <= i - 1; y++){
                    Console.Write(" ");
                    }
                    Console.WriteLine();
                }
            }
            else if (n1==36 ){
                n1=n1-28;
                for (int i = 1; i <= n1; i++){
                
                    for (int y = 1; y <= n1 - i; y++){
                        Console.Write(" ");
                    }
                    for (int y = 1; y <= i; y++)
                    {
                        Console.Write(" *");
                    }
                    for (int y = 1; y <= i - 1; y++){
                    Console.Write(" ");
                    }
                    Console.WriteLine();
                }
            }
            else if (n1==45 ){
                n1=n1-36;
                for (int i = 1; i <= n1; i++){
                
                    for (int y = 1; y <= n1 - i; y++){
                        Console.Write(" ");
                    }
                    for (int y = 1; y <= i; y++)
                    {
                        Console.Write(" *");
                    }
                    for (int y = 1; y <= i - 1; y++){
                    Console.Write(" ");
                    }
                    Console.WriteLine();
                }
            }
            else if (n1==55 ){
                n1=n1-45;
                for (int i = 1; i <= n1; i++){
                
                    for (int y = 1; y <= n1 - i; y++){
                        Console.Write(" ");
                    }
                    for (int y = 1; y <= i; y++)
                    {
                        Console.Write(" *");
                    }
                    for (int y = 1; y <= i - 1; y++){
                    Console.Write(" ");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("no se pueden aplilar las latas en triangulo");
            }

            


        }
    }
}

