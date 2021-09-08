using System;
//Authors:María Camila Morales Galeano,María Paula Leiva Agudelo,Jhon Fredy Marciales Morales,Juandavid Ropero Prieto.
//Working day: Morning
//Group:239-2ª
namespace Problema7
{
    class Program
    {
        static void Main(string[] args)
        {
          int cantidad = 0;
            int promedio = 0;
            int suma = 0;
            int menor = 0;
            int altura = 0;
            int mayor =0;
           
            Console.Write("Ingrese el numero de personas ");
            cantidad = Convert.ToInt32(Console.ReadLine());

            for(int i = 1;  i <= cantidad; i++)
                {
                  Console.Write("Ingrese la altura");
                  altura = int.Parse(Console.ReadLine());
                  suma += altura;
                  promedio = suma/cantidad;
    
                   if (altura < promedio)
                       {
                          menor = menor + 1;
                       }
                    if ( altura > promedio)
                    {
                          mayor = mayor +1;
                    }
                }
            Console.WriteLine("Cantidad de gente con la altura mas baja que el promedio:");
            Console.WriteLine(mayor);
            Console.WriteLine("Cantidad de gente con la altura mas alta que el promedio:");
            Console.WriteLine(menor);
        }
    }
}