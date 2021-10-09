/*
Create by: John Fredy Marciales Morales.
Group: 239-2A
Shift: day
*/

/*
Escriba una rutina que reciba una Pila P de números flotantes y devuelva una nueva Pila,
pero con los elementos invertidos, es decir el último de la Pila P, pasará a ser el primero
de la nueva Pila Es de destacar que la Pila P no debe sufrir ningún tipo de cambio o
alteración.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Ejercicio_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<float> P = new Stack<float>();
            Stack<float> nuevaPila = new Stack<float>();
            int finalizar = 1;
            int PSize = 0;
            while (finalizar == 1)
            {
                Console.Write("Digite un número flotante: ");
                P.Push(Convert.ToSingle(Console.ReadLine()));
                PSize++;
                Console.WriteLine("Para ingresar un nuevo número, digite 1. De lo contrario, ingrese cualquier otro número.");
                finalizar = Convert.ToInt32(Console.ReadLine());
            }
            float[] dataPila = new float[PSize];
            dataPila = P.ToArray();
            
            for (int i = 0; i < PSize; i++)
            {
            nuevaPila.Push(Convert.ToSingle(dataPila[i]));
            Console.WriteLine(dataPila[i]);
            }
        }
    }
}
