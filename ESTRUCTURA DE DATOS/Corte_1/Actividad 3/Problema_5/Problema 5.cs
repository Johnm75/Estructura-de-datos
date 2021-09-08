using System;
using System.Linq;
//Authors:María Camila Morales Galeano,María Paula Leiva Agudelo,Jhon Fredy Marciales Morales,Juandavid Ropero Prieto.
//Working day: Morning
//Group:239-2ª

namespace Problema_5
{
    class Problema_5
    {
        static void Main(string[] args)
        {
            int n;
            string dato;
            
            Console.WriteLine(" Por favor ingrese un número de 4 cifras sin digitos repetidos: ");
            dato=Console.ReadLine();
            
            if(dato.Length != 4){
                Console.WriteLine("El numero no tiene 4 cifras");
                return;
            }

            n = Convert.ToInt32(dato);

            for(int i = 0; i < 4;i++){
                int count = dato.Count(f => f == dato[i]);
                if(count != 1){
                    Console.WriteLine("El numero no puede contener digitos repetidos");
                    return;
                }
            }

            char[] characters = dato.ToArray();
            Array.Sort(characters);

            Console.WriteLine("El numero es valido ahora que quieres: ");
            
            Console.WriteLine("1.Mostrar numero menor ");
            Console.WriteLine("2.Mostrar numero mayor ");
            string opcion = Console.ReadLine();
            int opcionNumerico = Convert.ToInt32(opcion);
            if(opcionNumerico == 1)
            {
            string menor = new string(characters);
            Console.WriteLine("Menor numero : " + menor);
            }
            else if(opcionNumerico == 2)
            {
                Array.Reverse(characters);
                string mayor = new string(characters);
                Console.WriteLine("Mayor numero : " + mayor); 
            }
            else
            {
                Console.WriteLine("Opción inválida");
            }
            
            
            


        }
    }
}
