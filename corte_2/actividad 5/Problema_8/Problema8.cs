//Authors:María Camila Morales Galeano,María Paula Leiva Agudelo,Jhon Fredy Marciales Morales,Juandavid Ropero Prieto.
//Working day: Morning
//Group:239-2ª

using System;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace ESTRUCTURA_DE_DATOS
{
    class Problema8
    {
        static void Main(string[] args)
        {
            
            float precio=0f,precio1=0f,precio2=0f,precio3=0f,precio4=0f,precio5=0f,total=0f,sucursal1=0f,sucursal2=0f,sucursal3=0f,sucursal4=0f;
            String mayor="";
            float[,] matriz = new float[5,4];
            


            for (int i = 0; i < 5; i++)
            {
                
                Console.WriteLine("CUAL ES EL PRECIO DEL ARTICULO "+(i+1)+ " ?");
                precio=int.Parse(Console.ReadLine());

                
                Console.WriteLine("Ingrese la cantidad en la sucursal 1 ");
                matriz[i,0]=int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la cantidad en la sucursal 2");
                matriz[i,1]=int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la cantidad en la sucursal 3 ");
                matriz[i,2]=int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la cantidad en la sucursal 4 ");
                matriz[i,3]=int.Parse(Console.ReadLine());
                if (i==0)
                {
                    precio1=precio;
                }
                else if (i==1)
                {
                    precio2=precio;
                }
                
                else if (i==2)
                {
                    precio3=precio;
                }
                
                else if (i==3)
                {
                    precio4=precio;
                }
                
                else if (i==4)
                {
                    precio5=precio;
                }
                
            }
            sucursal1=((matriz[0,0]*precio1)+(matriz[1,0]*precio2)+(matriz[2,0]*precio3)+(matriz[3,0]*precio4)+(matriz[4,0]*precio5));
            sucursal2=((matriz[0,1]*precio1)+(matriz[1,1]*precio2)+(matriz[2,1]*precio3)+(matriz[3,1]*precio4)+(matriz[4,1]*precio5));
            sucursal3=((matriz[0,2]*precio1)+(matriz[1,2]*precio2)+(matriz[2,2]*precio3)+(matriz[3,2]*precio4)+(matriz[4,2]*precio5));
            sucursal4=((matriz[0,3]*precio1)+(matriz[1,3]*precio2)+(matriz[2,3]*precio3)+(matriz[3,3]*precio4)+(matriz[4,3]*precio5));
            total=(sucursal1+sucursal2+sucursal3+sucursal4);
            if (sucursal1>sucursal2&&sucursal1>sucursal3&&sucursal1>sucursal4)
            {
                mayor="sucursal 1";
            }
            else if (sucursal2>sucursal1&&sucursal2>sucursal3&&sucursal2>sucursal3)
            {
                mayor="sucursal 2";
            }
            else if (sucursal3>sucursal1&&sucursal3>sucursal2&&sucursal3>sucursal4)
            {
                mayor="sucursal 3";
            }
            else if (sucursal4>sucursal1&&sucursal4>sucursal2&&sucursal4>sucursal3)
            {
                mayor="sucursal 4";
            }
            Console.WriteLine("cantidad total articulo 1 "+(matriz[0,0]+matriz[0,1]+matriz[0,2]+matriz[0,3])*precio1);
            Console.WriteLine("cantidad total articulo 2 "+(matriz[1,0]+matriz[1,1]+matriz[1,2]+matriz[1,3])*precio2);
            Console.WriteLine("cantidad total articulo 3 "+(matriz[2,0]+matriz[2,1]+matriz[2,2]+matriz[2,3])*precio3);
            Console.WriteLine("cantidad total articulo 4 "+(matriz[3,0]+matriz[3,1]+matriz[3,2]+matriz[3,3])*precio4);
            Console.WriteLine("cantidad total articulo 5 "+(matriz[4,0]+matriz[4,1]+matriz[4,2]+matriz[4,3])*precio5);
            Console.WriteLine("");
            Console.WriteLine("cantidad total articulos en la sucursal 2 :"+(matriz[0,1]+matriz[1,1]+matriz[2,1]+matriz[3,1]+matriz[4,1]));
            Console.WriteLine("");
            Console.WriteLine("cantidad total articulo 3 en la sucursal 1 :"+(matriz[3,0]));
            Console.WriteLine("");
            
            Console.WriteLine("recaudacion total en la sucursal 1 :"+sucursal1);
            Console.WriteLine("recaudacion total en la sucursal 2:"+sucursal2);
            Console.WriteLine("recaudacion total en la sucursal 3:"+sucursal3);
            Console.WriteLine("recaudacion total en la sucursal 4:"+sucursal4);
            Console.WriteLine("");

            Console.WriteLine("recaudacion total de la empresa :"+total);
            Console.WriteLine("");
            Console.WriteLine("la sucursal con mayor recaudacion fue :"+mayor);


            
        }
    }
}


            


            


            


            

            


            

            

            
       
            

