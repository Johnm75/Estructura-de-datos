using System;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace C_
{
    class Problema10
    {
        static void Main(string[] args)
        {
            string idioma=null,id;
            int[,] matriz = new int[3,4];
            


            for (int i = 0; i < 4; i++)
            {
                
                if (i==0)
                {
                    idioma="ingles";

                }
                else if(i==1)
                {
                    idioma="frances";
                }
                else if(i==2)
                {
                    idioma="Aleman";
                }
                else if(i==3)
                {
                    idioma="ruso";
                }
                id=idioma;
                Console.WriteLine("escriba el numero de estudiantes en nivel basico de "+idioma);
                matriz[0,i]=int.Parse(System.Console.ReadLine());
                Console.WriteLine("escriba el numero de estudiantes en nivel medio de "+idioma);
                matriz[1,i]=int.Parse(System.Console.ReadLine());
                Console.WriteLine("escriba el numero de estudiantes en nivel perfeccionamiento de "+idioma);
                matriz[2,i]=int.Parse(System.Console.ReadLine());
                
            }

            Console.WriteLine("INGLES:   basico="+matriz[0,0]+ " medio="+matriz[1,0]+" perfeccionamiento="+matriz[2,0]);

            Console.WriteLine("FRANCES:  basico="+matriz[0,1]+ " medio="+matriz[1,1]+" perfeccionamiento="+matriz[2,1]);

            Console.WriteLine("ALEMAN:   basico="+matriz[0,2]+ " medio="+matriz[1,2]+" perfeccionamiento="+matriz[2,2]);

            Console.WriteLine("RUSO:     basico="+matriz[0,3]+ " medio="+matriz[1,3]+" perfeccionamiento="+matriz[2,3]);
            


            


            

            


            

            

            
       
            


        }
    }
}

