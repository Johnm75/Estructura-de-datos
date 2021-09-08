using System;
public class Problema_11

//Creado por : Juan David Ropero, Jhon Fredy Marciales, Maria Paula Leiva,, Maria Camila Morales
//Grupo:239-2A
//Turno:Diario
{
//Se registran X cantidad de empleados de una empresa Número de legajo, sueldo, sexo 
//(1=femenino y 2=masculino). Mostrar cuantas mujeres ganan más de $1.000.000 pesos y cuantos hombres 
//ganan menos de $900.000, realizar la suma de la cantidad de dinero que tienen las mujeres y la 
//cantidad de dinero para los hombres.
 public static void Main(string[] args)
 { 
 int id;
 int sueldo = 0;
 int sexo;
 int sueldo2 = 0 ;
 int totalf = 0;
 int totalm = 0;
 int empleados = 0;
 int tf = 0;
 int tm = 0;
Console.Write("Ingrese el numero de empleados ");
 empleados = Convert.ToInt32(Console.ReadLine());

for(int i = 0;  i < empleados; i++)
{
 Console.Write("Ingrese su numero de C.c. ");
 id = int.Parse(Console.ReadLine());

  Console.Write("Ingrese su sexo (1=femenino y 2=masculino) ");
 sexo = int.Parse(Console.ReadLine());

if (sexo == 1)
 {
 Console.Write("Ingrese su sueldo ");
 sueldo = int.Parse(Console.ReadLine());

  if (sueldo > 1000000)
  {
    totalf= totalf+ 1;
    
  }
 }
 tf=tf+sueldo;
 if (sexo == 2)
 {
     Console.Write("Ingrese su sueldo ");
 sueldo2 = int.Parse(Console.ReadLine());

  if (sueldo2 < 900000)
  {
totalm = totalm + 1;
  } 
 }
 tm=tm+sueldo2;
 }
 

 Console.WriteLine("Cantidad de mujeres que ganan mas de 1.000.000:");
Console.WriteLine(totalf);
 Console.WriteLine("Cantidad de hombres que ganan menos de 900.000:");
 Console.WriteLine(totalm);
 Console.WriteLine("La suma de los sueldos de las mujeres es:");
 Console.WriteLine(tf);
  Console.WriteLine("La suma de los sueldos de los hombres es:");
 Console.WriteLine(tm);
 }
 }