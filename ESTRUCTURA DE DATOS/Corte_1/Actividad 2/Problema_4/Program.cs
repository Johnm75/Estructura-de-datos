/*
Create by: Maria Camila Morales Galeano, 
           Maria Paula Leiva Agudelo,
           Juan David Ropero Prieto,
           John Fredy Marciales Morales.
Group: 239-2A
Shift: day
*/

using System;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Problema_4
{
    class Program
    {
        static void Main(string[] args)
        {

            int n1,n2,n3,n4,n5,n6,n7,n8,n9,n10;
            List<int> Lista=new List<int>();
          
            Console.WriteLine("Ingrese el numero 1: ");
            n1=int.Parse(System.Console.ReadLine());
            Lista.Add(n1);
            Console.WriteLine("Ingrese el numero 2: ");
            n2=int.Parse(System.Console.ReadLine());
            Lista.Add(n2);
            Console.WriteLine("Ingrese el numero 3: ");
            n3=int.Parse(System.Console.ReadLine());
            Lista.Add(n3);
            Console.WriteLine("Ingrese el numero 4: ");
            n4=int.Parse(System.Console.ReadLine());
            Lista.Add(n4);
            Console.WriteLine("Ingrese el numero 5: ");
            n5=int.Parse(System.Console.ReadLine());
            Lista.Add(n5);
            Console.WriteLine("Ingrese el numero 6: ");
            n6=int.Parse(System.Console.ReadLine());
            Lista.Add(n6);
            Console.WriteLine("Ingrese el numero 7: ");
            n7=int.Parse(System.Console.ReadLine());
            Lista.Add(n7);
            Console.WriteLine("Ingrese el numero 8: ");
            n8=int.Parse(System.Console.ReadLine());
            Lista.Add(n8);
            Console.WriteLine("Ingrese el numero 9: ");
            n9=int.Parse(System.Console.ReadLine());
            Lista.Add(n9);
            Console.WriteLine("Ingrese el numero 10: ");
            n10=int.Parse(System.Console.ReadLine());
            Lista.Add(n10);
            Console.WriteLine("los numeros que ingreso en orden desendente son: ");
            int[] A= Lista.ToArray();
            Array.Sort(A);
            Array.Reverse(A);
            foreach(int value in A){
                Console.WriteLine(value);
                Console.WriteLine(' ');
            }


        }
    }
}

