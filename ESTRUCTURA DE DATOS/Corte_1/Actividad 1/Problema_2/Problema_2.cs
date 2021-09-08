/*
Create by: Maria Camila Morales Galeano
Group: 239-2A
Shift: day
*/

/*
Problema 2: 
En un videoclub se ofrece la promoción de llevarse tres películas por el precio de 
las dos más baratas. Haga un programa que, dados los tres precios de las películas, 
determine la cantidad a pagar.
*/

using System;

namespace Problema_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double precioPeli1;
            double precioPeli2;
            double precioPeli3;
            double cantPagar;

            Console.WriteLine("\n***VideoClub***\n");
            Console.Write("Ingrese los precios de las peliculas: ");
            Console.Write("1. Pelicula: ");
            precioPeli1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("2. Pelicula: ");
            precioPeli2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("3. Pelicula: ");
            precioPeli3 = Convert.ToDouble(Console.ReadLine());


            if((precioPeli1 < precioPeli2 || precioPeli2 < precioPeli1) && (precioPeli1 < precioPeli3 && precioPeli2 < precioPeli3)){
                cantPagar = precioPeli1 + precioPeli2;
                Console.WriteLine("La cantidad a pagar es {0}",cantPagar);

            }else if((precioPeli2 < precioPeli3 || precioPeli3 < precioPeli2) && (precioPeli2 < precioPeli1 && precioPeli3 < precioPeli1)){
                cantPagar = precioPeli2 + precioPeli3;
                Console.WriteLine("La cantidad a pagar es {0}",cantPagar);

            }else if((precioPeli1 < precioPeli3 || precioPeli3 < precioPeli1) && (precioPeli1 < precioPeli2 && precioPeli3 < precioPeli2)){
                cantPagar = precioPeli1 + precioPeli3;
                Console.WriteLine("La cantidad a pagar es {0}",cantPagar);
                
            }
        }
    }
}
