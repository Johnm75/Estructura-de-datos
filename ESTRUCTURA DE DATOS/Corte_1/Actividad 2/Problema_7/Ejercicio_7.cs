using System;
//Authors:María Camila Morales Galeano,María Paula Leiva Agudelo,Jhon Fredy Marciales Morales,Juandavid Ropero Prieto.
//Working day: Morningdotnet run
//Group:239-2ª

namespace Ejercicio_7
{
    class Ejercicio_7
    {
        static void Main(string[] args)
        {
            string cadena;
            int vocales = 0;
            int consonantes = 0;
            int numeros = 0;
    
            Console.Write("Ingrese una frase: ");
            cadena = Console.ReadLine();
            foreach (char item in cadena)
            {   
                if(char.IsLetter(item)){                   
                    if ((item == 'a' || item == 'e' || item == 'i' || item == 'o' || item == 'u') || 
                    (item == 'A' || item == 'E' || item == 'I' || item == 'O' || item == 'U')){
                        vocales++;
                    }else{
                        consonantes++;
                    }   
                }else if(char.IsNumber(item)){
                    numeros++;
                }                      
            }
            Console.WriteLine("\nCantidad de vocales: "+vocales);
            Console.WriteLine("Cantidad de consonates: "+consonantes);
            Console.WriteLine("Cantidad de números: "+numeros+"\n");
        }
    }
}
