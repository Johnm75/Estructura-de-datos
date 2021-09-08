/*
Create by: Maria Camila Morales Galeano, 
           Maria Paula Leiva Agudelo,
           Juan David Ropero Prieto,
           John Fredy Marciales Morales.
Group: 239-2A
Shift: day
*/

/*
Problema 3: 
Escriba un programa que pida dos números enteros mayores a 100 y que me dé la opción de calcular 
su: suma, resta, división o multiplicación desde un menú (si ingresan un número diferente (real, cero) o 
letra por favor indicarlo al usuario)
*/

using System;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool bandera = false;
            int option;
            double a = 0, b = 0;

            while(bandera == false){
                Console.Write("\nPor favor dígite el primer valor: ");
                a = Convert.ToDouble(Console.ReadLine());
                Console.Write("Por favor dígite el segundo valor: ");
                b = Convert.ToDouble(Console.ReadLine());
                
                if(a <= 100 || b <= 100){
                    Console.WriteLine("*los valores deben ser mayores a 100\n");
                }else{
                    bandera = true;
                }
            }

            Console.WriteLine("\n¡Bienvenido a Operaciones web, eliga entre las opciones de nuestro menú!");
            Console.WriteLine("1.Suma.");
            Console.WriteLine("2.Resta.");
            Console.WriteLine("3.Multiplicación.");
            Console.WriteLine("4.División.");
            Console.WriteLine("5.Salir.");
            Console.Write("-> ");
            option=Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1 : 
                    Console.WriteLine("El resultado de {0} + {1} = {2}",a,b,(a+b));
                    break;
                case 2 : 
                    Console.WriteLine("El resultado de {0} - {1} = {2}",a,b,(a-b));
                    break;
                case 3 : 
                    Console.WriteLine("El resultado de {0} * {1} = {2}",a,b,(a*b));
                    break;
                case 4 : 
                    Console.WriteLine("El resultado de {0} / {1} = {2}",a,b,(a/b));
                    break;

                case 5 : Console.WriteLine("\nGracias por usar Operaciones web\n");
                    break;
                default:Console.WriteLine("Dígito incorrecto, dígite un número de 1 a 5 dependiendo la opción del menú."); break;

            }

        }
    }
}
