/*
Create by: Maria Camila Morales Galeano, 
           Maria Paula Leiva Agudelo,
           Juan David Ropero Prieto,
           John Fredy Marciales Morales.
Group: 239-2A
Shift: day
*/

using System;
public class Punto11
{
 public static void Main(string[] args)
 { 
 int agua;
 int luz;
 int gas;
 int estrato;
 double precio1;
 double precio2;
 double precio3;

 Console.Write("Ingrese el estrato ");
 estrato = int.Parse(Console.ReadLine());
 Console.Write("Ingrese valor del servicio del agua ");
 agua = int.Parse(Console.ReadLine());
 Console.Write("Ingrese valor del servicio de la luz ");
 luz = int.Parse(Console.ReadLine());
 Console.Write("Ingrese valor del servicio del gas ");
 gas = int.Parse(Console.ReadLine());


 
 if (estrato == 1)
 {
    precio1 = agua * 0.2;
    precio2 = luz * 0.2;
    precio3 = gas * 0.2;
 Console.WriteLine("El descuento (20%) del precio del agua es {0}, de la luz es {1}, y gas {2} ", precio1, precio2, precio3);
 }
 
 if (estrato == 2)
 {
     precio1 = agua * 0.15;
    precio2 = luz * 0.15;
    precio3 = gas * 0.15;
 Console.WriteLine("El descuento (15%) del precio del agua es {0}, de la luz es {1}, y gas {2} ", precio1, precio2, precio3);
 }
 if (estrato == 3)
 {
     precio1 = agua * 0.09;
    precio2 = luz * 0.09;
    precio3 = gas * 0.09;
 Console.WriteLine("El descuento (9%) del precio del agua es {0}, de la luz es {1}, y gas {2} ", precio1, precio2, precio3);
 
 }
 }
}