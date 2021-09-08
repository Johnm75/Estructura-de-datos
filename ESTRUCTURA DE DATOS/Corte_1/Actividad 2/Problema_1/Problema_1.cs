/*
Create by: Maria Camila Morales Galeano, 
           Maria Paula Leiva Agudelo,
           Juan David Ropero Prieto,
           John Fredy Marciales Morales.
Group: 239-2A
Shift: day
*/

/*
Problema 1:
Crear un programa que pida una calificación de 0 a 100 para las materias de Matemáticas
español, inglés y Física para 5 estudiantes que se registren al iniciar el programa los
resultados deberán mostrar la información de la siguiente manera:Insuficiente (Menor a 50
Suficiente (De 50 a 69)Bien (De 60 a 79)Notable (De 70 a 89)Sobresaliente (De 90 a 100)en
cada estudiante y materia.
*/

using System;

namespace Problema_1
{
    class Problema_1
    {
        
        static void Main(string[] args)
        {
            int matematicas;
            int espanol;
            int ingles;
            int fisica;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("\nIngrese las calificaciones del estudiante "+(i+1)+": ");
                
                Console.Write("->Matematicas: ");
                matematicas = Convert.ToInt32(Console.ReadLine());
                Console.Write(deUnoACien(matematicas));
                

                Console.Write("\n->Español: ");
                espanol = Convert.ToInt32(Console.ReadLine());
                Console.Write(deUnoACien(espanol));
                

                Console.Write("\n->Ingles: ");
                ingles = Convert.ToInt32(Console.ReadLine());
                Console.Write(deUnoACien(ingles));
             

                Console.Write("\n->Fisica: ");
                fisica = Convert.ToInt32(Console.ReadLine());
                Console.Write(deUnoACien(fisica));
                Console.WriteLine(" ");

            }
            
        }
        private static string deUnoACien(int nota){
            string mensaje = " ";
            if(nota >= 0 && nota <= 100){
                if(nota < 50){
                    mensaje = "  ->Insuficiente";
                    
                }else if(nota >= 50 && nota <= 69){
                    mensaje = "  ->Suficiente";
                    
                }else if(nota >= 69 && nota <= 79){
                    mensaje = "  ->Bien";
                    
                }else if(nota >= 70 && nota <= 89){
                    mensaje = "  ->Notable";
                    
                }else if(nota >= 90 && nota <= 100){
                    
                    mensaje = "  ->Sobresaliente";
                }
            }else{
                 mensaje = "  ->ERROR";
                             
            }
            return mensaje;
        }
    }
}
