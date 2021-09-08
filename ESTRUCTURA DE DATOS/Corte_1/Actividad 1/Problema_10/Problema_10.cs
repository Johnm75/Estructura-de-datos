/*
Create by: Maria Camila Morales Galeano
Group: 239-2A
Shift: day
*/

/*
Problema 10:
Crea un programa que pida una contraseña por teclado e indique si es correcta o 
incorrecta. La contraseña correcta es “iloveyou123”. Una vez funcione, añade 
código para que si la contraseña era incorrecta la pida de nuevo.
*/

using System;

namespace Problema_10
{
    class Program
    {
        static void Main(string[] args)
        {
            String contrasena = "iloveyou123";
            Boolean bandera = false;

            do
            {
                Console.Write("\nIngrese la contraseña: ");
                contrasena = Console.ReadLine();

                if (contrasena.Equals("iloveyou123"))
                {
                    bandera = true;
                    Console.WriteLine("\n--> Contraseña correcta <--\n");
                }
                else
                {
                    Console.WriteLine("\n***Contraseña incorrecta");
                }

            } while (bandera == false);
            

        }
    }
}
