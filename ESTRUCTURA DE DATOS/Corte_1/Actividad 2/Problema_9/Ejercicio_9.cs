using System;
//Authors:María Camila Morales Galeano,María Paula Leiva Agudelo,Jhon Fredy Marciales Morales,Juandavid Ropero Prieto.
//Working day: Morning
//Group:239-2ª

namespace Ejercicio_9
{
    class Problema_9_2
    {
        static void Main(string[] args)
        {
            string option;
            double a,b;
            double pi=3.141516;
 

            Console.WriteLine("Bienvenido a área de un triangulo y circulo web, eliga entre las opciones de nuestro menú C para área circulo y T para área triángulo:");
            Console.WriteLine("C.Área de un circulo.");
            Console.WriteLine("T.Área de un triangulo.");
            Console.WriteLine("E.Salir.");
            option=Console.ReadLine();
            option = option.ToUpper();
            Console.WriteLine(" ");
            switch (option)
            {
                case "T" : 
                    Console.WriteLine("Por favor dígite el valor de la base del triángulo:"); 
                    a=Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Porfavor dígite el valor de la altura del triángulo");
                    b=Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine($"El resultado de {a} * {b} / 2 = {(a*b/2)}");
                    break;
                case "C" : Console.WriteLine("Por favor dígite el valor del radio del circulo:"); 
                        b=Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"El resultado de {b} * {b} * {pi}  = {(pi*(b*b))}");
                        break;
                case "E": Console.WriteLine("Gracias por usar área de un triangulo y circulo web");
                        break;
                default:Console.WriteLine("Palabra incorrecta, dígite T para área triangulo y C para área circulo."); break;

            }

        }
    }
}
