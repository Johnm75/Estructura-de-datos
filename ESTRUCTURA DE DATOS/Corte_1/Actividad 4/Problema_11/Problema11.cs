using System;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace C_
{
    class Problema11
    {
        static void Main(string[] args)
        {
            string pais=null;
            string[,] matriz = new string[4,3];
            


            for (int i = 0; i < 4; i++)
            {
                
                Console.WriteLine("DIGITE EL NOMBRE DEL PAIS: ");
                pais=Console.ReadLine();

                
                Console.WriteLine("escriba la primera ciudad de "+pais);
                matriz[i,0]=Console.ReadLine();
                Console.WriteLine("escriba la segunda ciudad de "+pais);
                matriz[i,1]=Console.ReadLine();
                Console.WriteLine("escriba la tercera ciudad de "+pais);
                matriz[i,2]=Console.ReadLine();
                
            }

            Console.WriteLine("Pais: "+pais+"     Ciudades:    "+matriz[0,0]+"    "+matriz[0,1]+"    "+matriz[0,2]);
            Console.WriteLine("Pais: "+pais+"     Ciudades:    "+matriz[1,0]+"    "+matriz[1,1]+"    "+matriz[1,2]);
            Console.WriteLine("Pais: "+pais+"     Ciudades:    "+matriz[2,0]+"    "+matriz[2,1]+"    "+matriz[2,2]);
            Console.WriteLine("Pais: "+pais+"     Ciudades:    "+matriz[3,0]+"    "+matriz[3,1]+"    "+matriz[3,2]);


            


            


            

            


            

            

            
       
            


        }
    }
}

