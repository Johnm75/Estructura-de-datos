using System;
public class Punto10
//Creado por : Juan David Ropero, Jhon Fredy Marciales, Maria Paula Leiva,, Maria Camila Morales
//Grupo:239-2A
//Turno:Diario
{
//En Colombia se tienen 3 puntos de reparto de vacunas que se pretende funcionen de la siguiente manera. 
//Cada día, empezar con 1000 vacunas disponibles en cada puntoy a través deun programa que controla
// las entregas avisar si el inventario baja de 200 unidades, al final el programa de debe generar
// un reporte de la cantidad de vacunas utilizadas en cada punto.
 public static void Main(string[] args)
 { 
 int usadas1;
 int usadas2;
 int usadas3;
 int restante1;
 int restante2;
  int restante3;

 Console.Write("Ingrese el numero de vacunas usadas en el punto 1 de vacunacion ");
 usadas1 = int.Parse(Console.ReadLine());

 Console.Write("Ingrese el numero de vacunas usadas en el punto 2 de vacunacion ");
 usadas2 = int.Parse(Console.ReadLine());

  Console.Write("Ingrese el numero de vacunas usadas en el punto 3 de vacunacion ");
 usadas3 = int.Parse(Console.ReadLine());

 restante1 = 1000-usadas1;
 Console.WriteLine("Se usaron {0} vacunas en el punto 1 de vacunacion ", restante1);

 restante2 = 1000-usadas2;
 Console.WriteLine("Se usaron {0} vacunas en el punto 2 de vacunacion ", restante2);

 restante3 = 1000-usadas3;
 Console.WriteLine("Se usaron {0} vacunas en el punto 3 de vacunacion ", restante3);

if (restante1 < 200)
 {
 Console.WriteLine("ADVERTENCIA: Quedan menos de 200 unidades en el punto 1. ");
 }
 
 restante2 = 1000-usadas2;
 if (restante2 < 200)
 {
 Console.WriteLine("ADVERTENCIA: Quedan menos de 200 unidades en el punto 2. ");
 }
 
 restante3 = 1000-usadas3;
 if (restante3 < 200)
 {
 Console.WriteLine("ADVERTENCIA: Quedan menos de 200 unidades en el punto 3. ");
 }
 }
}