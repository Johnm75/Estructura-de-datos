/*
Create by: Maria Camila Morales Galeano
Group: 239-2A
Shift: day
*/

/*
Dada una variable “c” que contiene un carácter, escribe las expresiones que 
representen las siguientes afirmaciones: 
    a) c es una vocal. 
    b) c es una letra minúscula. 
    c) c es un símbolo del alfabeto.
*/

using System;

namespace Problema_8
{
    class Program
    {
        static void Main(string[] args)
        {
            char c;
            Console.Write("Ingrese un caracter: ");
            c = Console.ReadKey().KeyChar;

            if ((c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u') || 
                (c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U'))
            {
                Console.WriteLine("\n'{0}' es una vocal", c);
            }
            if (char.IsLower(c))
            {
                Console.WriteLine("'{0}' es una letra minuscula", c);
            }
            if (char.IsLetter(c))
            {
                Console.WriteLine("'{0}' es un simbolo del alfabeto\n", c);
                
            }

        }
    }
}
