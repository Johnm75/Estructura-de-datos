using System;
//Authors:María Camila Morales Galeano,María Paula Leiva Agudelo,Jhon Fredy Marciales Morales,Juan david Ropero Prieto.
//Working day: Morning
//Group:239-2ª
namespace Problema8
{
    class Program
    {
        static void Main(string[] args)
        {
            /*7.Crea un array de números y otro de texto de 12 posiciones
             donde insertaremos notas entre 0 y 10 (debemos controlar que inserte una nota valida), pudiendo ser decimal la nota en el array de números, en 
            el de texto se insertaran los nombres de los alumnos.Después, 
            crearemos un array de String donde insertaremos
            el resultado de la nota con palabras.
            Si la nota esta entre 0 y 4,99 , es insuficiente
            Si esta entre 5 y 6,99 , sera un aceptable.
            Si esta entre 7 y 8,99 sera un sobresaliente.
            Si esta entre 9 y 10 sera un excelente.
            Muestra por pantalla, el alumno su nota y su resultado en palabras. Crea los métodos que creas conveniente.
            */
            double[] numeros = new double[12];
            string[] texto = new string[12];
            string[] resultado = {"insuficiente", "aceptable", "sobresaliente","excelente"};
            int indice = 0;
            double nota;

            for (int i = 0; i < numeros.Length; i++)
            {

                Console.Write($"Ingrese el NOMBRE del estudiante {i+1}: ");
                texto[i] = Console.ReadLine();
                do
                {
                    Console.Write($"Ingrese la NOTA (0-10) del estudiante {i+1}: ");
                    nota = Convert.ToInt32(Console.ReadLine());

                } while (!(nota >= 0 && nota <= 10)); 
                    numeros[i]=nota;
                    Console.WriteLine("");
            }
            for (int j = 0; j < numeros.Length; j++)
            {
               if(numeros[j] >=0 && numeros[j] <=4.99)
               {
                   indice=0;
               }else if (numeros[j] >=5 && numeros[j] <=6.99)
               {
                   indice=1;
               }else if (numeros[j] >=7 && numeros[j] <=8.99)
               {
                   indice=2;
               }else if (numeros[j] >=9 && numeros[j] <=10)
               {
                   indice=3;
               }
               Console.WriteLine($"La nota del estudiante {texto[j]} es {numeros[j]}, entonces su resultado es {resultado[indice]} ");
            }
        }
    }
}