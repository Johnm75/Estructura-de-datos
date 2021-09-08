using System;
//Authors:María Camila Morales Galeano,María Paula Leiva Agudelo,Jhon Fredy Marciales Morales,Juandavid Ropero Prieto.
//Working day: Morning
//Group:239-2ª

namespace Problema_4
{
    class Problema_4
    {
        static void Main(string[] args)
        {
            int n;
            double resultado=0;
            string dato;
            
            Console.WriteLine("Bienvenido usuario, Por favor ingrese un número entero positivo: ");
            dato=Console.ReadLine();
            n = Convert.ToInt32(dato);

            for(int i=1;i<=n;i++){
                resultado = resultado + (1.0/i);
                
            }
            Console.WriteLine("El resultado es: " +resultado);
        }
    }
}    
    
