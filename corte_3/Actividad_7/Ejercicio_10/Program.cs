/*
Create by: John Fredy Marciales Morales.
Group: 239-2A
Shift: day
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace C_8octubre
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Queue<float> C = new Queue<float>();
            Queue<float> nuevaCola = new Queue<float>();
            int finalizar = 1;
            int CSize = 0;
            while (finalizar == 1)
            {
                Console.Write("Digite un número flotante: ");
                C.Enqueue(Convert.ToSingle(Console.ReadLine()));
                CSize++;
                Console.WriteLine("Para ingresar un nuevo número, digite 1. De lo contrario, ingrese cualquier otro número.");
                finalizar = Convert.ToInt32(Console.ReadLine());
            }
            float[] dataCola = new float[CSize];
            dataCola = C.ToArray();
            for (int i = CSize-1; i >= 0; i--)
            {
                nuevaCola.Enqueue(Convert.ToSingle(dataCola[i]));
                Console.WriteLine(dataCola[i]);
            }
        }

    }
}
