using System;
using System.Collections;
/*Escriba un programa que inserte nodos ordenadamente en una lista. La lista debe almacenar números enteros. 
El software debe leer una secuencia de números enteros de la entrada estándar hasta que se ingrese el número cero.*/

namespace Ejercicio_1
 {
     class program
     {
         static void Main(string[] args)
         {
             Stack miCola = new Stack();
             int opcion;
             do{
                Console.Clear();
                 opcion = menu();
                 switch (opcion)
                {
                     case 1: 
                         agregar(ref miCola); 
                         break;
                     case 2: 
                         imprimir(miCola); 
                         break;
                     case 3: break; 
                     default:                        
                         mensaje("ERROR: la opción no es valida. Intente de nuevo.");
                         break;
                 }
             }
             while(opcion!=5);
             mensaje("El programa a finalizado.");            
         }
         
         static void agregar( ref Stack cola )
         {
             Console.Write("\n>Ingrese valor: ");
             try
             {
                 int valor = Convert.ToInt32(Console.ReadLine());
                 if (valor > 99 || valor <= 0)
                 {
                     mensaje("Solo números del 1 al 99");
                 }
                 else
                 {
                     cola.Push(valor);
                     imprimir(cola);
                 }
             }
             catch {
                 mensaje("Error: Solo números del 1 al 99");
             }           
         } 
        
         
         static int menu()
         {

             Console.WriteLine("\n            Bienvenido a Miel\n");
             Console.WriteLine(" 1.- Agregar elemento.");
             Console.WriteLine(" 2.- Ver elementos de la pila.");
             Console.WriteLine(" 3.- Salir.");
             Console.Write(" JJ:> Ingresa tu opción: ");            
             try
             {
                 int valor = Convert.ToInt32( Console.ReadLine() );                
                 return valor;
             }
             catch {
                 return 0;
             }            
         }
 
         static void mensaje( String texto )
         {
             if (texto.Length > 0)
             {
                 Console.WriteLine("\n    =======================================================");
                 Console.WriteLine(" JJ:> {0}",texto);
                 Console.WriteLine(" =======================================================");
                 Console.WriteLine("\n    JJ:>Presione cualquier tecla para continuar...");
                 Console.ReadKey();
             }            
         }
 
         static void imprimir(Stack cola)
         {
             if (cola.Count > 0)
             {
                 Console.WriteLine("");
                 foreach (int dato in cola)
                 {
                     if( dato <10)
                         Console.WriteLine("0{0}", dato);
                     else
                         Console.WriteLine("{0}", dato);
        
                 }
                 Console.WriteLine("\nPresione cualquier tecla para continuar ...");
                 Console.ReadKey();
             }
             else 
             {
                 mensaje("La Cola esta vacía");                
             }
         }
     }
}

