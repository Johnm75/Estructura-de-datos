using System;
//Authors:María Camila Morales Galeano,María Paula Leiva Agudelo,Jhon Fredy Marciales Morales,Juandavid Ropero Prieto.
//Working day: Morning
//Group:239-2ª

namespace Problema_6
{
    class Problema_6
    {
        static void Main(string[] args)
        {
            int n;
            string dato;
            
            Console.WriteLine(" Por favor ingrese un número par entre 100 y 200: ");
            dato=Console.ReadLine();
            n = Convert.ToInt32(dato);

            if(n<100 || n>200){
                Console.WriteLine("El numero no está entre 100 y 200");
                return;
            }

            if(n % 2 != 0){
                Console.WriteLine("El numero es impar");
                return;
            }

            for(int i=n;i<=200;i++){
                if(i % 2 == 0){
                    Console.WriteLine(i);
                }
                
            }
            
        }
    }
}