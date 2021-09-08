/*
Create by: Maria Camila Morales Galeano, 
           Maria Paula Leiva Agudelo,
           Juan David Ropero Prieto,
           John Fredy Marciales Morales.
Group: 239-2A
Shift: day
*/

using System;
public class Punto10
{
 public static void Main(string[] args)
 { 
 int largo;
 int ancho;
 double precio;

 Console.Write("Ingrese el largo del terreno ");
 largo = int.Parse(Console.ReadLine());
 Console.Write("Ingrese el ancho del terreno ");
 ancho = int.Parse(Console.ReadLine());

 
 precio= largo*ancho;
 Console.WriteLine("El total del terreno {0} ", precio);
 
 if (precio > 400 && precio <= 499)
 {
 Console.WriteLine("El descuento del precio del terreno es del 10% ");
 }
 
 if (precio > 500 && precio <= 999)
 {
 Console.WriteLine("El descuento del precio del terreno es del 17%");
 }
 if (precio > 1000)
 {
 Console.WriteLine("El descuento del precio del terreno es del 25% ");
 
 }
 }
}