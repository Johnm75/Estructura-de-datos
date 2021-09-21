//Authors:María Camila Morales Galeano,María Paula Leiva Agudelo,Jhon Fredy Marciales Morales,Juandavid Ropero Prieto.
//Working day: Morning
//Group:239-2ª

using System;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace ESTRUCTURA_DE_DATOS
{
    class Problema7
    {
        static void Main(string[] args)
        {
            int estrato=0;
            float descuento;
            
            float[,] matriz = new float[3,3];
            


            for (int i = 0; i < 3; i++)
            {
                
                Console.WriteLine("CUAL ES EL ESTRATO LA FAMILIA "+(i+1)+ ":");
                estrato=int.Parse(Console.ReadLine());

                
                Console.WriteLine("Ingrese el valor del agua ");
                matriz[i,0]=int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el valor de la luz ");
                matriz[i,1]=int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el valor del gas ");
                matriz[i,2]=int.Parse(Console.ReadLine());
                
                if (estrato==1)
            {
                
                descuento=0.2f;
                Console.WriteLine("EL VALOR DEL AGUA PARA LA FAMILIA "+(i+1)+" ES DE: " +(matriz[i,0]-(matriz[i,0]*descuento)));
                Console.WriteLine("EL VALOR DELA LUZ PARA LA FAMILIA "+(i+1)+" ES DE: " +(matriz[i,1]-(matriz[i,1]*descuento)));
                Console.WriteLine("EL VALOR DEL GAS PARA LA FAMILIA "+(i+1)+" ES DE: " +(matriz[i,2]-(matriz[i,2]*descuento)));
                
            }
            else if(estrato==2)
            {
                descuento=0.15f;
                Console.WriteLine("EL VALOR DEL AGUA PARA LA FAMILIA "+(i+1)+" ES DE: " +(matriz[i,0]-(matriz[1,0]*descuento)));
                Console.WriteLine("EL VALOR DE LA LUZ PARA LA FAMILIA "+(i+1)+" ES DE: " +(matriz[i,1]-(matriz[1,1]*descuento)));
                Console.WriteLine("EL VALOR DEL GAS PARA LA FAMILIA "+(i+1)+" ES DE: " +(matriz[i,2]-(matriz[1,2]*descuento)));

            }
            else if(estrato>=3)
            {
                descuento=0.09f;
                Console.WriteLine("EL VALOR DEL AGUA PARA LA FAMILIA "+(i+1)+" ES DE: " +(matriz[i,0]-(matriz[i,0]*descuento)));
                Console.WriteLine("EL VALOR DE LA LUZ PARA LA FAMILIA "+(i+1)+" ES DE: " +(matriz[i,1]-(matriz[i,1]*descuento)));
                Console.WriteLine("EL VALOR DEL GAS PARA LA FAMILIA "+(i+1)+" ES DE: " +(matriz[i,2]-(matriz[i,2]*descuento)));

            }
            
            }

            
        }
    }
}


            


            


            


            

            


            

            

            
       
            

