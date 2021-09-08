/*
Create by: Maria Camila Morales Galeano
Group: 239-2A
Shift: day
*/

/*
Problema 5:
Crea un array de caracteres que contenga de la ‘A’ a la ‘Z’ (solo las mayúsculas). Después, 
ve pidiendo posiciones del array por teclado y si la posicion es correcta, se añadira a una 
cadena que se mostrara al final, se dejará de insertar cuando se introduzca un -1.
Por ejemplo, si escribo los siguientes numeros
0 //Añadira la ‘A’
5 //Añadira la ‘F’
25 //Añadira la ‘Z’
50 //Error, inserte otro numero
-1 //fin
Cadena resultante: AFZ
*/

using System;

namespace Problema_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena ="";
            int posicion;
            char[] letras = {'A','B','C','D','E','F','G','H','I','J','K','L','M','N','Ñ','O','P','Q','R','S','T','U','V','W','X','Y','Z'};

            do{

                Console.Write("\nIngrese una pocisión del vector / Ingrese -1 para salir: ");
                posicion = Convert.ToInt32(Console.ReadLine());
                
                if(posicion >=0 && posicion <= letras.Length){
                    cadena += letras[posicion];
                }else{
                    if(posicion != -1){
                        Console.WriteLine("\nla posición esta fuera del rango del vector");
                    }
                }

            }while(posicion != -1);
            Console.WriteLine("\nCadena resultante: "+cadena);



        }
    }
}
