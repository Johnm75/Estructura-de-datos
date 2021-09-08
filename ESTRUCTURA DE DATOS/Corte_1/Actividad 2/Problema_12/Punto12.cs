/*
Create by: Maria Camila Morales Galeano, 
           Maria Paula Leiva Agudelo,
           Juan David Ropero Prieto,
           John Fredy Marciales Morales.
Group: 239-2A
Shift: day
*/

using System;
public class Punto12

{
 public static void Main(string[] args)
 { 
 int largo;
 int precio;
 int cant;
 double total;
 double total2;

 Console.Write("Ingrese el largo del cable ");
 largo = int.Parse(Console.ReadLine());
 Console.Write("Ingrese el precio del cable ");
 precio = int.Parse(Console.ReadLine());
 Console.Write("Ingrese la cantidad de cables de esa misma medida ");
 cant = int.Parse(Console.ReadLine());
 
total = precio * cant;
 Console.WriteLine("El total del cable {0} ", precio);
 
 if (largo < 20 )
 {
 Console.WriteLine("No hay ningun descuento, el precio total es {0}", total);
 }
 
 if (largo >= 20 && largo <=40)
 {
     total2= total * 0.05;
 Console.WriteLine("El descuento del precio del cable es del 5% = {0}", total2);
 }
 if (largo >= 41)
 {
 total2= total * 0.12;
 Console.WriteLine("El descuento del precio del cable es del 12% = {0}", total2);
 }
 }
}