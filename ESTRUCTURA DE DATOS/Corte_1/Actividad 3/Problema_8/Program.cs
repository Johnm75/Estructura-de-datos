/*
Create by: Maria Camila Morales Galeano, 
           Maria Paula Leiva Agudelo,
           Juan David Ropero Prieto,
           John Fredy Marciales Morales.
Group: 239-2A
Shift: day
*/

/*
Problema 8:
Realizar un programa que pida dos números y presente por pantalla la ecuación de segundo grado que tiene por 
soluciones estos dos números. Ejemplo: 5 y -3, la ecuación sería (x-5) (x+3) = x2 -2x-15, los coeficientes son 1, -2 
y -15. El programa permitirá repetir esta operación tantas veces como el usuario quiera, introduciendo números 
diferentes, hasta que decida terminar el programa (por ejemplo pulsando ‘S’).
*/

using System;

namespace Problema_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1;
            int numero2 = 0;
            string signo = "";
            string signo2 = "";
            char whileLoop = 'p';
            
            while(whileLoop != 'S'){

            Console.Write("\n\nIngrese un número: ");
            numero1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese un número: ");
            numero2 = Convert.ToInt32(Console.ReadLine());
            int form = numero1 + numero2;
            int form2 = numero1 * numero2;
            
            if(form > 0){
                signo = "+";
            }else{
                signo = "";
            }
            
            if(form2 > 0){
                signo2 = "+";
            }else{
                signo2 = "";
            }

            Console.WriteLine($"->La ecuación de segundo grado es: x{1*2} {signo} {form}x {signo2} {form2}");

            Console.Write("¿Desea terminar el programa? S/N: ");
            whileLoop = Console.ReadKey().KeyChar;

            }
        }
    }
}
