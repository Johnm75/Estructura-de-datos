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

namespace prueba
{
   public class Operaciones
    {
        private int num1;
        private int num2;
        
        public Operaciones(){
            Console.WriteLine("Ingrese dos números:");
            num1 =int.Parse(Console.ReadLine());
            num2 =int.Parse(Console.ReadLine());

        }
        static void Main(string[] args)
        {
            Operaciones obj = new Operaciones();
            obj.sumar();
            obj.restar();
            obj.multiplicar();
            obj.dividir();
            
        }
        public void sumar()
        {
            Console.WriteLine("suma: " + (num1 + num2));
        }
        public void restar()
        {
            Console.WriteLine("resta: " +(num1 - num2));
        }
        public void multiplicar()
        {
            Console.WriteLine("producto: " +(num1 * num2));
        }
        public void dividir()
        {
            Console.WriteLine("división: " +(num1 / num2));
        }
    }
}
