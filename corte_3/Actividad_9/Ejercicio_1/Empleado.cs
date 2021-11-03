/*
-Authors:
    María Camila Morales Galeano,
    María Paula Leiva Agudelo,
    Jhon Fredy Marciales Morales,
    Juan david Ropero Prieto.
-Working day: Morning
-Group:239-2ª
*/

using System;

namespace Ejercicio_1
{
    class Empleado
    {
        private string nombre;
        private double sueldo;
        

        public Empleado()
        {
            Console.Write("Ingrese el nombre del empleado: ");
            nombre = Console.ReadLine();

            Console.Write("Ingrese el sueldo del empleado: ");
            sueldo = Convert.ToDouble(Console.ReadLine());

        }
        static void Main(string[] args)
        {
            Empleado obj = new Empleado();
            obj.imprimir();
            obj.impuesto();
        }

         void imprimir()
        {
            Console.WriteLine("\nNombre: " + nombre);
            Console.WriteLine("Sueldo: " + sueldo);
        }
        void impuesto()
        {
            if (sueldo > 3000)
            {
                Console.WriteLine($"\n->El empleado {nombre} debe pagar impuestos.\n");
            }
        }
    }
}
