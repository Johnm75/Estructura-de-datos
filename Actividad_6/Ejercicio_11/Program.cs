/*
Create by: John Fredy Marciales Morales.
Group: 239-2A
Shift: day
*/

/*
Escriba una rutina que reciba una Pila P de números flotantes y devuelva una Cola,
manteniendo el orden de salida de los elementos. Es de destacar que la Pila P no debe
sufrir ningún tipo de cambio o alteración.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<float> P = new Stack<float>();
            Queue<float> nuevaCola = new Queue<float>();
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
            float[] data = new float[PSize];
            data = P.ToArray();
            for (int i = PSize-1; i >= 0; i--)
            {
                nuevaCola.Enqueue(Convert.ToSingle(data[i]));
                Console.WriteLine(data[i]);
            }
        }
    }
}